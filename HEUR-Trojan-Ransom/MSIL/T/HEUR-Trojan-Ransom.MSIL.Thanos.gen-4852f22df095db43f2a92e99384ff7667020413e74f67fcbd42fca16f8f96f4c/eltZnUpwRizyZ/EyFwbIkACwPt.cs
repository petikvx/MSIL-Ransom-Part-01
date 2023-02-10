using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace eltZnUpwRizyZ;

public sealed class EyFwbIkACwPt
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface xdRumhYBRmas
	{
		[DispId(0)]
		string VhAjxkRwoisoLIABc
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string VneiLfTSKnuV
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
		string GZGrCPFqSeI
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
		string MuVuUjHWJDs
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
		string tnxXRIrkGy
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
		string bsasXBJTpzqW
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string nmBucDkxrlBYOrj
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
		int hxHjQNcdQtr
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string bJcHICpnCSZL
		{
			[DispId(1007)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1007)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[TypeLibFunc(64)]
		[DispId(2000)]
		void Load([In][MarshalAs(UnmanagedType.BStr)] string PathLink);

		[DispId(2001)]
		void Save();
	}

	private static Type sNNXjarEPYJA;

	private static object IfrodUPvMcuPlyc;

	[NonSerialized]
	internal static GetString _008E;

	public static void AOLqVGzBOl(string P_0, string P_1, string P_2, string P_3, string P_4, string P_5, string P_6)
	{
		try
		{
			xdRumhYBRmas xdRumhYBRmas = (xdRumhYBRmas)sNNXjarEPYJA.InvokeMember(OPwDdsoVlNU.KsnoBrbTQSaN(_008E(107399691)), BindingFlags.InvokeMethod, null, IfrodUPvMcuPlyc, new object[1] { P_0 });
			xdRumhYBRmas.GZGrCPFqSeI = P_4;
			xdRumhYBRmas.MuVuUjHWJDs = P_5;
			xdRumhYBRmas.nmBucDkxrlBYOrj = P_1;
			xdRumhYBRmas.bJcHICpnCSZL = P_3;
			xdRumhYBRmas.VneiLfTSKnuV = P_2;
			if (!string.IsNullOrEmpty(P_6))
			{
				xdRumhYBRmas.tnxXRIrkGy = P_6;
			}
			xdRumhYBRmas.Save();
		}
		catch (Exception ex)
		{
			if (OPwDdsoVlNU.QCmKQKwvWBrFEj)
			{
				try
				{
					File.AppendAllText(OPwDdsoVlNU.hBPcxbXfrBbYZwL, _008E(107399662) + ex.Message + _008E(107396283));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static EyFwbIkACwPt()
	{
		Strings.CreateGetStringDelegate(typeof(EyFwbIkACwPt));
		sNNXjarEPYJA = Type.GetTypeFromProgID(OPwDdsoVlNU.KsnoBrbTQSaN(_008E(107399073)));
		IfrodUPvMcuPlyc = Activator.CreateInstance(sNNXjarEPYJA);
	}
}
