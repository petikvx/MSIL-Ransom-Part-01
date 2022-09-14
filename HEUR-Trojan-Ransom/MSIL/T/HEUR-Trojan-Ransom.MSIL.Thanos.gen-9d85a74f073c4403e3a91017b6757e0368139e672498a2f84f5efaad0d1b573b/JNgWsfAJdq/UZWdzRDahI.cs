using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace JNgWsfAJdq;

public sealed class UZWdzRDahI
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface XFqbjhhIgmeFZ
	{
		[DispId(0)]
		string JiukEaWgJRv
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string BqWbeRBesByO
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
		string LQmmtEQAsSlzA
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
		string nifkxARzVPYcmaQS
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
		string MoXfuiYXmg
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
		string GpJUpsxeCaEN
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string XjwvQHPBSRrTGx
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
		int tfZRWQazsNGEj
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string puKICeojGijYjJgL
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

	private static Type ehKZYRzkqclJBT;

	private static object stlFbDnlPIK;

	[NonSerialized]
	internal static GetString getString_0;

	public static void lCvgkITUwspSS(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			XFqbjhhIgmeFZ xFqbjhhIgmeFZ = (XFqbjhhIgmeFZ)ehKZYRzkqclJBT.InvokeMember(vjvaexovZfdCP.OQNgkgiZsRBtM(getString_0(107460872)), BindingFlags.InvokeMethod, null, stlFbDnlPIK, new object[1] { string_0 });
			xFqbjhhIgmeFZ.LQmmtEQAsSlzA = string_4;
			xFqbjhhIgmeFZ.nifkxARzVPYcmaQS = string_5;
			xFqbjhhIgmeFZ.XjwvQHPBSRrTGx = string_1;
			xFqbjhhIgmeFZ.puKICeojGijYjJgL = string_3;
			xFqbjhhIgmeFZ.BqWbeRBesByO = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				xFqbjhhIgmeFZ.MoXfuiYXmg = string_6;
			}
			xFqbjhhIgmeFZ.Save();
		}
		catch (Exception ex)
		{
			if (vjvaexovZfdCP.mLogOAlXxCGZma)
			{
				try
				{
					File.AppendAllText(vjvaexovZfdCP.PuxbPamNEvKf, getString_0(107460843) + ex.Message + getString_0(107396667));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static UZWdzRDahI()
	{
		Strings.CreateGetStringDelegate(typeof(UZWdzRDahI));
		ehKZYRzkqclJBT = Type.GetTypeFromProgID(vjvaexovZfdCP.OQNgkgiZsRBtM(getString_0(107460830)));
		stlFbDnlPIK = Activator.CreateInstance(ehKZYRzkqclJBT);
	}
}
