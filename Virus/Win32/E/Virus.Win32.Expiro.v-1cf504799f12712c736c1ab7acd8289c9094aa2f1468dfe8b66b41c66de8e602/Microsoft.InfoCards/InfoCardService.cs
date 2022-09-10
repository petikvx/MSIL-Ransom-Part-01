using System;
using System.ComponentModel;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.ServiceProcess;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class InfoCardService : ServiceBase
{
	public const int WindowsVistaMajorVersion = 6;

	public const string FullServiceName = "idsvc";

	private RpcCallbacks m_rpcCallbacks;

	public static LifeTimeMonitor LifeTimeMonitor;

	public static event EventHandler Stopping;

	public InfoCardService()
	{
		bool flag = 0 != NativeMethods.GetSystemMetrics(86);
		bool flag2 = Environment.OSVersion.Version.Major < 6;
		if (NativeMcppMethods.AdjustPrivilegesWrapper(flag && flag2) != 0)
		{
			Crash(new Win32Exception());
		}
		try
		{
			NativeMcppMethods.AdjustServiceProcessSecurity();
		}
		catch (Win32Exception e)
		{
			Crash(e);
		}
		((ServiceBase)this).set_ServiceName("idsvc");
		((ServiceBase)this).set_CanStop(true);
		((ServiceBase)this).set_CanShutdown(true);
		((ServiceBase)this).set_CanPauseAndContinue(false);
		((ServiceBase)this).set_CanHandleSessionChangeEvent(true);
		((ServiceBase)this).set_CanHandlePowerEvent(false);
		((ServiceBase)this).set_AutoLog(true);
		m_rpcCallbacks.uiAgentRequestAuthorize = UIAgentRequest.Authorize;
		m_rpcCallbacks.uiAgentRequestBindToService = UIAgentRequest.BindToService;
		m_rpcCallbacks.clientRequestAuthorize = ClientRequest.Authorize;
		m_rpcCallbacks.clientRequestBindToService = ClientUIRequest.BindToService;
		m_rpcCallbacks.requestFactoryProcessNewRequest = RequestFactory.ProcessNewRequest;
		m_rpcCallbacks.allocMem = Marshal.AllocHGlobal;
		m_rpcCallbacks.freeMem = Marshal.FreeHGlobal;
		m_rpcCallbacks.rundownClientContext = ClientUIRequest.RemoveAndDisposeContextMapping;
		LifeTimeMonitor = new LifeTimeMonitor();
		ServicePointManager.ServerCertificateValidationCallback = InfoCardX509Validator.ValidateChainOrPeerCallback;
	}

	protected override void Dispose(bool disposing)
	{
		((ServiceBase)this).Dispose(disposing);
	}

	protected override void OnStart(string[] args)
	{
		((ServiceBase)this).OnStart(args);
		AppDomain currentDomain = AppDomain.CurrentDomain;
		currentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
		HGlobalSafeHandle val = HGlobalSafeHandle.Construct(Marshal.SizeOf((object)m_rpcCallbacks));
		try
		{
			Marshal.StructureToPtr((object)m_rpcCallbacks, ((SafeHandle)(object)val).DangerousGetHandle(), fDeleteOld: false);
			uint num = NativeMcppMethods.InfoCardStartRpcServerWrapper(InfoCardUIAgent.UiAgentFullPath, ((SafeHandle)(object)val).DangerousGetHandle());
			if (num != 0)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new Win32Exception((int)num));
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	protected override void OnStop()
	{
		try
		{
			InfoCardUIAgent.DoShutdown();
			NativeMcppMethods.InfoCardStopRpcServerWrapper();
			OnStopping();
		}
		catch (Exception ex)
		{
			InfoCardTrace.TraceAndLogException(ex);
		}
		finally
		{
			((ServiceBase)this).OnStop();
		}
	}

	protected virtual void OnStopping()
	{
		if (InfoCardService.Stopping != null)
		{
			InfoCardService.Stopping(this, new EventArgs());
		}
	}

	protected override void OnSessionChange(SessionChangeDescription changeDescription)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between I4 and Unknown
		if (6 == (int)((SessionChangeDescription)(ref changeDescription)).get_Reason())
		{
			InfoCardUIAgent.OnLogout((uint)((SessionChangeDescription)(ref changeDescription)).get_SessionId());
		}
	}

	public static void Crash()
	{
		Crash(null);
	}

	public static void Crash(Exception e)
	{
		InfoCardTrace.FailFast(e.Message);
	}
}
