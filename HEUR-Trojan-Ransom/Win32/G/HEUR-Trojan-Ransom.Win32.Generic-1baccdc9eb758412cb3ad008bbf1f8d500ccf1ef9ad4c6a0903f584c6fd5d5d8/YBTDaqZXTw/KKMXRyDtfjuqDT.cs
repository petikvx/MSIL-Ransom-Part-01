using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace YBTDaqZXTw;

public sealed class KKMXRyDtfjuqDT
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface ZNwxIfGCPdi
	{
		[DispId(0)]
		string buBqcxLvghy
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string tEnjZJaHmUxe
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
		string KBhMXCYJtJ
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
		string dnHnvvFvvwfZGSs
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
		string dkoPjDgtCDBa
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
		string fPqnNuqZthKceb
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string KMPCTXlhvtZtG
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
		int oLpvDllGzdg
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string UlHlgdMihpK
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

	private static Type zJIiIaPybogNW;

	private static object GmzdvQoMLLAq;

	[NonSerialized]
	internal static GetString getString_0;

	public static void KfgJttiXhPPuPC(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			ZNwxIfGCPdi zNwxIfGCPdi = (ZNwxIfGCPdi)zJIiIaPybogNW.InvokeMember(fdvkylEGapkbT.UMsFeqgmECpmMQw(getString_0(107404560)), BindingFlags.InvokeMethod, null, GmzdvQoMLLAq, new object[1] { string_0 });
			zNwxIfGCPdi.KBhMXCYJtJ = string_4;
			zNwxIfGCPdi.dnHnvvFvvwfZGSs = string_5;
			zNwxIfGCPdi.KMPCTXlhvtZtG = string_1;
			zNwxIfGCPdi.UlHlgdMihpK = string_3;
			zNwxIfGCPdi.tEnjZJaHmUxe = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				zNwxIfGCPdi.dkoPjDgtCDBa = string_6;
			}
			zNwxIfGCPdi.Save();
		}
		catch (Exception ex)
		{
			if (fdvkylEGapkbT.TfpcYTfYwiZ)
			{
				try
				{
					File.AppendAllText(fdvkylEGapkbT.XTpFtiqHigTwzn, getString_0(107404499) + ex.Message + getString_0(107396635));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static KKMXRyDtfjuqDT()
	{
		Strings.CreateGetStringDelegate(typeof(KKMXRyDtfjuqDT));
		zJIiIaPybogNW = Type.GetTypeFromProgID(fdvkylEGapkbT.UMsFeqgmECpmMQw(getString_0(107404486)));
		GmzdvQoMLLAq = Activator.CreateInstance(zJIiIaPybogNW);
	}
}
