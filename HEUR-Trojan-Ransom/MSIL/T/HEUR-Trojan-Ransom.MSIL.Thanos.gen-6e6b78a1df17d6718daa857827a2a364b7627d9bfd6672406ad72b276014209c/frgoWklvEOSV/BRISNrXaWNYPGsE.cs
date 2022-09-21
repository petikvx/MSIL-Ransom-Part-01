using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

public sealed class BRISNrXaWNYPGsE
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface EwjSRatTRKu
	{
		[DispId(0)]
		string xPZpxBawTYcPTx
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string QgDGAmKqWjjfHH
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
		string tbEcytZrelt
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
		string tFxtDFEWlCKdk
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
		string FvVmHTNxmgth
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
		string oASNfqxTPmRxZk
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string lFgzQnJAwgbFda
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
		int MMQrXwfPiftU
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string dmpTEtSHuMm
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

	public static void QNZIvLnWtWHkz(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			EwjSRatTRKu ewjSRatTRKu = (EwjSRatTRKu)aWXYNLCcuqQO.InvokeMember(GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107399030)), BindingFlags.InvokeMethod, null, XBaNqhVcgn, new object[1] { string_0 });
			ewjSRatTRKu.tbEcytZrelt = string_4;
			ewjSRatTRKu.tFxtDFEWlCKdk = string_5;
			ewjSRatTRKu.lFgzQnJAwgbFda = string_1;
			ewjSRatTRKu.dmpTEtSHuMm = string_3;
			ewjSRatTRKu.QgDGAmKqWjjfHH = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				ewjSRatTRKu.FvVmHTNxmgth = string_6;
			}
			ewjSRatTRKu.Save();
		}
		catch (Exception ex)
		{
			if (GRQFeQGQfBG.joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(GRQFeQGQfBG.jnRLNtXuRRg, getString_0(107398969) + ex.Message + getString_0(107396373));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static BRISNrXaWNYPGsE()
	{
		Strings.CreateGetStringDelegate(typeof(BRISNrXaWNYPGsE));
		aWXYNLCcuqQO = Type.GetTypeFromProgID(GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107398956)));
		XBaNqhVcgn = Activator.CreateInstance(aWXYNLCcuqQO);
	}
}
