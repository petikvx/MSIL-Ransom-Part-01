using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fAuBSMaVICral;

public sealed class DpmAYzuUtYtL
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface hFmvZMysssAdN
	{
		[DispId(0)]
		string WrcmhCeZuSo
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string xemEuoIBde
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
		string roVLrRvebcBPQ
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
		string omuKAzsZwbhAlh
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
		string QKNXGjlnbr
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
		string OexfUGrULqmo
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string BdXdEMPcZVwoEV
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
		int dycAMtxkDPly
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string TxomtcZuYcMGpc
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

	private static Type bSTjJHQOIcc;

	private static object kMpiniQVyzlVxzR;

	[NonSerialized]
	internal static GetString getString_0;

	public static void OcBXzowwAu(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			hFmvZMysssAdN hFmvZMysssAdN = (hFmvZMysssAdN)bSTjJHQOIcc.InvokeMember(YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107461563)), BindingFlags.InvokeMethod, null, kMpiniQVyzlVxzR, new object[1] { string_0 });
			hFmvZMysssAdN.roVLrRvebcBPQ = string_4;
			hFmvZMysssAdN.omuKAzsZwbhAlh = string_5;
			hFmvZMysssAdN.BdXdEMPcZVwoEV = string_1;
			hFmvZMysssAdN.TxomtcZuYcMGpc = string_3;
			hFmvZMysssAdN.xemEuoIBde = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				hFmvZMysssAdN.QKNXGjlnbr = string_6;
			}
			hFmvZMysssAdN.Save();
		}
		catch (Exception ex)
		{
			if (YpCGOwjDWwATs.IOdNTzsqoZWVAC)
			{
				try
				{
					File.AppendAllText(YpCGOwjDWwATs.kZGwVMpcMFQGdu, getString_0(107461022) + ex.Message + getString_0(107396710));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static DpmAYzuUtYtL()
	{
		Strings.CreateGetStringDelegate(typeof(DpmAYzuUtYtL));
		bSTjJHQOIcc = Type.GetTypeFromProgID(YpCGOwjDWwATs.gUlAYNDfQee(getString_0(107460945)));
		kMpiniQVyzlVxzR = Activator.CreateInstance(bSTjJHQOIcc);
	}
}
