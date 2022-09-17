using System;
using System.Diagnostics;

namespace bmDbQpaZORfnY;

public sealed class ZYXutTkrEZIRKQgz
{
	public static bool RDAIAbWAkXRz(Process process_0, string string_0)
	{
		try
		{
			return process_0.ProcessName.ToLower().Contains(string_0.ToLower());
		}
		catch (InvalidOperationException)
		{
			return false;
		}
		catch (NullReferenceException)
		{
			return false;
		}
		catch
		{
			return false;
		}
	}

	public static void jHTJNAfmHTV(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (RDAIAbWAkXRz(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					qMBmfvOoVnw.STbtyipgaiFwyyV();
				}
				catch (InvalidOperationException)
				{
				}
				catch (PlatformNotSupportedException)
				{
					break;
				}
				catch
				{
				}
			}
		}
	}
}
