using System.Diagnostics;
using System.ServiceModel.Activation.Diagnostics;
using System.ServiceModel.Diagnostics;
using System.ServiceProcess;

namespace System.ServiceModel.Activation;

internal abstract class ActivationService : ServiceBase, IActivationService
{
	private ListenerAdapter listenerAdapter;

	private string protocolName;

	private bool isPaused;

	public bool IsPaused => isPaused;

	public string ActivationServiceName => ((ServiceBase)this).get_ServiceName();

	public string ProtocolName => protocolName;

	protected ActivationService(string serviceName, string protocolName)
	{
		this.protocolName = protocolName;
		((ServiceBase)this).set_ServiceName(serviceName);
		((ServiceBase)this).set_CanHandlePowerEvent(false);
		((ServiceBase)this).set_AutoLog(false);
		((ServiceBase)this).set_CanStop(true);
		((ServiceBase)this).set_CanPauseAndContinue(true);
		((ServiceBase)this).set_CanShutdown(true);
	}

	public IActivatedMessageQueue CreateQueue(ListenerAdapter la, App app)
	{
		return new ActivatedMessageQueue(la, app);
	}

	public IActivatedMessageQueue FindQueue(int queueId)
	{
		return ActivatedMessageQueue.Find(queueId);
	}

	protected override void OnContinue()
	{
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)589841, this);
		}
		isPaused = false;
	}

	protected override void OnPause()
	{
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)589842, this);
		}
		isPaused = true;
	}

	protected override void OnShutdown()
	{
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)589843, this);
		}
		Shutdown();
		((ServiceBase)this).Stop();
	}

	protected override void OnStop()
	{
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)589847, this);
		}
		Shutdown();
	}

	protected override void OnStart(string[] args)
	{
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)589845, this);
		}
		Start();
	}

	private void Start()
	{
		if (!SMSvcHost.IsWebhostSupported)
		{
			((ServiceBase)this).set_ExitCode(50);
			throw DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new NotSupportedException(SR.GetString("ServiceRequiresWas")));
		}
		isPaused = false;
		listenerAdapter = new ListenerAdapter(this);
		listenerAdapter.Open();
	}

	private void Shutdown()
	{
		listenerAdapter.Close();
	}

	public void StopService()
	{
		((ServiceBase)this).Stop();
	}
}
