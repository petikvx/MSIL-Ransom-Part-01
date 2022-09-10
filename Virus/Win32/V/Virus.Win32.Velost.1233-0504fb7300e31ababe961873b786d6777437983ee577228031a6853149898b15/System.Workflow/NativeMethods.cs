using System.Runtime.InteropServices;

namespace System.Workflow;

internal static class NativeMethods
{
	internal const int ERROR_SUCCESS = 0;

	internal const int ERROR_FILE_NOT_FOUND = 2;

	[DllImport("loadperf.dll", BestFitMapping = false, CharSet = CharSet.Auto)]
	internal static extern int UnloadPerfCounterTextStrings(string commandLine, bool quietMode);

	[DllImport("loadperf.dll", BestFitMapping = false, CharSet = CharSet.Auto)]
	internal static extern int LoadPerfCounterTextStrings(string commandLine, bool quietMode);
}
