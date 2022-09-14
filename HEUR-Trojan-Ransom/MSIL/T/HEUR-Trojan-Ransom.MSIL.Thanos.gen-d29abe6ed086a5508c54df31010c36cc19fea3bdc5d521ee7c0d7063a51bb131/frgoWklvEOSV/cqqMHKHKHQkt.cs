using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

public sealed class cqqMHKHKHQkt
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface EwjSRatTRKu
	{
		[DispId(0)]
		string sIvZbsnNomb
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string niIRnqpVGnT
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
		string ZLWyddHxMFyge
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
		string SMvQlKzDvuETjbc
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
		string mKUsCwvKzAZtkQYDq
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
		string FqQyLlkbxQRl
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string DsEqJLgUSBT
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
		int okmFpsEuznvS
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string ZLcgTlMiQx
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

	private static Type aWXYNLCcuqQO;

	private static object XBaNqhVcgn;

	[NonSerialized]
	internal static GetString getString_0;

	public static void MzToDMiFBwaOs(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			EwjSRatTRKu ewjSRatTRKu = (EwjSRatTRKu)aWXYNLCcuqQO.InvokeMember(PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107400057)), BindingFlags.InvokeMethod, null, XBaNqhVcgn, new object[1] { string_0 });
			ewjSRatTRKu.ZLWyddHxMFyge = string_4;
			ewjSRatTRKu.SMvQlKzDvuETjbc = string_5;
			ewjSRatTRKu.DsEqJLgUSBT = string_1;
			ewjSRatTRKu.ZLcgTlMiQx = string_3;
			ewjSRatTRKu.niIRnqpVGnT = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				ewjSRatTRKu.mKUsCwvKzAZtkQYDq = string_6;
			}
			ewjSRatTRKu.Save();
		}
		catch (Exception ex)
		{
			if (PFruJiQrcriiZ.joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(PFruJiQrcriiZ.jnRLNtXuRRg, getString_0(107399996) + ex.Message + getString_0(107396365));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static cqqMHKHKHQkt()
	{
		Strings.CreateGetStringDelegate(typeof(cqqMHKHKHQkt));
		aWXYNLCcuqQO = Type.GetTypeFromProgID(PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107399983)));
		XBaNqhVcgn = Activator.CreateInstance(aWXYNLCcuqQO);
	}
}
