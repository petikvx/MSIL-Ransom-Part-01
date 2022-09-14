using System;
using System.Diagnostics;

namespace nVxbvhuaKzC;

public sealed class hOYNGBbrXGjNE
{
	public static bool plrjIUywczBK(Process process_0, string string_0)
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

	public static void NyIkWwGWEuzXFj(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (plrjIUywczBK(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					FcnBvlzKWyQDwH.VActiygTXQaRxCgZR();
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
