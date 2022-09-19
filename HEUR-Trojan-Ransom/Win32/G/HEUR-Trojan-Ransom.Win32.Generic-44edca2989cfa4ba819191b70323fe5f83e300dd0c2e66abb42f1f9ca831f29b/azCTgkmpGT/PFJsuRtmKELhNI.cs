using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

public sealed class PFJsuRtmKELhNI
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface lQdTJJklXhs
	{
		[DispId(0)]
		string SjfyYYvtsqMBCTDa
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string KstjUdzpIwOD
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
		string UXGyFFPwGzhYq
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
		string pEdCtVCWRtK
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
		string ZlaXiSLwKPfmTV
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
		string VugYEzBpaxZp
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string TbXomRFEOtFrg
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
		int WuBuIMfjTYyt
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string thNYkkQYXhIyLABA
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

	public static void DQSNSZueuFrrI(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			lQdTJJklXhs lQdTJJklXhs = (lQdTJJklXhs)KmFKABrQefE.InvokeMember(cQHVlxVivZVq.sNXkawcfFmeqKOWI(getString_0(107379805)), BindingFlags.InvokeMethod, null, kKeqrqDekRaCfZk, new object[1] { string_0 });
			lQdTJJklXhs.UXGyFFPwGzhYq = string_4;
			lQdTJJklXhs.pEdCtVCWRtK = string_5;
			lQdTJJklXhs.TbXomRFEOtFrg = string_1;
			lQdTJJklXhs.thNYkkQYXhIyLABA = string_3;
			lQdTJJklXhs.KstjUdzpIwOD = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				lQdTJJklXhs.ZlaXiSLwKPfmTV = string_6;
			}
			lQdTJJklXhs.Save();
		}
		catch (Exception ex)
		{
			if (cQHVlxVivZVq.SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(cQHVlxVivZVq.bDDJFCkjBbYQ, getString_0(107379776) + ex.Message + getString_0(107395979));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static PFJsuRtmKELhNI()
	{
		Strings.CreateGetStringDelegate(typeof(PFJsuRtmKELhNI));
		KmFKABrQefE = Type.GetTypeFromProgID(cQHVlxVivZVq.sNXkawcfFmeqKOWI(getString_0(107379699)));
		kKeqrqDekRaCfZk = Activator.CreateInstance(KmFKABrQefE);
	}
}
