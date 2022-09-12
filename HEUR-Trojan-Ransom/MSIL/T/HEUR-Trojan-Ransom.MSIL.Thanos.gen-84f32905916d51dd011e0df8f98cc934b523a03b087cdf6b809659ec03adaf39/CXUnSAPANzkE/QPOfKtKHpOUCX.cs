using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace CXUnSAPANzkE;

public sealed class QPOfKtKHpOUCX
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface kpinoXcZhil
	{
		[DispId(0)]
		string RebVPKSpKOTFq
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string wuzOhVvfOPI
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
		string HvygZcqnhbvT
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
		string jtjuFWYnsi
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
		string faxpSaLQThCdmQL
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
		string bOpHXHcDFKQSqfA
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string ktqShUzpYVw
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
		int jmeUsSETRULcxNXK
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string CueBIyPQwAmv
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

	public static void xQjbIHzfsFqUJM(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			kpinoXcZhil kpinoXcZhil = (kpinoXcZhil)jTVdmInbLVXjsrr.InvokeMember(yIZYKSYRaZXoZvGddM.dAXyboFAql(getString_0(107401718)), BindingFlags.InvokeMethod, null, BskQAyxusXgW, new object[1] { string_0 });
			kpinoXcZhil.HvygZcqnhbvT = string_4;
			kpinoXcZhil.jtjuFWYnsi = string_5;
			kpinoXcZhil.ktqShUzpYVw = string_1;
			kpinoXcZhil.CueBIyPQwAmv = string_3;
			kpinoXcZhil.wuzOhVvfOPI = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				kpinoXcZhil.faxpSaLQThCdmQL = string_6;
			}
			kpinoXcZhil.Save();
		}
		catch (Exception ex)
		{
			if (yIZYKSYRaZXoZvGddM.geeOWbkDyamU)
			{
				try
				{
					File.AppendAllText(yIZYKSYRaZXoZvGddM.UvHPjcAlchtwE, getString_0(107401177) + ex.Message + getString_0(107396784));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static QPOfKtKHpOUCX()
	{
		Strings.CreateGetStringDelegate(typeof(QPOfKtKHpOUCX));
		jTVdmInbLVXjsrr = Type.GetTypeFromProgID(yIZYKSYRaZXoZvGddM.dAXyboFAql(getString_0(107401100)));
		BskQAyxusXgW = Activator.CreateInstance(jTVdmInbLVXjsrr);
	}
}
