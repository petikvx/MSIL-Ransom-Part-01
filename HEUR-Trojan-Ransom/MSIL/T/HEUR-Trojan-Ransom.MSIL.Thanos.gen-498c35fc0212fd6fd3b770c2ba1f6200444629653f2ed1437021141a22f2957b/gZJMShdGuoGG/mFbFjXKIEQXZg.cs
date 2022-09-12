using System;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gZJMShdGuoGG;

public sealed class mFbFjXKIEQXZg
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface BbCWQmgtpEk
	{
		[DispId(0)]
		string SQtpSCSLKeYr
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string MlNdedsJiVcfhVTG
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
		string OHqYqjaVLmgnG
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
		string sSONVMPuKB
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
		string qSgiUesBzqrskJ
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
		string IKDveynSpVugLq
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string CPCFqphgcOV
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
		int XeftaiCKlSNIi
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string blCuqHkmipnwE
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

	private static Type YEWqCVcGApH;

	private static object GdoaRzRdNgDf;

	[NonSerialized]
	internal static GetString getString_0;

	public static void wMpQMbBMPkm(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		BbCWQmgtpEk bbCWQmgtpEk = (BbCWQmgtpEk)YEWqCVcGApH.InvokeMember(pMhSnWjBfMXV.XpzNMVUBwHhS(getString_0(107405977)), BindingFlags.InvokeMethod, null, GdoaRzRdNgDf, new object[1] { string_0 });
		bbCWQmgtpEk.OHqYqjaVLmgnG = string_4;
		bbCWQmgtpEk.sSONVMPuKB = string_5;
		bbCWQmgtpEk.CPCFqphgcOV = string_1;
		bbCWQmgtpEk.blCuqHkmipnwE = string_3;
		bbCWQmgtpEk.MlNdedsJiVcfhVTG = string_2;
		if (!string.IsNullOrEmpty(string_6))
		{
			bbCWQmgtpEk.qSgiUesBzqrskJ = string_6;
		}
		bbCWQmgtpEk.Save();
	}

	static mFbFjXKIEQXZg()
	{
		Strings.CreateGetStringDelegate(typeof(mFbFjXKIEQXZg));
		YEWqCVcGApH = Type.GetTypeFromProgID(pMhSnWjBfMXV.XpzNMVUBwHhS(getString_0(107405916)));
		GdoaRzRdNgDf = Activator.CreateInstance(YEWqCVcGApH);
	}
}
