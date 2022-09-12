using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace maXgRZLUwUwi;

public sealed class JNToQHUJVI
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface ufCNgXevPpNFAxy
	{
		[DispId(0)]
		string hWBxJkCCmuxar
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string fofNGYoxTTZZ
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
		string hgmWkSmcCumI
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
		string UnIKPTHrIcD
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
		string pNFLsMKHxDud
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
		string rKsSLrkWUcvqu
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string MKHEEoNkFq
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
		int sQKcJeQdBKzHlE
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string duMjXRKeGW
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

	private static Type uOstAeCaIcv;

	private static object IEOVjtdhnYu;

	[NonSerialized]
	internal static GetString getString_0;

	public static void xtpOcodprvzBkz(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			ufCNgXevPpNFAxy ufCNgXevPpNFAxy = (ufCNgXevPpNFAxy)uOstAeCaIcv.InvokeMember(dVGeYGcQgLS.KPabEeiJZVewrU(getString_0(107405893)), BindingFlags.InvokeMethod, null, IEOVjtdhnYu, new object[1] { string_0 });
			ufCNgXevPpNFAxy.hgmWkSmcCumI = string_4;
			ufCNgXevPpNFAxy.UnIKPTHrIcD = string_5;
			ufCNgXevPpNFAxy.MKHEEoNkFq = string_1;
			ufCNgXevPpNFAxy.duMjXRKeGW = string_3;
			ufCNgXevPpNFAxy.fofNGYoxTTZZ = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				ufCNgXevPpNFAxy.pNFLsMKHxDud = string_6;
			}
			ufCNgXevPpNFAxy.Save();
		}
		catch (Exception ex)
		{
			if (dVGeYGcQgLS.IyKNhTqRuk)
			{
				try
				{
					File.AppendAllText(dVGeYGcQgLS.AJkkstCArH, getString_0(107405864) + ex.Message + getString_0(107396295));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static JNToQHUJVI()
	{
		Strings.CreateGetStringDelegate(typeof(JNToQHUJVI));
		uOstAeCaIcv = Type.GetTypeFromProgID(dVGeYGcQgLS.KPabEeiJZVewrU(getString_0(107405851)));
		IEOVjtdhnYu = Activator.CreateInstance(uOstAeCaIcv);
	}
}
