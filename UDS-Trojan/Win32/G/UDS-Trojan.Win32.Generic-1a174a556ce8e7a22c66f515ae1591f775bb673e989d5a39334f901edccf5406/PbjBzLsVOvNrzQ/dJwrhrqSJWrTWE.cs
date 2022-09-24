using System;
using System.Diagnostics;

namespace PbjBzLsVOvNrzQ;

public class dJwrhrqSJWrTWE
{
	public static bool nmUEhivyOmL(Process yWuHMiZjNiSmDPo, string ucmsEPNlOwRm)
	{
		try
		{
			return yWuHMiZjNiSmDPo.ProcessName.ToLower().Contains(ucmsEPNlOwRm.ToLower());
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

	public static void xTsjyzpgDq(string WxqieNOaHRagDEHy, string mElvvTdStgP)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (nmUEhivyOmL(process, WxqieNOaHRagDEHy.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					oIxRFVSIpmRuMqIJ.ONKwLvQmArXFz();
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
