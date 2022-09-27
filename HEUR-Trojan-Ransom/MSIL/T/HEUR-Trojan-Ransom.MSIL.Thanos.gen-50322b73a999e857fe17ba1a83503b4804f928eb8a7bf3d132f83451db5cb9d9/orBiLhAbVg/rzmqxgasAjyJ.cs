using System;
using System.Diagnostics;

namespace orBiLhAbVg;

public sealed class rzmqxgasAjyJ
{
	public static bool LnorAkezNwnNbe(Process process_0, string string_0)
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

	public static void iVDHYJQNEo(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (LnorAkezNwnNbe(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					MJmySpXyeIcv.bKoxifDwFSxQ();
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
