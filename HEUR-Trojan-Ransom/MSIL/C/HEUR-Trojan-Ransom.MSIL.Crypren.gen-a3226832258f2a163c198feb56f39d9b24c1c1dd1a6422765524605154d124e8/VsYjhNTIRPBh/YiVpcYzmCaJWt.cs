using System;
using System.Diagnostics;

namespace VsYjhNTIRPBh;

public class YiVpcYzmCaJWt
{
	public static bool yHczAsFtSQqJe(Process SjLnoKPzJMccvzp, string GGgFDgdqLi)
	{
		try
		{
			return SjLnoKPzJMccvzp.ProcessName.ToLower().Contains(GGgFDgdqLi.ToLower());
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

	public static void rMCtjXHwlx(string dupvQeQlIZrvqJC, string DMOaTWXAkuAx)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (yHczAsFtSQqJe(process, dupvQeQlIZrvqJC.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					BdNzYJbFQkt.cXQuwfSPMZ();
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
