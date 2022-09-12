using System;
using System.Diagnostics;

namespace MeMbmuKeumkr;

public sealed class lAXffrOVOOLCLHa
{
	public static bool ymwcMlkRImoaWte(Process process_0, string string_0)
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

	public static void SZnIwRSXptKD(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (ymwcMlkRImoaWte(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					QIACJnVixgJVTY.fwxjdYvdiTJaNWd();
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
