using System.Diagnostics;

namespace Renci.SshNet.Abstractions;

internal static class DiagnosticAbstraction
{
	private static readonly SourceSwitch SourceSwitch = new SourceSwitch("SshNetSwitch");

	private static readonly TraceSource Loggging = new TraceSource("SshNet.Logging");

	public static bool IsEnabled(TraceEventType traceEventType)
	{
		return SourceSwitch.ShouldTrace(traceEventType);
	}

	[Conditional("DEBUG")]
	public static void Log(string text)
	{
	}
}
