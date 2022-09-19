using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace VyjVuXvolaw;

public sealed class SkkhlYhQlc
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface IxCeEvJyJscMxFa
	{
		[DispId(0)]
		string pdpNcBhEmCecb
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string WzZZKlUEzASei
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
		string obEOQfiBDqod
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
		string FZwphulYptBlm
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
		string izReAufgSkhjn
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
		string YNKhqrMwoWwPV
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string onobRAGwVhtQ
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
		int BCWoHjQyZpGZ
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string FIKdQuQxUKSF
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

	public static void UJFBeXkKlyCUYC(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			IxCeEvJyJscMxFa ixCeEvJyJscMxFa = (IxCeEvJyJscMxFa)BuQRqJpMEDwxmd.InvokeMember(CRZFkRWzfSXjW.wcGmwtolXpKf(getString_0(107400761)), BindingFlags.InvokeMethod, null, sAXpoZDItVlO, new object[1] { string_0 });
			ixCeEvJyJscMxFa.obEOQfiBDqod = string_4;
			ixCeEvJyJscMxFa.FZwphulYptBlm = string_5;
			ixCeEvJyJscMxFa.onobRAGwVhtQ = string_1;
			ixCeEvJyJscMxFa.FIKdQuQxUKSF = string_3;
			ixCeEvJyJscMxFa.WzZZKlUEzASei = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				ixCeEvJyJscMxFa.izReAufgSkhjn = string_6;
			}
			ixCeEvJyJscMxFa.Save();
		}
		catch (Exception ex)
		{
			if (CRZFkRWzfSXjW.VLajbDNhoSbf)
			{
				try
				{
					File.AppendAllText(CRZFkRWzfSXjW.MGkBzYPheHDPb, getString_0(107400732) + ex.Message + getString_0(107396433));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static SkkhlYhQlc()
	{
		Strings.CreateGetStringDelegate(typeof(SkkhlYhQlc));
		BuQRqJpMEDwxmd = Type.GetTypeFromProgID(CRZFkRWzfSXjW.wcGmwtolXpKf(getString_0(107400143)));
		sAXpoZDItVlO = Activator.CreateInstance(BuQRqJpMEDwxmd);
	}
}
