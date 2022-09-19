using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace VyjVuXvolaw;

public sealed class WulyYghiytqOT
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface IxCeEvJyJscMxFa
	{
		[DispId(0)]
		string qGsAVEMsSfy
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string QfGWrVIZHZatAFTO
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
		string IhOvXFIvqznq
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
		string SNHccQNeuqI
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
		string jRgWgxVQrjTg
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
		string jkMCFyfGpca
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string UVkImLpfkfHZaj
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
		int ZuHkKKgPoAB
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string VpkGQAtGnsXrF
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

	private static Type BuQRqJpMEDwxmd;

	private static object sAXpoZDItVlO;

	[NonSerialized]
	internal static GetString getString_0;

	public static void EVSjQtxoyp(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			IxCeEvJyJscMxFa ixCeEvJyJscMxFa = (IxCeEvJyJscMxFa)BuQRqJpMEDwxmd.InvokeMember(CcLtuTEQJD.RdzltCKTqMftoSE(getString_0(107401739)), BindingFlags.InvokeMethod, null, sAXpoZDItVlO, new object[1] { string_0 });
			ixCeEvJyJscMxFa.IhOvXFIvqznq = string_4;
			ixCeEvJyJscMxFa.SNHccQNeuqI = string_5;
			ixCeEvJyJscMxFa.UVkImLpfkfHZaj = string_1;
			ixCeEvJyJscMxFa.VpkGQAtGnsXrF = string_3;
			ixCeEvJyJscMxFa.QfGWrVIZHZatAFTO = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				ixCeEvJyJscMxFa.jRgWgxVQrjTg = string_6;
			}
			ixCeEvJyJscMxFa.Save();
		}
		catch (Exception ex)
		{
			if (CcLtuTEQJD.VLajbDNhoSbf)
			{
				try
				{
					File.AppendAllText(CcLtuTEQJD.MGkBzYPheHDPb, getString_0(107401710) + ex.Message + getString_0(107396319));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static WulyYghiytqOT()
	{
		Strings.CreateGetStringDelegate(typeof(WulyYghiytqOT));
		BuQRqJpMEDwxmd = Type.GetTypeFromProgID(CcLtuTEQJD.RdzltCKTqMftoSE(getString_0(107401665)));
		sAXpoZDItVlO = Activator.CreateInstance(BuQRqJpMEDwxmd);
	}
}
