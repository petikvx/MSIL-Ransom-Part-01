using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace igelRrgoft;

public sealed class hhaEdmOlzJdiPP
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface mVDrRnjBufTjCLk
	{
		[DispId(0)]
		string qqrcEPEqdznxdK
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string LHMoFvXwAmCEB
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
		string DDGwTfQAUdOJv
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
		string dXcokgCMSMjSbGzs
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
		string IwmCvngAVyzwNPo
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
		string HsrDRULTxjA
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string eGDopHPeSKly
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
		int zhLZbULPwQ
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string XkTLKEbFdGMXkp
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

	private static Type GrTgxnciOTwVg;

	private static object KTbciZqOLEX;

	[NonSerialized]
	internal static GetString getString_0;

	public static void OOffzqvMrmeMoD(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			mVDrRnjBufTjCLk mVDrRnjBufTjCLk = (mVDrRnjBufTjCLk)GrTgxnciOTwVg.InvokeMember(DbQGfNcxACeJl.fZQJZGRivPka(getString_0(107404840)), BindingFlags.InvokeMethod, null, KTbciZqOLEX, new object[1] { string_0 });
			mVDrRnjBufTjCLk.DDGwTfQAUdOJv = string_4;
			mVDrRnjBufTjCLk.dXcokgCMSMjSbGzs = string_5;
			mVDrRnjBufTjCLk.eGDopHPeSKly = string_1;
			mVDrRnjBufTjCLk.XkTLKEbFdGMXkp = string_3;
			mVDrRnjBufTjCLk.LHMoFvXwAmCEB = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				mVDrRnjBufTjCLk.IwmCvngAVyzwNPo = string_6;
			}
			mVDrRnjBufTjCLk.Save();
		}
		catch (Exception ex)
		{
			if (DbQGfNcxACeJl.wnBkEuneoGOR)
			{
				try
				{
					File.AppendAllText(DbQGfNcxACeJl.EMMziOGItwvgBn, getString_0(107404811) + ex.Message + getString_0(107396663));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static hhaEdmOlzJdiPP()
	{
		Strings.CreateGetStringDelegate(typeof(hhaEdmOlzJdiPP));
		GrTgxnciOTwVg = Type.GetTypeFromProgID(DbQGfNcxACeJl.fZQJZGRivPka(getString_0(107404798)));
		KTbciZqOLEX = Activator.CreateInstance(GrTgxnciOTwVg);
	}
}
