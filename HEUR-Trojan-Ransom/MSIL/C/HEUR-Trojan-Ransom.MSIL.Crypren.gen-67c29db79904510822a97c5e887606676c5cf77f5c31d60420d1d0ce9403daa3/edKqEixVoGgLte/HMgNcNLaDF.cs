using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace edKqEixVoGgLte;

public sealed class HMgNcNLaDF
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface BlmYsqqZCKLIHy
	{
		[DispId(0)]
		string DUrXTjryWLtb
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string YCtQoskYhvNjFl
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
		string ggjquMeBtfsz
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
		string JqiDumFEcciTQH
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
		string jtllnxRqCpIYR
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
		string WqhacAQTaaMCkx
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string ZPUlnUuwCQ
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
		int xlCDodghrzQVpMl
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string XPpXXwxRraH
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

	private static Type tODuAeTyylH;

	private static object PJCcAFEkgEwX;

	[NonSerialized]
	internal static GetString getString_0;

	public static void TvhtRRZUhoef(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			BlmYsqqZCKLIHy blmYsqqZCKLIHy = (BlmYsqqZCKLIHy)tODuAeTyylH.InvokeMember(opmuuofbUtOT.HVpeMrZfkFlb(getString_0(107406279)), BindingFlags.InvokeMethod, null, PJCcAFEkgEwX, new object[1] { string_0 });
			blmYsqqZCKLIHy.ggjquMeBtfsz = string_4;
			blmYsqqZCKLIHy.JqiDumFEcciTQH = string_5;
			blmYsqqZCKLIHy.ZPUlnUuwCQ = string_1;
			blmYsqqZCKLIHy.XPpXXwxRraH = string_3;
			blmYsqqZCKLIHy.YCtQoskYhvNjFl = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				blmYsqqZCKLIHy.jtllnxRqCpIYR = string_6;
			}
			blmYsqqZCKLIHy.Save();
		}
		catch (Exception ex)
		{
			if (opmuuofbUtOT.TiKXhRWKbmQI)
			{
				try
				{
					File.AppendAllText(opmuuofbUtOT.NPfFzxrRnHyw, getString_0(107406250) + ex.Message + getString_0(107396635));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static HMgNcNLaDF()
	{
		Strings.CreateGetStringDelegate(typeof(HMgNcNLaDF));
		tODuAeTyylH = Type.GetTypeFromProgID(opmuuofbUtOT.HVpeMrZfkFlb(getString_0(107405725)));
		PJCcAFEkgEwX = Activator.CreateInstance(tODuAeTyylH);
	}
}
