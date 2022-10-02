using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace EJhaxGWLzpBbb;

public sealed class BgCwqaoXDaMc
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface VYZGcHsxuTLz
	{
		[DispId(0)]
		string JvhdZBKOaE
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string KesvJmCVeRC
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
		string tsagRuaykQ
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
		string nCDiMhoDmuRGtvu
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
		string xxdytoNgvtEWEi
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
		string jNYUkAGclBSY
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string HEtobVJVdKbl
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
		int apgTzXMdQfsb
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string nFVORunnfE
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

	private static Type sVvUppSkGlVVciY;

	private static object IjQfufEqWC;

	[NonSerialized]
	internal static GetString getString_0;

	public static void tIOTIRlpToL(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			VYZGcHsxuTLz vYZGcHsxuTLz = (VYZGcHsxuTLz)sVvUppSkGlVVciY.InvokeMember(hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107196621)), BindingFlags.InvokeMethod, null, IjQfufEqWC, new object[1] { string_0 });
			vYZGcHsxuTLz.tsagRuaykQ = string_4;
			vYZGcHsxuTLz.nCDiMhoDmuRGtvu = string_5;
			vYZGcHsxuTLz.HEtobVJVdKbl = string_1;
			vYZGcHsxuTLz.nFVORunnfE = string_3;
			vYZGcHsxuTLz.KesvJmCVeRC = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				vYZGcHsxuTLz.xxdytoNgvtEWEi = string_6;
			}
			vYZGcHsxuTLz.Save();
		}
		catch (Exception ex)
		{
			if (hiKoLLubGHH.WUCUbinjeq)
			{
				try
				{
					File.AppendAllText(hiKoLLubGHH.YPtXSOBdFjEyjx, getString_0(107196592) + ex.Message + getString_0(107396376));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static BgCwqaoXDaMc()
	{
		Strings.CreateGetStringDelegate(typeof(BgCwqaoXDaMc));
		sVvUppSkGlVVciY = Type.GetTypeFromProgID(hiKoLLubGHH.ZszvXPTYjBtgjF(getString_0(107196579)));
		IjQfufEqWC = Activator.CreateInstance(sVvUppSkGlVVciY);
	}
}
