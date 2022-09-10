using System.Diagnostics;
using System.ServiceModel.Activation.Diagnostics;
using System.ServiceModel.Diagnostics;

namespace System.ServiceModel.Activation;

internal class TcpActivation : ActivationService
{
	internal TcpActivation()
		: base("NetTcpActivator", Uri.UriSchemeNetTcp)
	{
	}

	protected override void OnStart(string[] args)
	{
		try
		{
			base.OnStart(args);
		}
		catch (Exception ex)
		{
			ListenerTraceUtility.EventLog.LogEvent(TraceEventType.Error, (EventLogCategory)14, (EventLogEventId)(-1073479673), false, new string[1] { ex.ToString() });
			throw;
		}
	}
}
