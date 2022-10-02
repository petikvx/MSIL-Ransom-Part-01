using System;
using System.Diagnostics;

namespace GlIxuPPoosXGy;

public sealed class qAMjHuoqDDwTU
{
	public static bool qHbTXyVXOjJN(Process process_0, string string_0)
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

	public static void PCuJwfHBpSD(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (qHbTXyVXOjJN(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					kdXBbWqHjtnYq.GYLxswafJgK();
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
