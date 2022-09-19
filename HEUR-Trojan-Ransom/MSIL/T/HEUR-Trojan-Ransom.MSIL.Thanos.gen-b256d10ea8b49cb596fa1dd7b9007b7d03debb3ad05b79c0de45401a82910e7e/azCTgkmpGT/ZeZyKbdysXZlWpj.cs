using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

public sealed class ZeZyKbdysXZlWpj
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface lQdTJJklXhs
	{
		[DispId(0)]
		string ehyiUBLYVGB
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string YEfpWQhAAaSQlD
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
		string ZAGEXIGPBsh
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
		string DpMBYFfSArkDZg
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
		string QsetzYEQGWHt
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
		string puvOFVKZCTLQ
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string yFHCEDlxzVmaYaF
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
		int AkFcuElPzWMOo
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string EGdbeTeJEIWhj
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

	public static void nvTJKZDbqwJM(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			lQdTJJklXhs lQdTJJklXhs = (lQdTJJklXhs)KmFKABrQefE.InvokeMember(tEjVFvrPgtsm.OEjiexKEqeO(getString_0(107379348)), BindingFlags.InvokeMethod, null, kKeqrqDekRaCfZk, new object[1] { string_0 });
			lQdTJJklXhs.ZAGEXIGPBsh = string_4;
			lQdTJJklXhs.DpMBYFfSArkDZg = string_5;
			lQdTJJklXhs.yFHCEDlxzVmaYaF = string_1;
			lQdTJJklXhs.EGdbeTeJEIWhj = string_3;
			lQdTJJklXhs.YEfpWQhAAaSQlD = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				lQdTJJklXhs.QsetzYEQGWHt = string_6;
			}
			lQdTJJklXhs.Save();
		}
		catch (Exception ex)
		{
			if (tEjVFvrPgtsm.SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(tEjVFvrPgtsm.bDDJFCkjBbYQ, getString_0(107379351) + ex.Message + getString_0(107396551));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static ZeZyKbdysXZlWpj()
	{
		Strings.CreateGetStringDelegate(typeof(ZeZyKbdysXZlWpj));
		KmFKABrQefE = Type.GetTypeFromProgID(tEjVFvrPgtsm.OEjiexKEqeO(getString_0(107379274)));
		kKeqrqDekRaCfZk = Activator.CreateInstance(KmFKABrQefE);
	}
}
