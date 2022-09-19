using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

public sealed class yJKOYFzqfaYSn
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface lQdTJJklXhs
	{
		[DispId(0)]
		string eaGLkzIagQznR
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string tCZcsyxUBaKpyw
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
		string gJipWNatrSkuCY
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
		string GksuVQpdsQ
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
		string ehDsQoveeqZ
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
		string soZAtaiSaKynA
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string oQXbiPkHKMRmr
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
		int FLzQAMKNXRYgQg
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string orpppOgmCsDjE
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

	private static Type KmFKABrQefE;

	private static object kKeqrqDekRaCfZk;

	[NonSerialized]
	internal static GetString getString_0;

	public static void tUJFOtGiLvH(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			lQdTJJklXhs lQdTJJklXhs = (lQdTJJklXhs)KmFKABrQefE.InvokeMember(ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107378753)), BindingFlags.InvokeMethod, null, kKeqrqDekRaCfZk, new object[1] { string_0 });
			lQdTJJklXhs.gJipWNatrSkuCY = string_4;
			lQdTJJklXhs.GksuVQpdsQ = string_5;
			lQdTJJklXhs.oQXbiPkHKMRmr = string_1;
			lQdTJJklXhs.orpppOgmCsDjE = string_3;
			lQdTJJklXhs.tCZcsyxUBaKpyw = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				lQdTJJklXhs.ehDsQoveeqZ = string_6;
			}
			lQdTJJklXhs.Save();
		}
		catch (Exception ex)
		{
			if (ACJZwXMCdgNnIA.SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(ACJZwXMCdgNnIA.bDDJFCkjBbYQ, getString_0(107378724) + ex.Message + getString_0(107396753));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static yJKOYFzqfaYSn()
	{
		Strings.CreateGetStringDelegate(typeof(yJKOYFzqfaYSn));
		KmFKABrQefE = Type.GetTypeFromProgID(ACJZwXMCdgNnIA.UJcPFgFtVJhWf(getString_0(107378679)));
		kKeqrqDekRaCfZk = Activator.CreateInstance(KmFKABrQefE);
	}
}
