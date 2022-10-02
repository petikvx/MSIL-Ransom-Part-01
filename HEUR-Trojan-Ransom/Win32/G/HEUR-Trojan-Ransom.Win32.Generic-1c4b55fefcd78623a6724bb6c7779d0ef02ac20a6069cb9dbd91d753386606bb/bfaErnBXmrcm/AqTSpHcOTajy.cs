using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bfaErnBXmrcm;

public sealed class AqTSpHcOTajy
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface lzpZHfZoFPdfdH
	{
		[DispId(0)]
		string BNdQbWutToHx
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string pyHebQKeGN
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
		string UBfZLaEgNalfvM
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
		string wcFWfGfwoJwvE
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
		string bSUXTNQdujtg
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
		string omPcYGwcFWmqt
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string dLyecTujAp
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
		int CkDBkikhKtA
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string oxpjCevblU
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

	private static Type PTwHtqesDsnx;

	private static object qwHJgsSiXdeXRk;

	[NonSerialized]
	internal static GetString getString_0;

	public static void RfKDQARslGxKzdh(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			lzpZHfZoFPdfdH lzpZHfZoFPdfdH = (lzpZHfZoFPdfdH)PTwHtqesDsnx.InvokeMember(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107367588)), BindingFlags.InvokeMethod, null, qwHJgsSiXdeXRk, new object[1] { string_0 });
			lzpZHfZoFPdfdH.UBfZLaEgNalfvM = string_4;
			lzpZHfZoFPdfdH.wcFWfGfwoJwvE = string_5;
			lzpZHfZoFPdfdH.dLyecTujAp = string_1;
			lzpZHfZoFPdfdH.oxpjCevblU = string_3;
			lzpZHfZoFPdfdH.pyHebQKeGN = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				lzpZHfZoFPdfdH.bSUXTNQdujtg = string_6;
			}
			lzpZHfZoFPdfdH.Save();
		}
		catch (Exception ex)
		{
			if (XPQlliQqqoVcs.bAnlYHNizndgL)
			{
				try
				{
					File.AppendAllText(XPQlliQqqoVcs.aaZyWKMhTXz, getString_0(107367591) + ex.Message + getString_0(107396715));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static AqTSpHcOTajy()
	{
		Strings.CreateGetStringDelegate(typeof(AqTSpHcOTajy));
		PTwHtqesDsnx = Type.GetTypeFromProgID(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107367514)));
		qwHJgsSiXdeXRk = Activator.CreateInstance(PTwHtqesDsnx);
	}
}
