using System.Diagnostics;
using System.ServiceModel.Activation.Diagnostics;
using System.ServiceModel.Diagnostics;
using System.ServiceProcess;

namespace System.ServiceModel.Activation;

internal class TcpPortSharing : ServiceBase
{
	private class TcpPortSharingCore : SharingService
	{
		internal TcpPortSharingCore()
			: base(TransportType.Tcp, "NetTcpPortSharing", "NetTcpPortSharing/endpoint")
		{
		}
	}

	private TcpPortSharingCore serviceCore;

	internal bool IsPaused => serviceCore.IsPaused;

	internal TcpPortSharing()
	{
		serviceCore = new TcpPortSharingCore();
		((ServiceBase)this).set_ServiceName("NetTcpPortSharing");
		((ServiceBase)this).set_CanPauseAndContinue(true);
		((ServiceBase)this).set_CanHandlePowerEvent(false);
		((ServiceBase)this).set_AutoLog(false);
		((ServiceBase)this).set_CanStop(true);
		((ServiceBase)this).set_CanShutdown(true);
	}

	protected override void OnContinue()
	{
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)589841, this);
		}
		serviceCore.OnContinue();
	}

	protected override void OnPause()
	{
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)589842, this);
		}
		serviceCore.OnPause();
	}

	protected override void OnShutdown()
	{
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)589843, this);
		}
		((ServiceBase)this).RequestAdditionalTime(30000);
		serviceCore.OnShutdown();
		((ServiceBase)this).Stop();
	}

	protected override void OnStart(string[] args)
	{
		try
		{
			if (DiagnosticUtility.ShouldTraceInformation)
			{
				ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)589845, this);
			}
			ListenerConfig.EnsureInitializedForNetTcp();
			Start();
		}
		catch (Exception ex)
		{
			ListenerTraceUtility.EventLog.LogEvent(TraceEventType.Error, (EventLogCategory)13, (EventLogEventId)(-1073479673), false, new string[1] { ex.ToString() });
			throw;
		}
	}

	private void Start()
	{
		serviceCore.Start();
	}

	protected override void OnStop()
	{
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)589847, this);
		}
		((ServiceBase)this).RequestAdditionalTime(30000);
		serviceCore.OnStop();
	}
}
