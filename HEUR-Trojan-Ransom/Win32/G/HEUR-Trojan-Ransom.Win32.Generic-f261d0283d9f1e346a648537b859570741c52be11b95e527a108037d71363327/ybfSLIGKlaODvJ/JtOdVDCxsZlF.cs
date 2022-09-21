using System;
using System.Diagnostics;

namespace ybfSLIGKlaODvJ;

public sealed class JtOdVDCxsZlF
{
	public static bool trAAvuEXaKOKNXd(Process process_0, string string_0)
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

	public static void iEVfozIhMOxKMXw(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (trAAvuEXaKOKNXd(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					iWNOuKBWgwsf.kgxecZsMbpHn();
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
