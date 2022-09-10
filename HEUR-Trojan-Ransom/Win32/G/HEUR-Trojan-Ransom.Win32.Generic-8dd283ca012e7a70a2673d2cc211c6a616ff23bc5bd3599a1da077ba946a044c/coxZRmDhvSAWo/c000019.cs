using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

public sealed class c000019
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface TpYhUzGMPYfh
	{
		[DispId(0)]
		string ejawTmnVdUbuf
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string p000001
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
		string p000002
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
		string p000003
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
		string XAujrVKJmtGbnwwd
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
		string p000004
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string GXFsqOQRlNiWf
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
		int ePncoGeafPHCxg
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string p000005
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

	private static Type f000054;

	private static object f000055;

	[NonSerialized]
	internal static GetString f000056;

	public static void m00002b(string p0, string p1, string p2, string p3, string p4, string p5, string p6)
	{
		try
		{
			TpYhUzGMPYfh tpYhUzGMPYfh = (TpYhUzGMPYfh)f000054.InvokeMember("CreateShortcut", BindingFlags.InvokeMethod, null, f000055, new object[1] { p0 });
			tpYhUzGMPYfh.p000002 = p4;
			tpYhUzGMPYfh.p000003 = p5;
			tpYhUzGMPYfh.GXFsqOQRlNiWf = p1;
			tpYhUzGMPYfh.p000005 = p3;
			tpYhUzGMPYfh.p000001 = p2;
			if (!string.IsNullOrEmpty(p6))
			{
				tpYhUzGMPYfh.XAujrVKJmtGbnwwd = p6;
			}
			tpYhUzGMPYfh.Save();
		}
		catch (Exception ex)
		{
			if (GhAMvbuoccW.CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(GhAMvbuoccW.f000025, "Error while creating ShortCut: " + ex.Message + "\r\n");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static c000019()
	{
		Strings.CreateGetStringDelegate(typeof(c000019));
		f000054 = Type.GetTypeFromProgID("WScript.Shell");
		f000055 = Activator.CreateInstance(f000054);
	}
}
