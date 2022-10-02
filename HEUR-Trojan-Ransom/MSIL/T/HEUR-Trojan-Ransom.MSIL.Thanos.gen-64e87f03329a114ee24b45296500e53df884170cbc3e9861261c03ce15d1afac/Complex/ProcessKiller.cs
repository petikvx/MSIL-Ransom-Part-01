using System;
using System.Diagnostics;

namespace Complex;

public sealed class ProcessKiller
{
	public static bool ProcessCompareProductName(Process process_0, string string_0)
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

	public static void ClosingCycle(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (ProcessCompareProductName(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					Program.CleanMyStuff();
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
