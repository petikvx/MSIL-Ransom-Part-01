using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace nVxbvhuaKzC;

public sealed class aQcWLAvevwFC
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface mnnYCXKInjY
	{
		[DispId(0)]
		string ejQTgSVfakkIct
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string ZLSKHWFoFPzrB
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
		string ETGPbJxkuSQbON
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
		string sufcmhMRGF
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
		string BsINabVCYuprQGAi
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
		string bJedgzKnduuk
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string egddLNHWnlTm
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
		int bqgVyQlVTREUFCl
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string ULIOLjEVXE
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

	private static Type hOYGtXgPDMIXB;

	private static object eFAzilXiULFkv;

	[NonSerialized]
	internal static GetString getString_0;

	public static void tnfPMikriJIhA(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			mnnYCXKInjY mnnYCXKInjY = (mnnYCXKInjY)hOYGtXgPDMIXB.InvokeMember(FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408223)), BindingFlags.InvokeMethod, null, eFAzilXiULFkv, new object[1] { string_0 });
			mnnYCXKInjY.ETGPbJxkuSQbON = string_4;
			mnnYCXKInjY.sufcmhMRGF = string_5;
			mnnYCXKInjY.egddLNHWnlTm = string_1;
			mnnYCXKInjY.ULIOLjEVXE = string_3;
			mnnYCXKInjY.ZLSKHWFoFPzrB = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				mnnYCXKInjY.BsINabVCYuprQGAi = string_6;
			}
			mnnYCXKInjY.Save();
		}
		catch (Exception ex)
		{
			if (FcnBvlzKWyQDwH.IxPlnZLdvsZB)
			{
				try
				{
					File.AppendAllText(FcnBvlzKWyQDwH.AJzDKHoaGNRf, getString_0(107408194) + ex.Message + getString_0(107396602));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static aQcWLAvevwFC()
	{
		Strings.CreateGetStringDelegate(typeof(aQcWLAvevwFC));
		hOYGtXgPDMIXB = Type.GetTypeFromProgID(FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408117)));
		eFAzilXiULFkv = Activator.CreateInstance(hOYGtXgPDMIXB);
	}
}
