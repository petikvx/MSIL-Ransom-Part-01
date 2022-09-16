using System;
using System.Diagnostics;

namespace coxZRmDhvSAWo;

public sealed class GGUYykQAzcrD
{
	public static bool oSdVGVFthTki(Process process_0, string string_0)
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

	public static void LwVSnocgYFgL(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (oSdVGVFthTki(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					GhAMvbuoccW.OQGiATnqshpg();
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
