using System.Diagnostics;
using System.ServiceModel.Activation.Diagnostics;
using System.ServiceModel.Diagnostics;

namespace System.ServiceModel.Activation;

internal class NamedPipeWorkerProcess : WorkerProcess
{
	protected override TransportType TransportType => TransportType.NamedPipe;

	protected override DuplicateContext DuplicateConnection(ListenerSessionConnection session)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		bool flag = false;
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = (IntPtr)session.Connection.DuplicateAndClose(base.ProcessId);
			flag = true;
		}
		catch (Exception exception)
		{
			if (DiagnosticUtility.IsFatal(exception))
			{
				throw;
			}
			if (DiagnosticUtility.ShouldTraceError)
			{
				ListenerTraceUtility.TraceEvent(TraceEventType.Error, (TraceCode)589833, this, exception);
			}
		}
		if (flag)
		{
			if (DiagnosticUtility.ShouldTraceInformation)
			{
				ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)589833, this);
			}
			return (DuplicateContext)new NamedPipeDuplicateContext(intPtr, session.Via, session.Data);
		}
		return null;
	}

	protected override void OnDispatchSuccess()
	{
		ListenerPerfCounters.IncrementConnectionsDispatchedNamedPipe();
	}
}
