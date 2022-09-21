using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ybfSLIGKlaODvJ;

public sealed class zyotIScLtRpcl
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface AoUnfTyMPsWK
	{
		[DispId(0)]
		string vtuEYEQkrgRmjqz
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string aCqnjAOuGGoinU
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
		string QzLgwSxdSzPmfUe
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
		string TrOsSlDDTMrthHqn
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
		string sxoEwlnWtX
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
		string eyQWHziCvjf
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string DJfCRVHeveIQdpY
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
		int cSKxajkkrFxJFQO
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string tLpCNGkpumfA
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

	private static Type nCrOrHmWOlpX;

	private static object CuMHgkzyGlMZn;

	[NonSerialized]
	internal static GetString getString_0;

	public static void qhFKbIEABtm(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			AoUnfTyMPsWK aoUnfTyMPsWK = (AoUnfTyMPsWK)nCrOrHmWOlpX.InvokeMember(iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107399513)), BindingFlags.InvokeMethod, null, CuMHgkzyGlMZn, new object[1] { string_0 });
			aoUnfTyMPsWK.QzLgwSxdSzPmfUe = string_4;
			aoUnfTyMPsWK.TrOsSlDDTMrthHqn = string_5;
			aoUnfTyMPsWK.DJfCRVHeveIQdpY = string_1;
			aoUnfTyMPsWK.tLpCNGkpumfA = string_3;
			aoUnfTyMPsWK.aCqnjAOuGGoinU = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				aoUnfTyMPsWK.sxoEwlnWtX = string_6;
			}
			aoUnfTyMPsWK.Save();
		}
		catch (Exception ex)
		{
			if (iWNOuKBWgwsf.eCrtUqxUXqEDfkG)
			{
				try
				{
					File.AppendAllText(iWNOuKBWgwsf.ZOToawIMfprr, getString_0(107399484) + ex.Message + getString_0(107396401));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static zyotIScLtRpcl()
	{
		Strings.CreateGetStringDelegate(typeof(zyotIScLtRpcl));
		nCrOrHmWOlpX = Type.GetTypeFromProgID(iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107399439)));
		CuMHgkzyGlMZn = Activator.CreateInstance(nCrOrHmWOlpX);
	}
}
