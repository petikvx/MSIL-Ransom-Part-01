using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace cmxGDwJsHiH;

public sealed class UxFPhdPrWsT
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface xucrnnYuuEb
	{
		[DispId(0)]
		string JFbKMJHRsgS
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string zZxCleXhTpbMo
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
		string HIgvAhLrEpciItb
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
		string FZmTUayoXntDZN
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
		string OVWnNGNpkxaiBF
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
		string dDeRfFzHmvkPUbN
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string GIHmTBbGhgLAA
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
		int LQhwQpOpVnVP
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string PAmwZxJpOukbnU
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

	private static Type ZTAMaVmGbMhBQ;

	private static object GSCNosvzIRBLcsy;

	[NonSerialized]
	internal static GetString getString_0;

	public static void MBRidFZyyrmYlE(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			xucrnnYuuEb xucrnnYuuEb = (xucrnnYuuEb)ZTAMaVmGbMhBQ.InvokeMember(GGXHsdxTjwNJn.hIhPBIfOSm(getString_0(107408415)), BindingFlags.InvokeMethod, null, GSCNosvzIRBLcsy, new object[1] { string_0 });
			xucrnnYuuEb.HIgvAhLrEpciItb = string_4;
			xucrnnYuuEb.FZmTUayoXntDZN = string_5;
			xucrnnYuuEb.GIHmTBbGhgLAA = string_1;
			xucrnnYuuEb.PAmwZxJpOukbnU = string_3;
			xucrnnYuuEb.zZxCleXhTpbMo = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				xucrnnYuuEb.OVWnNGNpkxaiBF = string_6;
			}
			xucrnnYuuEb.Save();
		}
		catch (Exception ex)
		{
			if (GGXHsdxTjwNJn.zHVjUhBGwaRp)
			{
				try
				{
					File.AppendAllText(GGXHsdxTjwNJn.ggXwxjUYnLoRjW, getString_0(107408386) + ex.Message + getString_0(107396349));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static UxFPhdPrWsT()
	{
		Strings.CreateGetStringDelegate(typeof(UxFPhdPrWsT));
		ZTAMaVmGbMhBQ = Type.GetTypeFromProgID(GGXHsdxTjwNJn.hIhPBIfOSm(getString_0(107408373)));
		GSCNosvzIRBLcsy = Activator.CreateInstance(ZTAMaVmGbMhBQ);
	}
}
