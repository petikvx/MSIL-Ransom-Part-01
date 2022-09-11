using System;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace HuHbCLeSgdQqCa;

public sealed class ErOmnLggUFCj
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface mthjBXDMWwy
	{
		[DispId(0)]
		string qAQigZaRyqTlQ
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string HRDtmWbFTh
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
		string HKTyEDMOrwz
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
		string TEKGajEFzyCHi
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
		string QfnImFhQdlMqi
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
		string bDhmWagbtApfJNa
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string GTnNEmRJdewbep
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
		int GrkIPWoMcW
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string DiRFoRNMGYzRHh
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

	private static Type HVWAHjPGxYvu;

	private static object YYdxmFPaBstv;

	[NonSerialized]
	internal static GetString getString_0;

	public static void EJIxdtvlPdIz(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		mthjBXDMWwy mthjBXDMWwy = (mthjBXDMWwy)HVWAHjPGxYvu.InvokeMember(sjdJQieILoWa.HaBpHuAelnemsPrlU(getString_0(107410252)), BindingFlags.InvokeMethod, null, YYdxmFPaBstv, new object[1] { string_0 });
		mthjBXDMWwy.HKTyEDMOrwz = string_4;
		mthjBXDMWwy.TEKGajEFzyCHi = string_5;
		mthjBXDMWwy.GTnNEmRJdewbep = string_1;
		mthjBXDMWwy.DiRFoRNMGYzRHh = string_3;
		mthjBXDMWwy.HRDtmWbFTh = string_2;
		if (!string.IsNullOrEmpty(string_6))
		{
			mthjBXDMWwy.QfnImFhQdlMqi = string_6;
		}
		mthjBXDMWwy.Save();
	}

	static ErOmnLggUFCj()
	{
		Strings.CreateGetStringDelegate(typeof(ErOmnLggUFCj));
		HVWAHjPGxYvu = Type.GetTypeFromProgID(sjdJQieILoWa.HaBpHuAelnemsPrlU(getString_0(107410223)));
		YYdxmFPaBstv = Activator.CreateInstance(HVWAHjPGxYvu);
	}
}
