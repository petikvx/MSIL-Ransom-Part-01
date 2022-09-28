using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace WEoqBCtavg;

public sealed class RueRAfiZTSdiX
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface QoWvUqYEHXuw
	{
		[DispId(0)]
		string rsBofskiDZyLny
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string WUgQOSznqRjmH
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
		string VVlZMoxStCGstH
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
		string KYtLMbtPxFXfhEb
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
		string apzJwlGdCIz
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
		string PBVefRZkgLDjv
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string UJvNSKCWnsGduji
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
		int hvzNrcZPDbfP
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string SWLlBMRIynNVRSg
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

	private static Type KTeHzRedJgmRlum;

	private static object ziSDzIyqSgpQp;

	[NonSerialized]
	internal static GetString getString_0;

	public static void WtFiofyLIUofm(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			QoWvUqYEHXuw qoWvUqYEHXuw = (QoWvUqYEHXuw)KTeHzRedJgmRlum.InvokeMember(TwRTxDxfshC.czGbdVLSgBt(getString_0(107364586)), BindingFlags.InvokeMethod, null, ziSDzIyqSgpQp, new object[1] { string_0 });
			qoWvUqYEHXuw.VVlZMoxStCGstH = string_4;
			qoWvUqYEHXuw.KYtLMbtPxFXfhEb = string_5;
			qoWvUqYEHXuw.UJvNSKCWnsGduji = string_1;
			qoWvUqYEHXuw.SWLlBMRIynNVRSg = string_3;
			qoWvUqYEHXuw.WUgQOSznqRjmH = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				qoWvUqYEHXuw.apzJwlGdCIz = string_6;
			}
			qoWvUqYEHXuw.Save();
		}
		catch (Exception ex)
		{
			if (TwRTxDxfshC.OcJOCuetrNWE)
			{
				try
				{
					File.AppendAllText(TwRTxDxfshC.eWxeBKmemNzo, getString_0(107365069) + ex.Message + getString_0(107397142));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static RueRAfiZTSdiX()
	{
		Strings.CreateGetStringDelegate(typeof(RueRAfiZTSdiX));
		KTeHzRedJgmRlum = Type.GetTypeFromProgID(TwRTxDxfshC.czGbdVLSgBt(getString_0(107364992)));
		ziSDzIyqSgpQp = Activator.CreateInstance(KTeHzRedJgmRlum);
	}
}
