using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bmDbQpaZORfnY;

public sealed class lUZTqoTtayk
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface CAFRVqTGeQJd
	{
		[DispId(0)]
		string HsKfUtqiBbfE
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string GtBBVxuvgSfa
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
		string fKxxqDrobTOT
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
		string MKdiGyjtNjPlkhj
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
		string jsNWIiMwWFAkFg
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
		string yAfhicltBmIyDe
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string IgjrBfrxfThpMj
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
		int TFPOauyIEzazs
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string ffsgpCCshsJRaSy
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

	private static Type hquGPjDbxgCui;

	private static object dtxGZqQpLDPzd;

	[NonSerialized]
	internal static GetString getString_0;

	public static void MpzqpgZSIXQk(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			CAFRVqTGeQJd cAFRVqTGeQJd = (CAFRVqTGeQJd)hquGPjDbxgCui.InvokeMember(qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107402011)), BindingFlags.InvokeMethod, null, dtxGZqQpLDPzd, new object[1] { string_0 });
			cAFRVqTGeQJd.fKxxqDrobTOT = string_4;
			cAFRVqTGeQJd.MKdiGyjtNjPlkhj = string_5;
			cAFRVqTGeQJd.IgjrBfrxfThpMj = string_1;
			cAFRVqTGeQJd.ffsgpCCshsJRaSy = string_3;
			cAFRVqTGeQJd.GtBBVxuvgSfa = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				cAFRVqTGeQJd.jsNWIiMwWFAkFg = string_6;
			}
			cAFRVqTGeQJd.Save();
		}
		catch (Exception ex)
		{
			if (qMBmfvOoVnw.XZxMDRItGAyFV)
			{
				try
				{
					File.AppendAllText(qMBmfvOoVnw.yOCAHBSkOQrG, getString_0(107401982) + ex.Message + getString_0(107396434));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static lUZTqoTtayk()
	{
		Strings.CreateGetStringDelegate(typeof(lUZTqoTtayk));
		hquGPjDbxgCui = Type.GetTypeFromProgID(qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107401937)));
		dtxGZqQpLDPzd = Activator.CreateInstance(hquGPjDbxgCui);
	}
}
