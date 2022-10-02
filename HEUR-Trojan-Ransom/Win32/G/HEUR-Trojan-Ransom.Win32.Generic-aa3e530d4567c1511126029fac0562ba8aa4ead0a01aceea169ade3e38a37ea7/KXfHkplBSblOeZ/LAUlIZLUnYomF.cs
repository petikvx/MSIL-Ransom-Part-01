using System;
using System.Diagnostics;

namespace KXfHkplBSblOeZ;

public sealed class LAUlIZLUnYomF
{
	public static bool YSLCzWCOsgp(Process process_0, string string_0)
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

	public static void dxokiCJNigaDJjve(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (YSLCzWCOsgp(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					NiISdmMYRfnXGiX.bTiDiDmJuclvC();
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
