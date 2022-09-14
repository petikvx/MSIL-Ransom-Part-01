using System;
using System.Diagnostics;

namespace wmzoZRdMaf;

public sealed class wjVArqLLEOu
{
	public static bool VZsWYBtrQsr(Process process_0, string string_0)
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

	public static void wyaBIkIPoqevW(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (VZsWYBtrQsr(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					IuKjJmfJcVBFA.XbTVyboAGqHQlSpf();
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
