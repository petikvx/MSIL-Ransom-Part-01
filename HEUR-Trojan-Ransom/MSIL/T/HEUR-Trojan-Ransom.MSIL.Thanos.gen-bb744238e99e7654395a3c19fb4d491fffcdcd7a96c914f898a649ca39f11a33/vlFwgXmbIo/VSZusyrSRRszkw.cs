using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace vlFwgXmbIo;

public sealed class VSZusyrSRRszkw
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface xgQKbcTQTiBGK
	{
		[DispId(0)]
		string tUnHOJkFLs
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string yeqQJHdVEXqVW
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
		string chBMoJIvwS
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
		string KhjFDdbvMPMjr
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
		string TXJdXJntnEaj
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
		string wMbZbWsVWWawkieT
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string PomcEeToNvZKtY
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
		int wTMINydplTX
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string iMBiLEWrSKIOlJM
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

	private static Type MBivxNpsFc;

	private static object suvHgAWcXgqdW;

	[NonSerialized]
	internal static GetString getString_0;

	public static void ExnpsTnhoAu(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			xgQKbcTQTiBGK xgQKbcTQTiBGK = (xgQKbcTQTiBGK)MBivxNpsFc.InvokeMember(RQEwPOshulKqs.JqDJfBiOyDaAy(getString_0(107403156)), BindingFlags.InvokeMethod, null, suvHgAWcXgqdW, new object[1] { string_0 });
			xgQKbcTQTiBGK.chBMoJIvwS = string_4;
			xgQKbcTQTiBGK.KhjFDdbvMPMjr = string_5;
			xgQKbcTQTiBGK.PomcEeToNvZKtY = string_1;
			xgQKbcTQTiBGK.iMBiLEWrSKIOlJM = string_3;
			xgQKbcTQTiBGK.yeqQJHdVEXqVW = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				xgQKbcTQTiBGK.TXJdXJntnEaj = string_6;
			}
			xgQKbcTQTiBGK.Save();
		}
		catch (Exception ex)
		{
			if (RQEwPOshulKqs.rcFXGcWApOJB)
			{
				try
				{
					File.AppendAllText(RQEwPOshulKqs.nPLbuhisBzmHoeaY, getString_0(107403127) + ex.Message + getString_0(107396354));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static VSZusyrSRRszkw()
	{
		Strings.CreateGetStringDelegate(typeof(VSZusyrSRRszkw));
		MBivxNpsFc = Type.GetTypeFromProgID(RQEwPOshulKqs.JqDJfBiOyDaAy(getString_0(107403050)));
		suvHgAWcXgqdW = Activator.CreateInstance(MBivxNpsFc);
	}
}
