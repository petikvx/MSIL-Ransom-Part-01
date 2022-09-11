using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace OedchgEuvSrX;

public class NQkPfEAxcRIM
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface FqZLlaLyVff
	{
		[DispId(0)]
		string CRZVjouMGlmU
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string uaCcnSToLE
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
		string IKmxROGpuffJ
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
		string aaUtYItUwl
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
		string JNDgkAvEcst
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
		string EwIdnMXqYVmHu
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string YuhQwSEfzCBeG
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
		int HRLXDADKpoiAd
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string ZBSSGjtmXDd
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

	private static Type xdRrJYErKuwwSQ = Type.GetTypeFromProgID("WScript.Shell");

	private static object ifrqjOLjndnde = Activator.CreateInstance(xdRrJYErKuwwSQ);

	public static void KRfWMWGbyiGNlL(string FZsXJHvoXvqjB, string TcAcdeBmrdattha, string jTmnXmarEgmDGN, string JwIcfZfhXT, string FVWxWvJYCuuQI, string bXxjBqumeThshznW, string fKhTMznIWN)
	{
		FqZLlaLyVff fqZLlaLyVff = (FqZLlaLyVff)xdRrJYErKuwwSQ.InvokeMember("CreateShortcut", BindingFlags.InvokeMethod, null, ifrqjOLjndnde, new object[1] { FZsXJHvoXvqjB });
		fqZLlaLyVff.IKmxROGpuffJ = FVWxWvJYCuuQI;
		fqZLlaLyVff.aaUtYItUwl = bXxjBqumeThshznW;
		fqZLlaLyVff.YuhQwSEfzCBeG = TcAcdeBmrdattha;
		fqZLlaLyVff.ZBSSGjtmXDd = JwIcfZfhXT;
		fqZLlaLyVff.uaCcnSToLE = jTmnXmarEgmDGN;
		if (!string.IsNullOrEmpty(fKhTMznIWN))
		{
			fqZLlaLyVff.JNDgkAvEcst = fKhTMznIWN;
		}
		fqZLlaLyVff.Save();
	}
}
