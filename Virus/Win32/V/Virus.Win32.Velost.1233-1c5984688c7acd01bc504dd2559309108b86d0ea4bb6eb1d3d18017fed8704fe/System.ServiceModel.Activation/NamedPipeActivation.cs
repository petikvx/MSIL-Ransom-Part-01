using System.Diagnostics;
using System.ServiceModel.Activation.Diagnostics;
using System.ServiceModel.Diagnostics;
using System.ServiceProcess;

namespace System.ServiceModel.Activation;

internal class NamedPipeActivation : ActivationService
{
	private class NamedPipeSharing : SharingService
	{
		internal NamedPipeSharing()
			: base(TransportType.NamedPipe, "NetPipeActivator", "NetPipeActivator/endpoint")
		{
		}
	}

	private NamedPipeSharing serviceCore;

	internal NamedPipeActivation()
		: base("NetPipeActivator", Uri.UriSchemeNetPipe)
	{
		serviceCore = new NamedPipeSharing();
	}

	protected override void OnContinue()
	{
		base.OnContinue();
		serviceCore.OnContinue();
	}

	protected override void OnPause()
	{
		base.OnPause();
		serviceCore.OnPause();
	}

	protected override void OnShutdown()
	{
		base.OnShutdown();
		((ServiceBase)this).RequestAdditionalTime(30000);
		serviceCore.OnShutdown();
	}

	protected override void OnStart(string[] args)
	{
		try
		{
			ListenerConfig.EnsureInitializedForNetPipe();
			base.OnStart(args);
			serviceCore.Start();
		}
		catch (Exception ex)
		{
			ListenerTraceUtility.EventLog.LogEvent(TraceEventType.Error, (EventLogCategory)14, (EventLogEventId)(-1073479673), false, new string[1] { ex.ToString() });
			throw;
		}
	}

	protected override void OnStop()
	{
		base.OnStop();
		((ServiceBase)this).RequestAdditionalTime(30000);
		serviceCore.OnStop();
	}
}
