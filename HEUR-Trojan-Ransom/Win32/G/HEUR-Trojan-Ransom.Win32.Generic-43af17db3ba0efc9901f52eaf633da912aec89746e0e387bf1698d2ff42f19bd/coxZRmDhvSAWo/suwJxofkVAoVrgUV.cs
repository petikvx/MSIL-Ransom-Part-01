using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

public sealed class suwJxofkVAoVrgUV
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface TpYhUzGMPYfh
	{
		[DispId(0)]
		string ONIoECQGflBPq
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string ATAtnOjaFsts
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
		string gVnHnBtNuMe
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
		string FCHuHNimOlNvz
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
		string NsVzjhHfvHfhAa
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
		string eIFMepNvXQtEcjCd
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string OjbpTrenBunrr
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
		int KOJTCAEbYMxeN
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string SaTBoivMFzx
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

	private static Type kdyVwBNVXTrR;

	private static object cqgnKeqqeYa;

	[NonSerialized]
	internal static GetString getString_0;

	public static void EvzDqbYLnOHZvp(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			TpYhUzGMPYfh tpYhUzGMPYfh = (TpYhUzGMPYfh)kdyVwBNVXTrR.InvokeMember(aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107398424)), BindingFlags.InvokeMethod, null, cqgnKeqqeYa, new object[1] { string_0 });
			tpYhUzGMPYfh.gVnHnBtNuMe = string_4;
			tpYhUzGMPYfh.FCHuHNimOlNvz = string_5;
			tpYhUzGMPYfh.OjbpTrenBunrr = string_1;
			tpYhUzGMPYfh.SaTBoivMFzx = string_3;
			tpYhUzGMPYfh.ATAtnOjaFsts = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				tpYhUzGMPYfh.NsVzjhHfvHfhAa = string_6;
			}
			tpYhUzGMPYfh.Save();
		}
		catch (Exception ex)
		{
			if (aSOyqwTwiifNb.CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(aSOyqwTwiifNb.dtHHyJMWMTcTg, getString_0(107398427) + ex.Message + getString_0(107395860));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static suwJxofkVAoVrgUV()
	{
		Strings.CreateGetStringDelegate(typeof(suwJxofkVAoVrgUV));
		kdyVwBNVXTrR = Type.GetTypeFromProgID(aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107398862)));
		cqgnKeqqeYa = Activator.CreateInstance(kdyVwBNVXTrR);
	}
}
