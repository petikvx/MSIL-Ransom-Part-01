using System.Diagnostics;

namespace youknowcaliber;

internal class ProcessList
{
	public static extern void WriteProcesses();

	public static extern string ProcessExecutablePath(Process process);

	public extern ProcessList();
}
