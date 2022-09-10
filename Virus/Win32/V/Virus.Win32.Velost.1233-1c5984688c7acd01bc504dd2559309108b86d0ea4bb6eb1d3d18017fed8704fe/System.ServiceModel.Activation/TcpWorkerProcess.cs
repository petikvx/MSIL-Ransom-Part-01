using System.Diagnostics;
using System.Net.Sockets;
using System.ServiceModel.Activation.Diagnostics;
using System.ServiceModel.Diagnostics;

namespace System.ServiceModel.Activation;

internal class TcpWorkerProcess : WorkerProcess
{
	protected override TransportType TransportType => TransportType.Tcp;

	protected override DuplicateContext DuplicateConnection(ListenerSessionConnection session)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		bool flag = false;
		SocketInformation socketInformation = default(SocketInformation);
		try
		{
			socketInformation = (SocketInformation)session.Connection.DuplicateAndClose(base.ProcessId);
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
				ListenerTraceUtility.TraceEvent(TraceEventType.Error, (TraceCode)589836, this, exception);
			}
		}
		if (flag)
		{
			if (DiagnosticUtility.ShouldTraceInformation)
			{
				ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)589835, this);
			}
			return (DuplicateContext)new TcpDuplicateContext(socketInformation, session.Via, session.Data);
		}
		return null;
	}

	protected override void OnDispatchSuccess()
	{
		ListenerPerfCounters.IncrementConnectionsDispatchedTcp();
	}
}
