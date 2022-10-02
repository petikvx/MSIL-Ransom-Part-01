using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace GlIxuPPoosXGy;

public sealed class MCrgRxsrJGxI
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface JouBRBaWgWzvSFYUF
	{
		[DispId(0)]
		string TslIAVkyQQOvQOg
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string LGDcfmqidHYg
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
		string MUaDgcdeGjcBME
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
		string nHlxotYBCMdsBE
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
		string CpYAZUjavSI
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
		string RIiSpEgmXy
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string lCwQKYkQpGaWlkJD
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
		int kIcuJLvhwAZCiy
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string eWGxdvBtKN
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

	private static Type YIWpzxLMktlHj;

	private static object IvdvSMjyXuuUZJ;

	[NonSerialized]
	internal static GetString getString_0;

	public static void SoAEVnAkTLhlc(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			JouBRBaWgWzvSFYUF jouBRBaWgWzvSFYUF = (JouBRBaWgWzvSFYUF)YIWpzxLMktlHj.InvokeMember(kdXBbWqHjtnYq.hNmpLWayyKYy(getString_0(107402562)), BindingFlags.InvokeMethod, null, IvdvSMjyXuuUZJ, new object[1] { string_0 });
			jouBRBaWgWzvSFYUF.MUaDgcdeGjcBME = string_4;
			jouBRBaWgWzvSFYUF.nHlxotYBCMdsBE = string_5;
			jouBRBaWgWzvSFYUF.lCwQKYkQpGaWlkJD = string_1;
			jouBRBaWgWzvSFYUF.eWGxdvBtKN = string_3;
			jouBRBaWgWzvSFYUF.LGDcfmqidHYg = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				jouBRBaWgWzvSFYUF.CpYAZUjavSI = string_6;
			}
			jouBRBaWgWzvSFYUF.Save();
		}
		catch (Exception ex)
		{
			if (kdXBbWqHjtnYq.keaHDdagjiDMCTfH)
			{
				try
				{
					File.AppendAllText(kdXBbWqHjtnYq.RztYwSIsnQJzs, getString_0(107402533) + ex.Message + getString_0(107396390));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static MCrgRxsrJGxI()
	{
		Strings.CreateGetStringDelegate(typeof(MCrgRxsrJGxI));
		YIWpzxLMktlHj = Type.GetTypeFromProgID(kdXBbWqHjtnYq.hNmpLWayyKYy(getString_0(107402520)));
		IvdvSMjyXuuUZJ = Activator.CreateInstance(YIWpzxLMktlHj);
	}
}
