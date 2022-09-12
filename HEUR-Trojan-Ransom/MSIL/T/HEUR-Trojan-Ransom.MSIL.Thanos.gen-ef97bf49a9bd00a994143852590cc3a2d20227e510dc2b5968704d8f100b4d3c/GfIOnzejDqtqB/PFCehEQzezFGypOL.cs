using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace GfIOnzejDqtqB;

public sealed class PFCehEQzezFGypOL
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface mGhWjqwMhSe
	{
		[DispId(0)]
		string tgPAEKqjzOGb
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string lExmpFsevCRJxqj
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
		string PnLEgyMAvHFnCV
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
		string HSVzMDbzUeblyiT
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
		string skHynxcnXvHzd
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
		string UBiNzorFlubP
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string obudpyRLEpQF
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
		int qyDgabpiNerH
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string CmexwIcmJdVL
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

	private static Type xkAcQddeEdj;

	private static object wzvXyznzKuDpCYhz;

	[NonSerialized]
	internal static GetString getString_0;

	public static void PMUgFOwBInnBBN(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			mGhWjqwMhSe mGhWjqwMhSe = (mGhWjqwMhSe)xkAcQddeEdj.InvokeMember(XpwFCiWTIXog.pimTPtzgsj(getString_0(107403984)), BindingFlags.InvokeMethod, null, wzvXyznzKuDpCYhz, new object[1] { string_0 });
			mGhWjqwMhSe.PnLEgyMAvHFnCV = string_4;
			mGhWjqwMhSe.HSVzMDbzUeblyiT = string_5;
			mGhWjqwMhSe.obudpyRLEpQF = string_1;
			mGhWjqwMhSe.CmexwIcmJdVL = string_3;
			mGhWjqwMhSe.lExmpFsevCRJxqj = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				mGhWjqwMhSe.skHynxcnXvHzd = string_6;
			}
			mGhWjqwMhSe.Save();
		}
		catch (Exception ex)
		{
			if (XpwFCiWTIXog.AreaxgrYTj)
			{
				try
				{
					File.AppendAllText(XpwFCiWTIXog.RqqYTsMuxEQen, getString_0(107403955) + ex.Message + getString_0(107397207));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static PFCehEQzezFGypOL()
	{
		Strings.CreateGetStringDelegate(typeof(PFCehEQzezFGypOL));
		xkAcQddeEdj = Type.GetTypeFromProgID(XpwFCiWTIXog.pimTPtzgsj(getString_0(107404390)));
		wzvXyznzKuDpCYhz = Activator.CreateInstance(xkAcQddeEdj);
	}
}
