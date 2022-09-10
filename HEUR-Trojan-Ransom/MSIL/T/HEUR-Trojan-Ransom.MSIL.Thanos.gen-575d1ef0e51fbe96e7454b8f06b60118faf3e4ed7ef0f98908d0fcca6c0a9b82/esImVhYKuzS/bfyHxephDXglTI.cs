using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace esImVhYKuzS;

public sealed class bfyHxephDXglTI
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface dJTnirVKAQ
	{
		[DispId(0)]
		string mMNqWYFoIeL
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string raHSBlJqrNW
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
		string jVdHeEnaXufKKBHJZ
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
		string FKKhPoPscEVRYH
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
		string IeZjjmttriHlcb
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
		string XzunScqudiafS
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string vvMyNNyRnPjf
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
		int jFwgHzZXIVC
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string IHwCnJatxaR
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

	private static Type uFUdTElNUGqXqCO;

	private static object HlVRrRsaOotPc;

	[NonSerialized]
	internal static GetString getString_0;

	public static void ZdYYKhZKqGhQi(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			dJTnirVKAQ dJTnirVKAQ = (dJTnirVKAQ)uFUdTElNUGqXqCO.InvokeMember(jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(getString_0(107400821)), BindingFlags.InvokeMethod, null, HlVRrRsaOotPc, new object[1] { string_0 });
			dJTnirVKAQ.jVdHeEnaXufKKBHJZ = string_4;
			dJTnirVKAQ.FKKhPoPscEVRYH = string_5;
			dJTnirVKAQ.vvMyNNyRnPjf = string_1;
			dJTnirVKAQ.IHwCnJatxaR = string_3;
			dJTnirVKAQ.raHSBlJqrNW = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				dJTnirVKAQ.IeZjjmttriHlcb = string_6;
			}
			dJTnirVKAQ.Save();
		}
		catch (Exception ex)
		{
			if (jIDJtYejSBzFCRw.yqFjfeWQNnFtS)
			{
				try
				{
					File.AppendAllText(jIDJtYejSBzFCRw.mldgFSRddxG, getString_0(107400792) + ex.Message + getString_0(107396798));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static bfyHxephDXglTI()
	{
		Strings.CreateGetStringDelegate(typeof(bfyHxephDXglTI));
		uFUdTElNUGqXqCO = Type.GetTypeFromProgID(jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(getString_0(107400715)));
		HlVRrRsaOotPc = Activator.CreateInstance(uFUdTElNUGqXqCO);
	}
}
