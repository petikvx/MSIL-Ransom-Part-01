using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace orBiLhAbVg;

public sealed class JxIFFyAmPaOFdk
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface FPXEOnJlUJlro
	{
		[DispId(0)]
		string mZOCUjBXVBqPayw
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string PWcuVaNbNuiJQZG
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
		string JSIdHuxVooMRDNK
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
		string pWNphoaCDLaC
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
		string mXbIYubbBxRYM
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
		string NNMboTwZtRYS
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string QlmsDJlYmSqjGw
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
		int lCKHzpOKBIh
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string qDikrftCOXINyOG
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

	private static Type geeJQXOPcYGEZ;

	private static object TbOnVLyHepS;

	[NonSerialized]
	internal static GetString getString_0;

	public static void rHyPdYmkkBs(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			FPXEOnJlUJlro fPXEOnJlUJlro = (FPXEOnJlUJlro)geeJQXOPcYGEZ.InvokeMember(MJmySpXyeIcv.AmPZukeXOc(getString_0(107407788)), BindingFlags.InvokeMethod, null, TbOnVLyHepS, new object[1] { string_0 });
			fPXEOnJlUJlro.JSIdHuxVooMRDNK = string_4;
			fPXEOnJlUJlro.pWNphoaCDLaC = string_5;
			fPXEOnJlUJlro.QlmsDJlYmSqjGw = string_1;
			fPXEOnJlUJlro.qDikrftCOXINyOG = string_3;
			fPXEOnJlUJlro.PWcuVaNbNuiJQZG = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				fPXEOnJlUJlro.mXbIYubbBxRYM = string_6;
			}
			fPXEOnJlUJlro.Save();
		}
		catch (Exception ex)
		{
			if (MJmySpXyeIcv.hNuljeIxIR)
			{
				try
				{
					File.AppendAllText(MJmySpXyeIcv.hGxNuUuVHRPb, getString_0(107407247) + ex.Message + getString_0(107396698));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static JxIFFyAmPaOFdk()
	{
		Strings.CreateGetStringDelegate(typeof(JxIFFyAmPaOFdk));
		geeJQXOPcYGEZ = Type.GetTypeFromProgID(MJmySpXyeIcv.AmPZukeXOc(getString_0(107407170)));
		TbOnVLyHepS = Activator.CreateInstance(geeJQXOPcYGEZ);
	}
}
