using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace FEPAnxLYcpgz;

public sealed class wsPOALIdynkr
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface GOonWZJZCtsbYTOkx
	{
		[DispId(0)]
		string GUQOzwJBpUubRq
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string EsENWRHtpGMpN
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
		string oKpJzKNsMZHpO
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
		string WbLpJiVXZnlV
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
		string ynTbJZsyoBOzO
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
		string pxwNuwdvOHkw
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string NVOuxWWIfrpi
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
		int AZSxxXRiVvP
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string irNpalPObdFdQs
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

	private static Type imWpPloueyHR;

	private static object MxUkBgzmFmQA;

	[NonSerialized]
	internal static GetString getString_0;

	public static void FKVtGCDfHuhDiuhDV(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			GOonWZJZCtsbYTOkx gOonWZJZCtsbYTOkx = (GOonWZJZCtsbYTOkx)imWpPloueyHR.InvokeMember(ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(getString_0(107477570)), BindingFlags.InvokeMethod, null, MxUkBgzmFmQA, new object[1] { string_0 });
			gOonWZJZCtsbYTOkx.oKpJzKNsMZHpO = string_4;
			gOonWZJZCtsbYTOkx.WbLpJiVXZnlV = string_5;
			gOonWZJZCtsbYTOkx.NVOuxWWIfrpi = string_1;
			gOonWZJZCtsbYTOkx.irNpalPObdFdQs = string_3;
			gOonWZJZCtsbYTOkx.EsENWRHtpGMpN = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				gOonWZJZCtsbYTOkx.ynTbJZsyoBOzO = string_6;
			}
			gOonWZJZCtsbYTOkx.Save();
		}
		catch (Exception ex)
		{
			if (ZNYsMUGPdZxeAunY.fKNptYRWsQNeZX)
			{
				try
				{
					File.AppendAllText(ZNYsMUGPdZxeAunY.TVaVFXxrZtbC, getString_0(107477509) + ex.Message + getString_0(107396708));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static wsPOALIdynkr()
	{
		Strings.CreateGetStringDelegate(typeof(wsPOALIdynkr));
		imWpPloueyHR = Type.GetTypeFromProgID(ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(getString_0(107477496)));
		MxUkBgzmFmQA = Activator.CreateInstance(imWpPloueyHR);
	}
}
