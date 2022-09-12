using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace zvenNXaGjQywAfJS;

public sealed class uUOPyKNnMHr
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface jTQzKfFkcMXlJ
	{
		[DispId(0)]
		string HvDuLTYhNEiS
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string CUYBiqqSBXC
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
		string SKqHzdzpvzRaUB
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
		string KXasEOsKczHyRv
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
		string qWBSBYmAyIpnc
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
		string xkbZDFtvpHRLaSHN
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string oMEHlRtdDHHMZO
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
		int DoxFZUObusN
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string orlDmnBGIjO
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

	private static Type MdsXBHwkQKEMB;

	private static object RhABOGDIMoZiBv;

	[NonSerialized]
	internal static GetString getString_0;

	public static void WKhUeANjSvKj(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			jTQzKfFkcMXlJ jTQzKfFkcMXlJ = (jTQzKfFkcMXlJ)MdsXBHwkQKEMB.InvokeMember(AFNAiOPxfKG.KfBmpaPpRy(getString_0(107407711)), BindingFlags.InvokeMethod, null, RhABOGDIMoZiBv, new object[1] { string_0 });
			jTQzKfFkcMXlJ.SKqHzdzpvzRaUB = string_4;
			jTQzKfFkcMXlJ.KXasEOsKczHyRv = string_5;
			jTQzKfFkcMXlJ.oMEHlRtdDHHMZO = string_1;
			jTQzKfFkcMXlJ.orlDmnBGIjO = string_3;
			jTQzKfFkcMXlJ.CUYBiqqSBXC = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				jTQzKfFkcMXlJ.qWBSBYmAyIpnc = string_6;
			}
			jTQzKfFkcMXlJ.Save();
		}
		catch (Exception ex)
		{
			if (AFNAiOPxfKG.zObGGMIceXoVAZ)
			{
				try
				{
					File.AppendAllText(AFNAiOPxfKG.nzrzeINFdi, getString_0(107407682) + ex.Message + getString_0(107396641));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static uUOPyKNnMHr()
	{
		Strings.CreateGetStringDelegate(typeof(uUOPyKNnMHr));
		MdsXBHwkQKEMB = Type.GetTypeFromProgID(AFNAiOPxfKG.KfBmpaPpRy(getString_0(107407669)));
		RhABOGDIMoZiBv = Activator.CreateInstance(MdsXBHwkQKEMB);
	}
}
