using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace RshJmeUGgeNp;

public sealed class eELJxAJwyCTpZ
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface HcyvCPrSXGdtQ
	{
		[DispId(0)]
		string GeCkygMnkUXSiv
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string nhcSEtxshYBh
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
		string MZRJIiryQRKHWbh
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
		string LsOektuaYsrQmzAMY
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
		string SiCGhFcUkYuIad
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
		string fiGzrNmKGb
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string OMopssDcRLzFfEa
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
		int HmIImfLHoukJxl
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string vqBgvbqrcZXx
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

	private static Type dQzrqlKSRmjKvdA;

	private static object krZwUjJQqxXxXIV;

	[NonSerialized]
	internal static GetString getString_0;

	public static void FFSVDKzhlnoPENI(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			HcyvCPrSXGdtQ hcyvCPrSXGdtQ = (HcyvCPrSXGdtQ)dQzrqlKSRmjKvdA.InvokeMember(RvpNXHMAnDGj.SkTISxbocVBV(getString_0(107402500)), BindingFlags.InvokeMethod, null, krZwUjJQqxXxXIV, new object[1] { string_0 });
			hcyvCPrSXGdtQ.MZRJIiryQRKHWbh = string_4;
			hcyvCPrSXGdtQ.LsOektuaYsrQmzAMY = string_5;
			hcyvCPrSXGdtQ.OMopssDcRLzFfEa = string_1;
			hcyvCPrSXGdtQ.vqBgvbqrcZXx = string_3;
			hcyvCPrSXGdtQ.nhcSEtxshYBh = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				hcyvCPrSXGdtQ.SiCGhFcUkYuIad = string_6;
			}
			hcyvCPrSXGdtQ.Save();
		}
		catch (Exception ex)
		{
			if (RvpNXHMAnDGj.ypofoMoLMAIop)
			{
				try
				{
					File.AppendAllText(RvpNXHMAnDGj.xXiTPiYVwRAzXZ, getString_0(107402471) + ex.Message + getString_0(107396328));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static eELJxAJwyCTpZ()
	{
		Strings.CreateGetStringDelegate(typeof(eELJxAJwyCTpZ));
		dQzrqlKSRmjKvdA = Type.GetTypeFromProgID(RvpNXHMAnDGj.SkTISxbocVBV(getString_0(107402970)));
		krZwUjJQqxXxXIV = Activator.CreateInstance(dQzrqlKSRmjKvdA);
	}
}
