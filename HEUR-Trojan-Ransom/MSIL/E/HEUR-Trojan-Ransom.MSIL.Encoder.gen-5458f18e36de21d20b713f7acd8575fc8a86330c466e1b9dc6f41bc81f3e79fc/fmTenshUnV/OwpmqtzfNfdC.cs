using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fmTenshUnV;

public sealed class OwpmqtzfNfdC
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface TwWEXIuNtCgZm
	{
		[DispId(0)]
		string AsOmELqkMko
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string UQOIugpxLP
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
		string cmSXwPFwAtKif
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
		string TmmKdhOOsFeY
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
		string TunUCCZlzyXo
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
		string CQExKwWflvRxmY
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string lNrIKyajsMSPv
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
		int SfYRDDsExdj
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string gYwnQqwmYRgzs
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

	private static Type siAPtaIuQzViK;

	private static object QqLexyOvdc;

	[NonSerialized]
	internal static GetString getString_0;

	public static void sMoFygPjEEKrBpl(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			TwWEXIuNtCgZm twWEXIuNtCgZm = (TwWEXIuNtCgZm)siAPtaIuQzViK.InvokeMember(tnMCcqyYFYOXqEk.BaxqkGxiBeqS(getString_0(107402915)), BindingFlags.InvokeMethod, null, QqLexyOvdc, new object[1] { string_0 });
			twWEXIuNtCgZm.cmSXwPFwAtKif = string_4;
			twWEXIuNtCgZm.TmmKdhOOsFeY = string_5;
			twWEXIuNtCgZm.lNrIKyajsMSPv = string_1;
			twWEXIuNtCgZm.gYwnQqwmYRgzs = string_3;
			twWEXIuNtCgZm.UQOIugpxLP = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				twWEXIuNtCgZm.TunUCCZlzyXo = string_6;
			}
			twWEXIuNtCgZm.Save();
		}
		catch (Exception ex)
		{
			if (tnMCcqyYFYOXqEk.XKASwlGUBpzh)
			{
				try
				{
					File.AppendAllText(tnMCcqyYFYOXqEk.UQSYzQClpMD, getString_0(107402918) + ex.Message + getString_0(107396659));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static OwpmqtzfNfdC()
	{
		Strings.CreateGetStringDelegate(typeof(OwpmqtzfNfdC));
		siAPtaIuQzViK = Type.GetTypeFromProgID(tnMCcqyYFYOXqEk.BaxqkGxiBeqS(getString_0(107402841)));
		QqLexyOvdc = Activator.CreateInstance(siAPtaIuQzViK);
	}
}
