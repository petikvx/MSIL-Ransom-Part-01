using System;
using System.Diagnostics;

namespace Complex;

public class ProcessKiller
{
	public static bool ProcessCompareProductName(Process p, string match)
	{
		try
		{
			return p.ProcessName.ToLower().Contains(match.ToLower());
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

	public static void ClosingCycle(string names, string dnames)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (ProcessCompareProductName(process, names.ToLower()))
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
