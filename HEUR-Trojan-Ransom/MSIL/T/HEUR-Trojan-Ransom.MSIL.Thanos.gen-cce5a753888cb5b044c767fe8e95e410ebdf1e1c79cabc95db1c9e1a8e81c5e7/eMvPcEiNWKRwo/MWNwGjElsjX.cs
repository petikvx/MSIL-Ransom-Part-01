using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace eMvPcEiNWKRwo;

public sealed class MWNwGjElsjX
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface vtnVFCpxNM
	{
		[DispId(0)]
		string tLztTNCcODm
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string QwqDBIFyyku
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
		string PKVyhmPtya
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
		string fIRIiHQWrHsz
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
		string cqdCEBRyozX
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
		string RecaXpGRBxVMvx
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string MaNtYXmJaKdJd
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
		int XYFDHBpSzYQ
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string dRBFNbOHpi
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

	private static Type UUFHSgYmIJOyT;

	private static object FnVhfgGJWrdaDj;

	[NonSerialized]
	internal static GetString getString_0;

	public static void hhBQtqSCgPPkQmry(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			vtnVFCpxNM vtnVFCpxNM = (vtnVFCpxNM)UUFHSgYmIJOyT.InvokeMember(NXVLxNyJvZLW.tzJESwPzibp(getString_0(107406797)), BindingFlags.InvokeMethod, null, FnVhfgGJWrdaDj, new object[1] { string_0 });
			vtnVFCpxNM.PKVyhmPtya = string_4;
			vtnVFCpxNM.fIRIiHQWrHsz = string_5;
			vtnVFCpxNM.MaNtYXmJaKdJd = string_1;
			vtnVFCpxNM.dRBFNbOHpi = string_3;
			vtnVFCpxNM.QwqDBIFyyku = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				vtnVFCpxNM.cqdCEBRyozX = string_6;
			}
			vtnVFCpxNM.Save();
		}
		catch (Exception ex)
		{
			if (NXVLxNyJvZLW.ZdcvQmUKIcPe)
			{
				try
				{
					File.AppendAllText(NXVLxNyJvZLW.jYzmyFxkGGuJi, getString_0(107406800) + ex.Message + getString_0(107397132));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static MWNwGjElsjX()
	{
		Strings.CreateGetStringDelegate(typeof(MWNwGjElsjX));
		UUFHSgYmIJOyT = Type.GetTypeFromProgID(NXVLxNyJvZLW.tzJESwPzibp(getString_0(107406211)));
		FnVhfgGJWrdaDj = Activator.CreateInstance(UUFHSgYmIJOyT);
	}
}
