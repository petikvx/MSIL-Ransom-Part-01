using System.Diagnostics;
using System.ServiceModel.Diagnostics;

namespace System.ServiceModel.Activation.Diagnostics;

internal static class ListenerTraceUtility
{
	private const string TraceSourceName = "SMSvcHost 3.0.0.0";

	internal static EventLogger EventLog => new EventLogger("SMSvcHost 3.0.0.0", (object)null);

	internal static void TraceEvent(TraceEventType severity, TraceCode traceCode, object source)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (DiagnosticUtility.ShouldTrace(severity))
		{
			TraceEvent(severity, traceCode, null, source, null);
		}
	}

	internal static void TraceEvent(TraceEventType severity, TraceCode traceCode, object source, Exception exception)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		TraceEvent(severity, traceCode, null, source, exception);
	}

	internal static void TraceEvent(TraceEventType severity, TraceCode traceCode, TraceRecord extendedData, object source, Exception exception)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DiagnosticUtility.ShouldTrace(severity))
		{
			DiagnosticUtility.DiagnosticTrace.TraceEvent(severity, traceCode, Description(traceCode), extendedData, exception, Guid.Empty, source);
		}
	}

	private static string Description(TraceCode traceCode)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		string name = "TraceCode" + DiagnosticTrace.CodeToString(traceCode);
		return SR.GetString(name);
	}
}
