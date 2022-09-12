using System;
using System.Diagnostics;

namespace gtzdezosLTmcL;

public sealed class FArxFqLOilG
{
	public static bool qJXSceAnvkA(Process process_0, string string_0)
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

	public static void sDLaZHGIZoLJz(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (qJXSceAnvkA(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					pjsEsrnLXK.bsfgkoVlRSAhDiSE();
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
