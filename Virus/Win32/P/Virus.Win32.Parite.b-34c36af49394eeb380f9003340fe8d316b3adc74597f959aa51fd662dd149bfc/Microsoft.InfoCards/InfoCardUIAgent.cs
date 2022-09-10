using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Threading;
using Microsoft.InfoCards.Diagnostics;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.InfoCards;

internal class InfoCardUIAgent
{
	private class UInt32IndexedHybridDictionary
	{
		private HybridDictionary m_realDictionary = new HybridDictionary();

		public int Count => m_realDictionary.Count;

		public ICollection Values => m_realDictionary.Values;

		public object this[uint index]
		{
			get
			{
				return m_realDictionary[index];
			}
			set
			{
				m_realDictionary[index] = value;
			}
		}

		public void Remove(uint index)
		{
			m_realDictionary.Remove(index);
		}
	}

	public enum CallMode
	{
		Sleep,
		Initialize,
		GetToken,
		Manage,
		Import,
		Shutdown,
		Crash,
		Error,
		Release
	}

	private const string UiAgentName = "icardagt.exe";

	private const string IdleTimeoutKey = "software\\microsoft\\infocard";

	private const int IdleTimeoutDefault = 300;

	private const string IdleTimeoutValue = "sleep1";

	public static readonly string UiAgentFullPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "icardagt.exe");

	private static bool s_initialized;

	private static bool s_isShuttingDown;

	private static ManualResetEvent s_doneShuttingDownEvent = new ManualResetEvent(initialState: false);

	private static UInt32IndexedHybridDictionary s_sessionIdCollection = new UInt32IndexedHybridDictionary();

	private static UInt32IndexedHybridDictionary s_pidCollection = new UInt32IndexedHybridDictionary();

	private readonly TimeSpan AgentStateChangeTimeOut = new TimeSpan(0, 0, 300);

	private static TimeSpan s_idleTimeout = new TimeSpan(0, 0, 300);

	private static object s_syncRoot = new object();

	private ManualResetEvent m_uiStatusRecieved;

	private AutoResetEvent m_agentGetWorkStart;

	private AutoResetEvent m_agentGetWorkComplete;

	private ClientUIRequest m_request;

	private int m_tsSessionId;

	private Process m_process;

	private EventHandler m_processExitHandler;

	private Timer m_timer;

	private string m_trustedUserSid;

	private SafeNativeHandle m_trustedUserToken;

	private string m_desktopName;

	private string m_user;

	private CallMode m_mode;

	private RpcUIAgentGetWorkCallback m_getWorkCallback;

	private ClientUIRequest.RequestResult m_currentStatus;

	private object m_memberSync;

	public uint ProcessId => (uint)m_process.Id;

	public string DesktopName => m_desktopName;

	private ClientUIRequest Request => m_request;

	public int TsSessionId => m_tsSessionId;

	public bool IsActive
	{
		get
		{
			switch (m_mode)
			{
			default:
				return false;
			case CallMode.GetToken:
			case CallMode.Manage:
			case CallMode.Import:
			case CallMode.Error:
				return true;
			}
		}
	}

	public bool IsShuttingDown => m_mode == CallMode.Shutdown;

	public SafeNativeHandle TrustedUserToken => m_trustedUserToken;

	public string TrustedUserSid => m_trustedUserSid;

	public string User => m_user;

	private InfoCardUIAgent(int callerPid, WindowsIdentity userIdentity, int tsSessionId)
	{
		m_agentGetWorkStart = new AutoResetEvent(initialState: false);
		m_agentGetWorkComplete = new AutoResetEvent(initialState: false);
		m_uiStatusRecieved = new ManualResetEvent(initialState: false);
		m_tsSessionId = tsSessionId;
		m_timer = null;
		IntPtr processHandle = IntPtr.Zero;
		IntPtr trustedUserToken = IntPtr.Zero;
		int pid = 0;
		m_mode = CallMode.Sleep;
		m_currentStatus = ClientUIRequest.RequestResult.Pending;
		m_user = userIdentity.User!.ToString();
		m_memberSync = new object();
		int num = NativeMcppMethods.VerifyTrust(UiAgentFullPath);
		if (num != 0)
		{
			InfoCardTrace.FailFast(SR.GetString("FailedToVerifySignature", new object[1] { num }));
		}
		IntPtr zero = IntPtr.Zero;
		num = (int)NativeMcppMethods.CreateProcessAsTrustedUserWrapper(UiAgentFullPath, "", (uint)callerPid, "WinSta0\\Default", userIdentity.Name, (uint)m_tsSessionId, ref trustedUserToken, ref processHandle, ref pid, zero, ref m_trustedUserSid, fElevateToken: false);
		if (num != 0)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new FailedToStartupUIException(SR.GetString("CreateProcessFailed", new object[1] { num }), new Win32Exception(num)));
		}
		m_trustedUserToken = new SafeNativeHandle(trustedUserToken, ownsHandle: true);
		using SafeWaitHandle processHandle2 = new SafeWaitHandle(processHandle, ownsHandle: true);
		m_process = ProcessMonitor.GetProcessById(pid);
		m_processExitHandler = OnProcessExit;
		m_process.Exited += m_processExitHandler;
		Utility.ThrowIfProcessExited(processHandle2);
	}

	private static void InitializeIfNecessary()
	{
		if (s_initialized)
		{
			return;
		}
		lock (s_syncRoot)
		{
			if (s_initialized)
			{
				return;
			}
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("software\\microsoft\\infocard", writable: false))
			{
				if (registryKey != null)
				{
					object value = registryKey.GetValue("sleep1", 300);
					if (value is int && (int)value > 0)
					{
						s_idleTimeout = new TimeSpan(0, 0, (int)value);
					}
				}
			}
			s_initialized = true;
		}
	}

	public static InfoCardUIAgent Create(int callerPid, WindowsIdentity callerIdentity, int tsSessionId)
	{
		InitializeIfNecessary();
		InfoCardUIAgent infoCardUIAgent = null;
		lock (s_syncRoot)
		{
			ThrowIfShuttingDown();
			infoCardUIAgent = (InfoCardUIAgent)s_sessionIdCollection[(uint)tsSessionId];
			if (infoCardUIAgent != null)
			{
				if (infoCardUIAgent.IsShuttingDown)
				{
					infoCardUIAgent = null;
				}
				else
				{
					if (infoCardUIAgent.Request != null)
					{
						throw InfoCardTrace.ThrowHelperError((Exception)(object)new ServiceBusyException());
					}
					if (infoCardUIAgent.User != callerIdentity.User!.ToString())
					{
						infoCardUIAgent.Shutdown();
						infoCardUIAgent = null;
					}
				}
			}
			if (infoCardUIAgent == null)
			{
				infoCardUIAgent = new InfoCardUIAgent(callerPid, callerIdentity, tsSessionId);
				s_pidCollection[infoCardUIAgent.ProcessId] = infoCardUIAgent;
				s_sessionIdCollection[(uint)tsSessionId] = infoCardUIAgent;
				return infoCardUIAgent;
			}
			return infoCardUIAgent;
		}
	}

	public RpcUIAgentGetWorkCallback Bind(string desktopName, out SecurityIdentifier userSid, out SafeWaitHandle hStartEvent, out SafeWaitHandle hCompleteEvent)
	{
		lock (m_memberSync)
		{
			userSid = new SecurityIdentifier(m_trustedUserSid);
			hStartEvent = Utility.GetRemoteHandleFromLocalHandle(m_agentGetWorkStart.SafeWaitHandle, m_process);
			hCompleteEvent = Utility.GetRemoteHandleFromLocalHandle(m_agentGetWorkComplete.SafeWaitHandle, m_process);
			m_desktopName = desktopName;
			return m_getWorkCallback = GetWork;
		}
	}

	public void ResetUIResult()
	{
		m_currentStatus = ClientUIRequest.RequestResult.Pending;
		m_uiStatusRecieved.Reset();
	}

	public ClientUIRequest.RequestResult ShowUI(CallMode mode)
	{
		if (m_currentStatus == ClientUIRequest.RequestResult.Pending)
		{
			bool flag = false;
			lock (m_memberSync)
			{
				if (m_currentStatus == ClientUIRequest.RequestResult.Pending)
				{
					switch (mode)
					{
					default:
						InfoCardTrace.ThrowInvalidArgumentConditional(true, "mode");
						break;
					case CallMode.GetToken:
					case CallMode.Manage:
					case CallMode.Import:
					case CallMode.Error:
						if (SetMode(mode))
						{
							flag = true;
						}
						break;
					}
				}
			}
			if (flag)
			{
				WaitForModeChange();
			}
			m_uiStatusRecieved.WaitOne();
		}
		return m_currentStatus;
	}

	public void SetUIStatus(ClientUIRequest.RequestResult status)
	{
		lock (m_memberSync)
		{
			m_currentStatus = status;
			if (m_request != null && (ClientUIRequest.RequestResult.Cancel == m_currentStatus || ClientUIRequest.RequestResult.Untrusted == m_currentStatus || ClientUIRequest.RequestResult.Error == m_currentStatus))
			{
				m_request.UserCancel(ClientUIRequest.RequestResult.Untrusted == m_currentStatus);
			}
			m_uiStatusRecieved.Set();
		}
	}

	public void SetRequest(ClientUIRequest request)
	{
		InfoCardTrace.Assert(null != request, "Request should not be null", new object[0]);
		bool flag = false;
		lock (s_syncRoot)
		{
			if (m_timer != null)
			{
				m_timer.Dispose();
				m_timer = null;
			}
			m_request = request;
			if (SetMode(CallMode.Initialize))
			{
				flag = true;
			}
			m_currentStatus = ClientUIRequest.RequestResult.Pending;
			m_uiStatusRecieved.Reset();
		}
		if (flag)
		{
			WaitForModeChange();
		}
	}

	private bool SetMode(CallMode mode)
	{
		bool result = false;
		lock (m_memberSync)
		{
			if (CallMode.Shutdown != m_mode)
			{
				if (m_mode != mode)
				{
					switch (mode)
					{
					case CallMode.Sleep:
						InfoCardTrace.ThrowInvalidArgumentConditional(m_mode != CallMode.Release, "mode");
						break;
					case CallMode.Initialize:
						InfoCardTrace.ThrowInvalidArgumentConditional(m_mode != CallMode.Sleep, "mode");
						break;
					default:
						InfoCardTrace.ThrowInvalidArgumentConditional(true, "mode");
						break;
					case CallMode.GetToken:
					case CallMode.Manage:
					case CallMode.Import:
					case CallMode.Error:
						InfoCardTrace.ThrowInvalidArgumentConditional(m_mode != CallMode.Initialize, "mode");
						break;
					case CallMode.Release:
						switch (m_mode)
						{
						default:
							InfoCardTrace.ThrowInvalidArgumentConditional(true, "mode");
							break;
						case CallMode.Initialize:
						case CallMode.GetToken:
						case CallMode.Manage:
						case CallMode.Import:
						case CallMode.Error:
							break;
						}
						break;
					case CallMode.Shutdown:
						break;
					}
					m_mode = mode;
					return true;
				}
				return result;
			}
			return result;
		}
	}

	public void ReleaseUI()
	{
		if ((IsActive || CallMode.Initialize == m_mode) && SetMode(CallMode.Release))
		{
			WaitForModeChange();
		}
	}

	private void WaitForModeChange()
	{
		m_agentGetWorkStart.Set();
		if (!m_agentGetWorkComplete.WaitOne(AgentStateChangeTimeOut, exitContext: false))
		{
			Utility.KillHelper(m_process);
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException(SR.GetString("UIAgentCrash")));
		}
	}

	private void GetWork(out CallMode mode, out int requestHandle)
	{
		lock (m_memberSync)
		{
			mode = CallMode.Shutdown;
			requestHandle = 0;
			try
			{
				mode = m_mode;
				if (m_request != null)
				{
					requestHandle = m_request.RequestHandle;
				}
				if (mode == CallMode.Sleep)
				{
					m_timer = new Timer(InfoCardTrace.ThunkCallback((TimerCallback)OnTimeout), null, s_idleTimeout, new TimeSpan(0, 0, 0, 0, -1));
				}
			}
			catch (Exception ex)
			{
				if (InfoCardTrace.IsFatal(ex))
				{
					InfoCardService.Crash(ex);
				}
				ClientUIRequest request = Request;
				if (request != null)
				{
					request.ProcessingException = ex;
				}
			}
		}
	}

	public void ClearRequest(ClientUIRequest request)
	{
		bool flag = false;
		lock (s_syncRoot)
		{
			if (m_request == request)
			{
				if (SetMode(CallMode.Sleep))
				{
					flag = true;
				}
				m_request = null;
			}
		}
		if (flag)
		{
			WaitForModeChange();
			if (ClientUIRequest.RequestResult.Error == m_currentStatus)
			{
				Shutdown();
			}
		}
	}

	private void OnTimeout(object state)
	{
		lock (s_syncRoot)
		{
			if (m_request == null && !IsShuttingDown)
			{
				Shutdown();
			}
		}
	}

	private void OnProcessExit(int exitCode)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected I4, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Invalid comparison between Unknown and I4
		lock (s_syncRoot)
		{
			m_mode = CallMode.Shutdown;
			s_pidCollection.Remove(ProcessId);
			s_sessionIdCollection.Remove((uint)TsSessionId);
			if (m_request != null && (m_currentStatus == ClientUIRequest.RequestResult.Pending || ClientUIRequest.RequestResult.Ok == m_currentStatus))
			{
				EventCode val = (EventCode)exitCode;
				EventCode val2 = val;
				switch (val2 - -1073413870)
				{
				default:
					if ((int)val2 != -1073413862)
					{
						m_request.UserCancel(untrusted: false);
						m_currentStatus = ClientUIRequest.RequestResult.UICrashed;
					}
					else
					{
						m_request.UserCancel(untrusted: false);
						m_currentStatus = ClientUIRequest.RequestResult.UIFailedInitialization;
					}
					break;
				case 0:
					m_request.UserCancel(untrusted: true);
					m_currentStatus = ClientUIRequest.RequestResult.Untrusted;
					break;
				case 1:
					m_request.UserCancel(untrusted: false);
					m_currentStatus = ClientUIRequest.RequestResult.Cancel;
					break;
				}
				m_uiStatusRecieved.Set();
			}
			m_agentGetWorkComplete.Set();
			if (s_isShuttingDown && s_pidCollection.Count == 0)
			{
				s_doneShuttingDownEvent.Set();
			}
			if (m_timer != null)
			{
				m_timer.Dispose();
				m_timer = null;
			}
			if (m_trustedUserToken != null)
			{
				m_trustedUserToken.Dispose();
				m_trustedUserToken = null;
			}
		}
	}

	private void OnProcessExit(object sender, EventArgs e)
	{
		m_process.Exited -= m_processExitHandler;
		Process process = sender as Process;
		InfoCardTrace.Assert(null != process, "Should be of type process.", new object[0]);
		InfoCardTrace.Assert(process.ExitCode == m_process.ExitCode, "Should be the same!", new object[0]);
		OnProcessExit(process.ExitCode);
	}

	private static void ThrowIfShuttingDown()
	{
		if (s_isShuttingDown)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new SystemShuttingDownException());
		}
	}

	private void Shutdown()
	{
		if (SetMode(CallMode.Shutdown))
		{
			WaitForModeChange();
		}
	}

	private void Kill()
	{
		Utility.KillHelper(m_process);
	}

	public static void OnLogout(uint sessionId)
	{
		if (!s_initialized)
		{
			return;
		}
		InfoCardUIAgent infoCardUIAgent = null;
		lock (s_syncRoot)
		{
			((InfoCardUIAgent)s_sessionIdCollection[sessionId])?.Shutdown();
		}
	}

	public static void DoShutdown()
	{
		bool flag = false;
		if (!s_initialized)
		{
			return;
		}
		lock (s_syncRoot)
		{
			s_isShuttingDown = true;
			foreach (InfoCardUIAgent value in s_sessionIdCollection.Values)
			{
				flag = true;
				value.Shutdown();
			}
		}
		if (!flag || s_doneShuttingDownEvent.WaitOne(new TimeSpan(0, 0, 15), exitContext: false))
		{
			return;
		}
		lock (s_syncRoot)
		{
			foreach (InfoCardUIAgent value2 in s_sessionIdCollection.Values)
			{
				value2.Kill();
			}
		}
	}

	public static InfoCardUIAgent FindByPid(uint pid)
	{
		lock (s_syncRoot)
		{
			return (InfoCardUIAgent)s_pidCollection[pid];
		}
	}
}
