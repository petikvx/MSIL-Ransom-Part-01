using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jDlAujUelC;

public sealed class UyjygnUfHQfS
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface iQIqSChwfbT
	{
		[DispId(0)]
		string ycpclINlESbFce
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string SioXFfFLjNcx
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
		string tDhVJVuLElEQl
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
		string tAdgCkHqQVo
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
		string LeCVdpQcQSjjiDN
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
		string ZPWlPjfmKszpI
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string QOLjZfmbBy
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
		int OCFWGsSqwgjPdhc
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string WElrKZKDhMRye
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

	private static Type DkykoLETVsHxJ;

	private static object tAUVEHKbeYzom;

	[NonSerialized]
	internal static GetString getString_0;

	public static void XLrFfRDDRRcN(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			iQIqSChwfbT iQIqSChwfbT = (iQIqSChwfbT)DkykoLETVsHxJ.InvokeMember(hNCHegfceoe.UwCpksGCJZfb(getString_0(107352542)), BindingFlags.InvokeMethod, null, tAUVEHKbeYzom, new object[1] { string_0 });
			iQIqSChwfbT.tDhVJVuLElEQl = string_4;
			iQIqSChwfbT.tAdgCkHqQVo = string_5;
			iQIqSChwfbT.QOLjZfmbBy = string_1;
			iQIqSChwfbT.WElrKZKDhMRye = string_3;
			iQIqSChwfbT.SioXFfFLjNcx = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				iQIqSChwfbT.LeCVdpQcQSjjiDN = string_6;
			}
			iQIqSChwfbT.Save();
		}
		catch (Exception ex)
		{
			if (hNCHegfceoe.LbhjvcCDDsZLYlccs)
			{
				try
				{
					File.AppendAllText(hNCHegfceoe.KymHhFbNcwDYA, getString_0(107352513) + ex.Message + getString_0(107396628));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static UyjygnUfHQfS()
	{
		Strings.CreateGetStringDelegate(typeof(UyjygnUfHQfS));
		DkykoLETVsHxJ = Type.GetTypeFromProgID(hNCHegfceoe.UwCpksGCJZfb(getString_0(107352436)));
		tAUVEHKbeYzom = Activator.CreateInstance(DkykoLETVsHxJ);
	}
}
