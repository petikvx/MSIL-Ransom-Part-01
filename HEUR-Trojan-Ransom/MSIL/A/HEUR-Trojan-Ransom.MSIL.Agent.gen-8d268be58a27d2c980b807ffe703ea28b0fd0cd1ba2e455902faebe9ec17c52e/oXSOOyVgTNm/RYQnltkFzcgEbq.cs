using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace oXSOOyVgTNm;

public sealed class RYQnltkFzcgEbq
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface aTSGjZHxVtDgkAGx
	{
		[DispId(0)]
		string mfSxnDhvtCeU
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string yLxPwojZTOspkbx
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
		string sUKIQVOzIMXLnhL
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
		string PCZbaThlgFCH
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
		string pifslQktwQJE
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
		string qyHNPCpJteFnTY
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string vdxTvNLHCLBYgr
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
		int ePaegSscjhmeTP
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string FoAILcQenyvHxlB
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

	private static Type YEpHhkETRFG;

	private static object YDWLRFcOKIUXolG;

	[NonSerialized]
	internal static GetString getString_0;

	public static void KrvmONpoByr(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			aTSGjZHxVtDgkAGx aTSGjZHxVtDgkAGx = (aTSGjZHxVtDgkAGx)YEpHhkETRFG.InvokeMember(NuHMiFuRoVNiZNRl.VrSebPGaWq(getString_0(107399710)), BindingFlags.InvokeMethod, null, YDWLRFcOKIUXolG, new object[1] { string_0 });
			aTSGjZHxVtDgkAGx.sUKIQVOzIMXLnhL = string_4;
			aTSGjZHxVtDgkAGx.PCZbaThlgFCH = string_5;
			aTSGjZHxVtDgkAGx.vdxTvNLHCLBYgr = string_1;
			aTSGjZHxVtDgkAGx.FoAILcQenyvHxlB = string_3;
			aTSGjZHxVtDgkAGx.yLxPwojZTOspkbx = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				aTSGjZHxVtDgkAGx.pifslQktwQJE = string_6;
			}
			aTSGjZHxVtDgkAGx.Save();
		}
		catch (Exception ex)
		{
			if (NuHMiFuRoVNiZNRl.sfIQAmNvQu)
			{
				try
				{
					File.AppendAllText(NuHMiFuRoVNiZNRl.DFeZKWhzZEN, getString_0(107399681) + ex.Message + getString_0(107396704));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static RYQnltkFzcgEbq()
	{
		Strings.CreateGetStringDelegate(typeof(RYQnltkFzcgEbq));
		YEpHhkETRFG = Type.GetTypeFromProgID(NuHMiFuRoVNiZNRl.VrSebPGaWq(getString_0(107399124)));
		YDWLRFcOKIUXolG = Activator.CreateInstance(YEpHhkETRFG);
	}
}
