using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace MufMaOSvGyvz;

public class PDPmvqgvIguXKGS
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface FBqQxbujAkO
	{
		[DispId(0)]
		string APmUqWqGqXhZg
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string peMgjfIzVGWqUKjBsb
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
		string KvNZJAMjCVsdYlb
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
		string kvXUHrmDwjogj
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
		string uthEHKoaLAbUg
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
		string ELHnWikFFpqxRW
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string xAvWKKHxzJVu
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
		int wvirdNYNMobjS
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string SjUoxQLIQfmnVDK
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

	private static Type guALPVXzZrXCxQGy = Type.GetTypeFromProgID(IyUWqQZlcOSTLhq.jKGdMalhZeKXBCvc("V1NjcmlwdC5TaGVsbA=="));

	private static object GOgcrtCCxONESyk = Activator.CreateInstance(guALPVXzZrXCxQGy);

	public static void BPwwjcgjbB(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		FBqQxbujAkO fBqQxbujAkO = (FBqQxbujAkO)guALPVXzZrXCxQGy.InvokeMember(IyUWqQZlcOSTLhq.jKGdMalhZeKXBCvc("Q3JlYXRlU2hvcnRjdXQ="), BindingFlags.InvokeMethod, null, GOgcrtCCxONESyk, new object[1] { string_0 });
		fBqQxbujAkO.KvNZJAMjCVsdYlb = string_4;
		fBqQxbujAkO.kvXUHrmDwjogj = string_5;
		fBqQxbujAkO.xAvWKKHxzJVu = string_1;
		fBqQxbujAkO.SjUoxQLIQfmnVDK = string_3;
		fBqQxbujAkO.peMgjfIzVGWqUKjBsb = string_2;
		if (!string.IsNullOrEmpty(string_6))
		{
			fBqQxbujAkO.uthEHKoaLAbUg = string_6;
		}
		fBqQxbujAkO.Save();
	}
}
