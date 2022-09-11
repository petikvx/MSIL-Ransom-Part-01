using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace oEqFtKwIikP;

public class JTZccBnyjlty
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface PdMvJcQNpGjYIiUmJ
	{
		[DispId(0)]
		string OIhxbuKzvoja
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string tvPaeUuoqfrnC
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
		string sggdDJhSKwLqyj
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
		string CMwRZffswVHZrs
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
		string UoAinBwxcRu
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
		string zABdDGqGTkAoOuNhE
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string gRDHPDOwSWxVnRt
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
		int AjRXjFQtwPr
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string xrSOujSuBpxiA
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

	private static Type QXGLvGzyyIom = Type.GetTypeFromProgID(ieyWohRMXsyos.tEHBqPAYINDcv("V1NjcmlwdC5TaGVsbA=="));

	private static object khkgLbbyNiD = Activator.CreateInstance(QXGLvGzyyIom);

	public static void QdcdiDYTNRezA(string ryVVNjyVZLhl, string WxvmyhDWtbgP, string QKBtsYfnGWg, string kaXZuNWDLwxuyJb, string KYbaEkgUoLvT, string CwUYHWozqp, string KnOTeHyxhMWo)
	{
		PdMvJcQNpGjYIiUmJ pdMvJcQNpGjYIiUmJ = (PdMvJcQNpGjYIiUmJ)QXGLvGzyyIom.InvokeMember(ieyWohRMXsyos.tEHBqPAYINDcv("Q3JlYXRlU2hvcnRjdXQ="), BindingFlags.InvokeMethod, null, khkgLbbyNiD, new object[1] { ryVVNjyVZLhl });
		pdMvJcQNpGjYIiUmJ.sggdDJhSKwLqyj = KYbaEkgUoLvT;
		pdMvJcQNpGjYIiUmJ.CMwRZffswVHZrs = CwUYHWozqp;
		pdMvJcQNpGjYIiUmJ.gRDHPDOwSWxVnRt = WxvmyhDWtbgP;
		pdMvJcQNpGjYIiUmJ.xrSOujSuBpxiA = kaXZuNWDLwxuyJb;
		pdMvJcQNpGjYIiUmJ.tvPaeUuoqfrnC = QKBtsYfnGWg;
		if (!string.IsNullOrEmpty(KnOTeHyxhMWo))
		{
			pdMvJcQNpGjYIiUmJ.UoAinBwxcRu = KnOTeHyxhMWo;
		}
		pdMvJcQNpGjYIiUmJ.Save();
	}
}
