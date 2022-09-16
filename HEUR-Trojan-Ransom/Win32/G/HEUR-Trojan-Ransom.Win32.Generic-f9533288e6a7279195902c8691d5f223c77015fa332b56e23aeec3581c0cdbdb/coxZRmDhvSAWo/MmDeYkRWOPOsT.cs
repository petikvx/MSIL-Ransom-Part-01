using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

public sealed class MmDeYkRWOPOsT
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface TpYhUzGMPYfh
	{
		[DispId(0)]
		string ejawTmnVdUbuf
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string lQhWBLAMIuxYxz
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
		string nREMIwPqjmxJ
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
		string DLNLpdrmmkIGM
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
		string XAujrVKJmtGbnwwd
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
		string lpnZkLkVaJJCHI
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string GXFsqOQRlNiWf
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
		int ePncoGeafPHCxg
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string DWkByDLURxIfG
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

	public static void rXfQNjqsTzg(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			TpYhUzGMPYfh tpYhUzGMPYfh = (TpYhUzGMPYfh)kdyVwBNVXTrR.InvokeMember(GhAMvbuoccW.PbsdnvfpwWRvGCs(getString_0(107400200)), BindingFlags.InvokeMethod, null, cqgnKeqqeYa, new object[1] { string_0 });
			tpYhUzGMPYfh.nREMIwPqjmxJ = string_4;
			tpYhUzGMPYfh.DLNLpdrmmkIGM = string_5;
			tpYhUzGMPYfh.GXFsqOQRlNiWf = string_1;
			tpYhUzGMPYfh.DWkByDLURxIfG = string_3;
			tpYhUzGMPYfh.lQhWBLAMIuxYxz = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				tpYhUzGMPYfh.XAujrVKJmtGbnwwd = string_6;
			}
			tpYhUzGMPYfh.Save();
		}
		catch (Exception ex)
		{
			if (GhAMvbuoccW.CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(GhAMvbuoccW.dtHHyJMWMTcTg, getString_0(107400139) + ex.Message + getString_0(107395766));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static MmDeYkRWOPOsT()
	{
		Strings.CreateGetStringDelegate(typeof(MmDeYkRWOPOsT));
		kdyVwBNVXTrR = Type.GetTypeFromProgID(GhAMvbuoccW.PbsdnvfpwWRvGCs(getString_0(107400126)));
		cqgnKeqqeYa = Activator.CreateInstance(kdyVwBNVXTrR);
	}
}
