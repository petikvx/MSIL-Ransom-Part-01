using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bpbWYHKNCNX;

public sealed class tIVEwcxusvH
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface nmoxjVqbRpr
	{
		[DispId(0)]
		string WaFaPpDLPdcDS
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string isDynGwXxEV
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
		string TdxVmFOklgQh
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
		string WkoJUGlmfWnu
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
		string aOqKmxCOBKVVZ
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
		string FAiTVnVmKCNka
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string BVGyrRkzGcYu
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
		int BUUyFDgLZtLwiezm
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string aLpTxOAGyq
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

	private static Type KXJBafodFCH;

	private static object UPvxlanjMAjKDe;

	[NonSerialized]
	internal static GetString getString_0;

	public static void XpoVENafSyp(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			nmoxjVqbRpr nmoxjVqbRpr = (nmoxjVqbRpr)KXJBafodFCH.InvokeMember(xWcMxnuhDQYJl.QqgSuZNWThrmn(getString_0(107404086)), BindingFlags.InvokeMethod, null, UPvxlanjMAjKDe, new object[1] { string_0 });
			nmoxjVqbRpr.TdxVmFOklgQh = string_4;
			nmoxjVqbRpr.WkoJUGlmfWnu = string_5;
			nmoxjVqbRpr.BVGyrRkzGcYu = string_1;
			nmoxjVqbRpr.aLpTxOAGyq = string_3;
			nmoxjVqbRpr.isDynGwXxEV = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				nmoxjVqbRpr.aOqKmxCOBKVVZ = string_6;
			}
			nmoxjVqbRpr.Save();
		}
		catch (Exception ex)
		{
			if (xWcMxnuhDQYJl.fvDSfFEVAaG)
			{
				try
				{
					File.AppendAllText(xWcMxnuhDQYJl.qiQAhhXEbdwvY, getString_0(107404057) + ex.Message + getString_0(107396437));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static tIVEwcxusvH()
	{
		Strings.CreateGetStringDelegate(typeof(tIVEwcxusvH));
		KXJBafodFCH = Type.GetTypeFromProgID(xWcMxnuhDQYJl.QqgSuZNWThrmn(getString_0(107404492)));
		UPvxlanjMAjKDe = Activator.CreateInstance(KXJBafodFCH);
	}
}
