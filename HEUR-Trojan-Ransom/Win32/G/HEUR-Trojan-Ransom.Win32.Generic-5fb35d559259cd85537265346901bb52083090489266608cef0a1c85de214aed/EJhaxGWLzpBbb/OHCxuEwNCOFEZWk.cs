using System;
using System.Diagnostics;

namespace EJhaxGWLzpBbb;

public sealed class OHCxuEwNCOFEZWk
{
	public static bool KbKwIiSDYTiMLrV(Process process_0, string string_0)
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

	public static void pnajLTfmGpzzdyKw(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (KbKwIiSDYTiMLrV(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					hiKoLLubGHH.VoAMpxkTccTxi();
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
