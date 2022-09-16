using System;
using System.Diagnostics;
using System.IO;
using System.Management;

namespace ns5;

internal sealed class Class21
{
	public static void smethod_0(string string_0)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			File.AppendAllText(string_0 + "\\Process.txt", "NAME: " + process.ProcessName + "\n\tPID: " + process.Id + "\n\tEXE: " + smethod_1(process) + "\n\n");
		}
	}

	public static string smethod_1(Process process_0)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			return process_0.MainModule!.FileName;
		}
		catch
		{
			ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("SELECT ExecutablePath, ProcessID FROM Win32_Process").Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val = (ManagementObject)enumerator.get_Current();
					object obj = ((ManagementBaseObject)val).get_Item("ProcessID");
					object obj2 = ((ManagementBaseObject)val).get_Item("ExecutablePath");
					if (obj2 != null && obj.ToString() == process_0.Id.ToString())
					{
						return obj2.ToString();
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		return "";
	}
}
