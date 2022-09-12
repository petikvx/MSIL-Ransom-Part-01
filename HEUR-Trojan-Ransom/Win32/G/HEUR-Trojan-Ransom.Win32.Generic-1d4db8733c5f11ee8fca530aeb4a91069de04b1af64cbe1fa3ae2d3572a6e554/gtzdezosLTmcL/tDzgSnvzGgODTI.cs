using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gtzdezosLTmcL;

public sealed class tDzgSnvzGgODTI
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface VFROlEJFhaOrcij
	{
		[DispId(0)]
		string HjNvnWVFdZHpfmaTb
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string OneLeCdhrLKOM
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
		string TDemREmhtVFFUN
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
		string SNlLMfruQdQj
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
		string DeVHtMLPJnmoM
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
		string DmniTycbCVatmz
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string QssUAOEIes
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
		int fewROWExsxxU
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string OvvilXzLHZCe
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

	private static Type uPMqzVevvx;

	private static object bghCHaSkRPH;

	[NonSerialized]
	internal static GetString getString_0;

	public static void FyHAzbGBOBG(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			VFROlEJFhaOrcij vFROlEJFhaOrcij = (VFROlEJFhaOrcij)uPMqzVevvx.InvokeMember(pjsEsrnLXK.rZFwMCmAYamD(getString_0(107365809)), BindingFlags.InvokeMethod, null, bghCHaSkRPH, new object[1] { string_0 });
			vFROlEJFhaOrcij.TDemREmhtVFFUN = string_4;
			vFROlEJFhaOrcij.SNlLMfruQdQj = string_5;
			vFROlEJFhaOrcij.QssUAOEIes = string_1;
			vFROlEJFhaOrcij.OvvilXzLHZCe = string_3;
			vFROlEJFhaOrcij.OneLeCdhrLKOM = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				vFROlEJFhaOrcij.DeVHtMLPJnmoM = string_6;
			}
			vFROlEJFhaOrcij.Save();
		}
		catch (Exception ex)
		{
			if (pjsEsrnLXK.EgSuBjaBcbD)
			{
				try
				{
					File.AppendAllText(pjsEsrnLXK.wWeASlndaLw, getString_0(107365780) + ex.Message + getString_0(107396766));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static tDzgSnvzGgODTI()
	{
		Strings.CreateGetStringDelegate(typeof(tDzgSnvzGgODTI));
		uPMqzVevvx = Type.GetTypeFromProgID(pjsEsrnLXK.rZFwMCmAYamD(getString_0(107365703)));
		bghCHaSkRPH = Activator.CreateInstance(uPMqzVevvx);
	}
}
