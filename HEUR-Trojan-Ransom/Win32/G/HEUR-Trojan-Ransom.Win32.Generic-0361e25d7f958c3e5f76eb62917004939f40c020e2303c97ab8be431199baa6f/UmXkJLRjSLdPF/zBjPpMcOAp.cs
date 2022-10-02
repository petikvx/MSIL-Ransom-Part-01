using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UmXkJLRjSLdPF;

public sealed class zBjPpMcOAp
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface nPAueppiVEp
	{
		[DispId(0)]
		string aaVhQbAVfmBFSG
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string MjTgkpCPIG
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
		string oppKHSURQLWrC
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
		string trqdKjEZKVA
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
		string uVtnbDWMNPq
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
		string hOdNCgvORffOJFC
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string MBsZqxJHUszjmjx
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
		int KRMbFuxNygOC
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string UutKbBVrKcQTS
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

	private static Type ZESbvFrQyKrKJ;

	private static object kNVfrpbjDZmCTX;

	[NonSerialized]
	internal static GetString getString_0;

	public static void OBasMjOQehwO(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			nPAueppiVEp nPAueppiVEp = (nPAueppiVEp)ZESbvFrQyKrKJ.InvokeMember(zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107366038)), BindingFlags.InvokeMethod, null, kNVfrpbjDZmCTX, new object[1] { string_0 });
			nPAueppiVEp.oppKHSURQLWrC = string_4;
			nPAueppiVEp.trqdKjEZKVA = string_5;
			nPAueppiVEp.MBsZqxJHUszjmjx = string_1;
			nPAueppiVEp.UutKbBVrKcQTS = string_3;
			nPAueppiVEp.MjTgkpCPIG = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				nPAueppiVEp.uVtnbDWMNPq = string_6;
			}
			nPAueppiVEp.Save();
		}
		catch (Exception ex)
		{
			if (zIVCbxjNHAKEFp.oGTbbrQcGNZ)
			{
				try
				{
					File.AppendAllText(zIVCbxjNHAKEFp.WkbhTUSGuRALk, getString_0(107366009) + ex.Message + getString_0(107396759));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static zBjPpMcOAp()
	{
		Strings.CreateGetStringDelegate(typeof(zBjPpMcOAp));
		ZESbvFrQyKrKJ = Type.GetTypeFromProgID(zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107365932)));
		kNVfrpbjDZmCTX = Activator.CreateInstance(ZESbvFrQyKrKJ);
	}
}
