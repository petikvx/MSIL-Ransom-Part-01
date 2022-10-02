using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace FEPAnxLYcpgz;

public sealed class UYeIhBmvJLkBpE
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface GOonWZJZCtsbYTOkx
	{
		[DispId(0)]
		string XkIrbDIDPSJJENLc
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string CayApkweufG
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
		string iQBFkqMODeptcmv
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
		string VoaCVDzADPyx
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
		string cxHjpLQMfanmLfI
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
		string mzYSzJVdMPY
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string ampGWZAOhMwmZW
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
		int NTEtKtJimyghlE
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string HWEHeBhMslmrBTBq
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

	public static void AhZTotZHOGNa(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			GOonWZJZCtsbYTOkx gOonWZJZCtsbYTOkx = (GOonWZJZCtsbYTOkx)imWpPloueyHR.InvokeMember(frAELqEtncDC.aTyvnaQgFklB(getString_0(107475643)), BindingFlags.InvokeMethod, null, MxUkBgzmFmQA, new object[1] { string_0 });
			gOonWZJZCtsbYTOkx.iQBFkqMODeptcmv = string_4;
			gOonWZJZCtsbYTOkx.VoaCVDzADPyx = string_5;
			gOonWZJZCtsbYTOkx.ampGWZAOhMwmZW = string_1;
			gOonWZJZCtsbYTOkx.HWEHeBhMslmrBTBq = string_3;
			gOonWZJZCtsbYTOkx.CayApkweufG = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				gOonWZJZCtsbYTOkx.cxHjpLQMfanmLfI = string_6;
			}
			gOonWZJZCtsbYTOkx.Save();
		}
		catch (Exception ex)
		{
			if (frAELqEtncDC.fKNptYRWsQNeZX)
			{
				try
				{
					File.AppendAllText(frAELqEtncDC.TVaVFXxrZtbC, getString_0(107475614) + ex.Message + getString_0(107396320));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static UYeIhBmvJLkBpE()
	{
		Strings.CreateGetStringDelegate(typeof(UYeIhBmvJLkBpE));
		imWpPloueyHR = Type.GetTypeFromProgID(frAELqEtncDC.aTyvnaQgFklB(getString_0(107475569)));
		MxUkBgzmFmQA = Activator.CreateInstance(imWpPloueyHR);
	}
}
