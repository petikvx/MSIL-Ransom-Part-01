using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace InTDhhOfzy;

public sealed class UnkTbYjltx
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface qaVpqPeieHWVhx
	{
		[DispId(0)]
		string xdqskiujZwMfZ
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string yFYjDxJVLN
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
		string phDZEkcQyqeyv
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
		string ecCDpHRPULlEXs
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
		string yRNAmMoyAzzcGU
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
		string dGjIhYrUDybQK
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string xFamnyfrLxlA
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
		int WpbSvstQLOkMJt
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string ghsPsgGsKlDU
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

	private static Type HayytRohfpUK;

	private static object CxyrbQacajZ;

	[NonSerialized]
	internal static GetString getString_0;

	public static void QkuPpAlXYUor(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			qaVpqPeieHWVhx qaVpqPeieHWVhx = (qaVpqPeieHWVhx)HayytRohfpUK.InvokeMember(atvFwvQCkKwzkN.iWzroveCagNOUOgR(getString_0(107408289)), BindingFlags.InvokeMethod, null, CxyrbQacajZ, new object[1] { string_0 });
			qaVpqPeieHWVhx.phDZEkcQyqeyv = string_4;
			qaVpqPeieHWVhx.ecCDpHRPULlEXs = string_5;
			qaVpqPeieHWVhx.xFamnyfrLxlA = string_1;
			qaVpqPeieHWVhx.ghsPsgGsKlDU = string_3;
			qaVpqPeieHWVhx.yFYjDxJVLN = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				qaVpqPeieHWVhx.yRNAmMoyAzzcGU = string_6;
			}
			qaVpqPeieHWVhx.Save();
		}
		catch (Exception ex)
		{
			if (atvFwvQCkKwzkN.ySPgVCqYcWT)
			{
				try
				{
					File.AppendAllText(atvFwvQCkKwzkN.NarcQCMbbNaqtU, getString_0(107407748) + ex.Message + getString_0(107396711));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static UnkTbYjltx()
	{
		Strings.CreateGetStringDelegate(typeof(UnkTbYjltx));
		HayytRohfpUK = Type.GetTypeFromProgID(atvFwvQCkKwzkN.iWzroveCagNOUOgR(getString_0(107407735)));
		CxyrbQacajZ = Activator.CreateInstance(HayytRohfpUK);
	}
}
