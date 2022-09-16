using System;
using System.Diagnostics;

namespace DFgOqDzZpZe;

public sealed class vFXuZKAtVfmKx
{
	public static bool lnEjXPNaKRzG(Process process_0, string string_0)
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

	public static void eXyhdsyyugc(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (lnEjXPNaKRzG(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					thNrRmMEuvdxhHm.yExfGaYYDORBn();
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
