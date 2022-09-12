using System;
using System.Diagnostics;

namespace edKqEixVoGgLte;

public sealed class uSAaYMvzKCPw
{
	public static bool cqPOXejYHvw(Process process_0, string string_0)
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

	public static void cstciNcAdq(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (cqPOXejYHvw(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					opmuuofbUtOT.HJRcTLWrdpFl();
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
