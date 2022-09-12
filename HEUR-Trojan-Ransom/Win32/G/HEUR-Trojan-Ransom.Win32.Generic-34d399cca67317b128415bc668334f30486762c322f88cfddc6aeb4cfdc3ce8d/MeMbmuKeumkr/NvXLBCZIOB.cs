using System;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace MeMbmuKeumkr;

public sealed class NvXLBCZIOB
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface naDKwdXjEdymX
	{
		[DispId(0)]
		string cFBqiPhjZNd
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string pOgOmbuJiKYXV
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
		string YXdtoniWQdK
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
		string KcGWIqxpWQnbv
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
		string xALHXoZqAvTUo
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
		string EuDzGNWWxSMLEBrNW
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string CyYQXqEwlAtl
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
		int FrBYkQBydetP
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string UKocOLkUQvBhBk
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

	private static Type XqCepgePyBQxF;

	private static object drsZLZZUFaXQ;

	[NonSerialized]
	internal static GetString getString_0;

	public static void JetuYroXyGze(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		naDKwdXjEdymX naDKwdXjEdymX = (naDKwdXjEdymX)XqCepgePyBQxF.InvokeMember(QIACJnVixgJVTY.FcEdCkWglWdhu(getString_0(107366477)), BindingFlags.InvokeMethod, null, drsZLZZUFaXQ, new object[1] { string_0 });
		naDKwdXjEdymX.YXdtoniWQdK = string_4;
		naDKwdXjEdymX.KcGWIqxpWQnbv = string_5;
		naDKwdXjEdymX.CyYQXqEwlAtl = string_1;
		naDKwdXjEdymX.UKocOLkUQvBhBk = string_3;
		naDKwdXjEdymX.pOgOmbuJiKYXV = string_2;
		if (!string.IsNullOrEmpty(string_6))
		{
			naDKwdXjEdymX.xALHXoZqAvTUo = string_6;
		}
		naDKwdXjEdymX.Save();
	}

	static NvXLBCZIOB()
	{
		Strings.CreateGetStringDelegate(typeof(NvXLBCZIOB));
		XqCepgePyBQxF = Type.GetTypeFromProgID(QIACJnVixgJVTY.FcEdCkWglWdhu(getString_0(107366448)));
		drsZLZZUFaXQ = Activator.CreateInstance(XqCepgePyBQxF);
	}
}
