using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace nZBhTHSmQawuU;

public sealed class XSwfTyAtiDpocYFpc
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface jhsCKmKOOEGcd
	{
		[DispId(0)]
		string HUuwSwoayPe
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string rlGIbpgTqYrPvh
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
		string iqoieYoUcAQwuKT
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
		string fCIQvnuKIG
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
		string TgAIApXUfJJr
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
		string XhpHLHKUcdxI
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string xNPTGyikyOUw
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
		int cJhHXHlzzoWpC
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string NertDmidSEZU
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

	private static Type ClJZSrtpzqyspBO;

	private static object WSMDIgVJWTSBn;

	[NonSerialized]
	internal static GetString getString_0;

	public static void naaejLSCErOJun(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			jhsCKmKOOEGcd jhsCKmKOOEGcd = (jhsCKmKOOEGcd)ClJZSrtpzqyspBO.InvokeMember(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107462566)), BindingFlags.InvokeMethod, null, WSMDIgVJWTSBn, new object[1] { string_0 });
			jhsCKmKOOEGcd.iqoieYoUcAQwuKT = string_4;
			jhsCKmKOOEGcd.fCIQvnuKIG = string_5;
			jhsCKmKOOEGcd.xNPTGyikyOUw = string_1;
			jhsCKmKOOEGcd.NertDmidSEZU = string_3;
			jhsCKmKOOEGcd.rlGIbpgTqYrPvh = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				jhsCKmKOOEGcd.TgAIApXUfJJr = string_6;
			}
			jhsCKmKOOEGcd.Save();
		}
		catch (Exception ex)
		{
			if (WzLdBSYJOokD.dthSBCusajClaD)
			{
				try
				{
					File.AppendAllText(WzLdBSYJOokD.zdOFfLRUeZwiM, getString_0(107462537) + ex.Message + getString_0(107396601));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static XSwfTyAtiDpocYFpc()
	{
		Strings.CreateGetStringDelegate(typeof(XSwfTyAtiDpocYFpc));
		ClJZSrtpzqyspBO = Type.GetTypeFromProgID(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107462460)));
		WSMDIgVJWTSBn = Activator.CreateInstance(ClJZSrtpzqyspBO);
	}
}
