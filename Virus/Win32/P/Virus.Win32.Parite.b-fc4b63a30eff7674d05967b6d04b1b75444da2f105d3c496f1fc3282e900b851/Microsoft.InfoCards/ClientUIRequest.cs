using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Threading;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal abstract class ClientUIRequest : ClientRequest
{
	private class ProcessHandleDictionary : HandleDictionary<Process>
	{
	}

	public enum RequestResult
	{
		Pending,
		Ok,
		Cancel,
		Untrusted,
		Error,
		UIFailedInitialization,
		UICrashed
	}

	private static object s_syncRoot = new object();

	private static ProcessHandleDictionary s_connectedProcesses = new ProcessHandleDictionary();

	private ManualResetEvent m_uiAgentDone;

	private StoreConnection m_rootStoreReference;

	private volatile InfoCardUIAgent m_uiAgent;

	private InfoCardUIAgent.CallMode m_uiAgentMode;

	private AccessibilityApplicationManager m_atManager = new AccessibilityApplicationManager();

	public InfoCardUIAgent.CallMode UIAgentMode => m_uiAgentMode;

	internal InfoCardUIAgent UIAgent => m_uiAgent;

	public int UIAgentPid => (int)UIAgent.ProcessId;

	public string UIAgentLogonSid => UIAgent.TrustedUserSid;

	public bool UIAgentActive
	{
		get
		{
			if (UIAgent != null)
			{
				return UIAgent.IsActive;
			}
			return false;
		}
	}

	public ClientUIRequest(Process callingProcess, WindowsIdentity callingIdentity, InfoCardUIAgent uiAgent, IntPtr rpcHandle, Stream inArgs, Stream outArgs, InfoCardUIAgent.CallMode callMode, ExceptionList recoverableExceptions)
		: base(callingProcess, callingIdentity, rpcHandle, inArgs, outArgs, recoverableExceptions)
	{
		m_uiAgentMode = callMode;
		m_uiAgentDone = new ManualResetEvent(initialState: false);
		m_uiAgent = uiAgent;
		m_uiAgent.SetRequest(this);
	}

	public static int BindToService(IntPtr rpcHandle, out IntPtr context)
	{
		//IL_00a8: Expected O, but got Unknown
		int result = 0;
		context = IntPtr.Zero;
		try
		{
			Process process = ClientRequest.GetCallingProcessFromRpcHandle(rpcHandle);
			WindowsIdentity windowsIdentity = NativeMcppMethods.CreateServiceExecutionIdentity(process);
			WindowsImpersonationContext val = windowsIdentity.Impersonate();
			try
			{
				int num = 0;
				lock (s_syncRoot)
				{
					try
					{
						try
						{
							num = s_connectedProcesses.GetNewHandle();
						}
						catch (IndexOutOfRangeException inner)
						{
							throw InfoCardTrace.ThrowHelperError((Exception)(object)new ServiceBusyException(SR.GetString("TooManyClientUIConnections"), inner));
						}
						s_connectedProcesses[num] = process;
						context = new IntPtr(num);
						num = 0;
						process = null;
						return result;
					}
					finally
					{
						process?.Dispose();
						if (num != 0)
						{
							s_connectedProcesses.Remove(num);
						}
					}
				}
			}
			finally
			{
				val.Undo();
			}
		}
		catch (InfoCardBaseException val2)
		{
			InfoCardBaseException val3 = val2;
			return val3.get_NativeHResult();
		}
	}

	public static Process GetContextMapping(IntPtr context, bool clear)
	{
		int key = context.ToInt32();
		Process result = null;
		lock (s_syncRoot)
		{
			if (s_connectedProcesses.ContainsHandle(key))
			{
				result = s_connectedProcesses[key];
				if (clear)
				{
					s_connectedProcesses.Remove(key);
					return result;
				}
				return result;
			}
			return result;
		}
	}

	public static void RemoveAndDisposeContextMapping(IntPtr context)
	{
		GetContextMapping(context, clear: true)?.Dispose();
	}

	protected override void OnInitializeAsUser()
	{
		base.OnInitializeAsUser();
		m_rootStoreReference = StoreConnection.CreateConnection();
	}

	protected override void PreProcessRequest()
	{
		//IL_0023: Expected O, but got Unknown
		try
		{
			base.PreProcessRequest();
		}
		catch (UIAgentInitializationException)
		{
			throw;
		}
		catch (UserCancelledException)
		{
			throw;
		}
		catch (UntrustedRecipientException)
		{
			throw;
		}
		catch (UIAgentCrashedException)
		{
			throw new CommunicationException(SR.GetString("UIAgentCrash"));
		}
		catch (InfoCardBaseException val2)
		{
			InfoCardBaseException ex4 = val2;
			throw ShowError((Exception)(object)ex4);
		}
	}

	protected override void ProcessRequest()
	{
		//IL_0023: Expected O, but got Unknown
		try
		{
			base.ProcessRequest();
		}
		catch (UntrustedRecipientException)
		{
			throw;
		}
		catch (UIAgentInitializationException)
		{
			throw;
		}
		catch (UserCancelledException)
		{
			throw;
		}
		catch (UIAgentCrashedException)
		{
			throw new CommunicationException(SR.GetString("UIAgentCrash"));
		}
		catch (InfoCardBaseException val2)
		{
			InfoCardBaseException ex4 = val2;
			throw ShowError((Exception)(object)ex4);
		}
	}

	protected override void PostProcessRequest()
	{
		//IL_0009: Expected O, but got Unknown
		try
		{
			base.PostProcessRequest();
		}
		catch (InfoCardBaseException val)
		{
			InfoCardBaseException ex = val;
			throw ShowError((Exception)(object)ex);
		}
	}

	protected Exception ShowError(Exception ex)
	{
		if (m_uiAgent.IsShuttingDown)
		{
			return ex;
		}
		base.ProcessingException = ex;
		m_uiAgent.ResetUIResult();
		RequestResult requestResult = m_uiAgent.ShowUI(InfoCardUIAgent.CallMode.Error);
		if (RequestResult.Untrusted == requestResult)
		{
			ex = InfoCardTrace.ThrowHelperError((Exception)(object)new UntrustedRecipientException());
		}
		base.ProcessingException = null;
		return ex;
	}

	protected void StartAndWaitForUIAgent()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		switch (m_uiAgent.ShowUI(UIAgentMode))
		{
		case RequestResult.Untrusted:
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new UntrustedRecipientException());
		case RequestResult.Cancel:
		case RequestResult.Error:
			throw InfoCardTrace.ThrowHelperError((Exception)new UserCancelledException());
		case RequestResult.UIFailedInitialization:
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new UIAgentInitializationException());
		case RequestResult.UICrashed:
			throw InfoCardTrace.ThrowHelperError((Exception)new UIAgentCrashedException());
		case RequestResult.Ok:
			return;
		}
		InfoCardTrace.Assert(false, "We should never get Pending or invalid state here", new object[0]);
	}

	public void StartAccessibilityApplications(uint userATApplicationFlags)
	{
		if (m_uiAgent != null)
		{
			string trustedUserSid = m_uiAgent.TrustedUserSid;
			m_atManager.RestartOnInfoCardDesktop(userATApplicationFlags, m_uiAgent.TrustedUserToken, ref trustedUserSid, "WinSta0\\" + m_uiAgent.DesktopName, m_uiAgent.TsSessionId, base.CallerPid, RequestorIdentity);
		}
	}

	public bool RestartAccessibilityApplications()
	{
		m_atManager.Stop();
		return m_atManager.RestartOnUsersDesktop(base.CallerPid, "WinSta0\\Default", RequestorIdentity);
	}

	public void StopAccessibilityApplications()
	{
		m_atManager.Stop();
	}

	public void UserCancel(bool untrusted)
	{
		lock (base.SyncRoot)
		{
			CancelServiceAsyncOperation(untrusted);
			OnUserCancel();
		}
	}

	protected virtual void OnUserCancel()
	{
	}

	private void ReleaseUIAgent()
	{
		lock (base.SyncRoot)
		{
			CheckIfAllAsyncOpsCompleted();
			StopAccessibilityApplications();
			if (m_uiAgent != null)
			{
				m_uiAgent.ReleaseUI();
				m_uiAgent.ClearRequest(this);
				m_uiAgent = null;
			}
		}
	}

	protected override void OnDisposeAsUser()
	{
		base.OnDisposeAsUser();
		if (m_rootStoreReference != null)
		{
			m_rootStoreReference.Close();
			m_rootStoreReference = null;
		}
	}

	protected override void OnDisposeAsSystem()
	{
		if (m_uiAgentDone != null)
		{
			m_uiAgentDone.Close();
			m_uiAgentDone = null;
		}
		RemoveAndDisposeContextMapping(base.RpcHandle);
		ReleaseUIAgent();
		base.OnDisposeAsSystem();
	}
}
