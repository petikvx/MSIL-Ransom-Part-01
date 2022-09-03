using System;
using System.Diagnostics;

namespace ns3;

internal sealed class Class14
{
	public static void smethod_0()
	{
		try
		{
			if (Debugger.IsAttached)
			{
				Environment.Exit(0);
				return;
			}
		}
		catch
		{
		}
		try
		{
			foreach (string module in Process.GetCurrentProcess().Modules)
			{
				if (module.Contains("sbiedll.dll"))
				{
					Environment.Exit(0);
					break;
				}
			}
		}
		catch
		{
		}
	}
}
