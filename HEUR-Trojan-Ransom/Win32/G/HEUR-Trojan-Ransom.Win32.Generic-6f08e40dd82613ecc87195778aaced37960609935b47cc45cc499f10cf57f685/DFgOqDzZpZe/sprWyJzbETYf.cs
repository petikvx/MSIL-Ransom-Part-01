using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace DFgOqDzZpZe;

public sealed class sprWyJzbETYf
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface MTVuTkffvC
	{
		[DispId(0)]
		string cbGDcmSdgLzi
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string QJxUJXtUcgKSbD
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
		string ICEPYkjrGpKsH
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
		string ICADKzmJrEYnAfPw
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
		string fVQSSzIhiVJMduK
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
		string BhCujCcfXXF
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string vebmFhnbuTbWxD
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
		int VpDzbZMUPSTQ
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string DkeBChTnQlGSba
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

	private static Type bpaYAoNPmwFQW;

	private static object JGcoRCDPKrJt;

	[NonSerialized]
	internal static GetString getString_0;

	public static void dxmlUtrponbqr(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			MTVuTkffvC mTVuTkffvC = (MTVuTkffvC)bpaYAoNPmwFQW.InvokeMember(thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(getString_0(107399948)), BindingFlags.InvokeMethod, null, JGcoRCDPKrJt, new object[1] { string_0 });
			mTVuTkffvC.ICEPYkjrGpKsH = string_4;
			mTVuTkffvC.ICADKzmJrEYnAfPw = string_5;
			mTVuTkffvC.vebmFhnbuTbWxD = string_1;
			mTVuTkffvC.DkeBChTnQlGSba = string_3;
			mTVuTkffvC.QJxUJXtUcgKSbD = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				mTVuTkffvC.fVQSSzIhiVJMduK = string_6;
			}
			mTVuTkffvC.Save();
		}
		catch (Exception ex)
		{
			if (thNrRmMEuvdxhHm.MvyzXvhzMsIEWT)
			{
				try
				{
					File.AppendAllText(thNrRmMEuvdxhHm.knClGxGTQzcKgW, getString_0(107399919) + ex.Message + getString_0(107395979));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static sprWyJzbETYf()
	{
		Strings.CreateGetStringDelegate(typeof(sprWyJzbETYf));
		bpaYAoNPmwFQW = Type.GetTypeFromProgID(thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(getString_0(107399906)));
		JGcoRCDPKrJt = Activator.CreateInstance(bpaYAoNPmwFQW);
	}
}
