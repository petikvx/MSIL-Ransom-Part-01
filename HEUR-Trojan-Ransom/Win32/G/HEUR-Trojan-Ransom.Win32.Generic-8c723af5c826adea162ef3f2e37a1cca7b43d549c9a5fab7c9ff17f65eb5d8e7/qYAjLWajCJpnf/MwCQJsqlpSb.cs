using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace qYAjLWajCJpnf;

public sealed class MwCQJsqlpSb
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface ndgPtfABwZGkb
	{
		[DispId(0)]
		string SYTRmiQGBuWv
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string EORMeIByrMiU
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
		string frlUvFdJKnR
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
		string qbvBpjVocRqbv
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
		string hoTyMjBycUfG
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
		string qYrtsFnwLG
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string UCeJyxVFzfCJRpt
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
		int MfnVDMeVohdZX
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string pSptupJCBUNc
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

	private static Type ZTZwFYduzLvy;

	private static object xHoRwqoDuoB;

	[NonSerialized]
	internal static GetString getString_0;

	public static void eSBhuUbZpjFkh(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			ndgPtfABwZGkb ndgPtfABwZGkb = (ndgPtfABwZGkb)ZTZwFYduzLvy.InvokeMember(bTJSgdVkQM.gvCYkntYkqMW(getString_0(107457016)), BindingFlags.InvokeMethod, null, xHoRwqoDuoB, new object[1] { string_0 });
			ndgPtfABwZGkb.frlUvFdJKnR = string_4;
			ndgPtfABwZGkb.qbvBpjVocRqbv = string_5;
			ndgPtfABwZGkb.UCeJyxVFzfCJRpt = string_1;
			ndgPtfABwZGkb.pSptupJCBUNc = string_3;
			ndgPtfABwZGkb.EORMeIByrMiU = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				ndgPtfABwZGkb.hoTyMjBycUfG = string_6;
			}
			ndgPtfABwZGkb.Save();
		}
		catch (Exception ex)
		{
			if (bTJSgdVkQM.JJYUPCZGaGN)
			{
				try
				{
					File.AppendAllText(bTJSgdVkQM.vzSBJQFXpb, getString_0(107456987) + ex.Message + getString_0(107397225));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static MwCQJsqlpSb()
	{
		Strings.CreateGetStringDelegate(typeof(MwCQJsqlpSb));
		ZTZwFYduzLvy = Type.GetTypeFromProgID(bTJSgdVkQM.gvCYkntYkqMW(getString_0(107456974)));
		xHoRwqoDuoB = Activator.CreateInstance(ZTZwFYduzLvy);
	}
}
