using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace sWduCclqEzKrM;

public sealed class GCgryWJGqPqrqa
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface uWNSquWqzD
	{
		[DispId(0)]
		string MLvnCZKmmDbwl
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string LvgfdHsDnJYRd
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
		string FEUEUnrXKhVqnX
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
		string pIttYPyhDEsCLe
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
		string RWdIPrRWKYRGF
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
		string VebAtYOoGCQk
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string bvhjqixVabNrP
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
		int LVlBxpBFBxLHBGW
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string okYiYUYIVgzUZYb
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

	private static Type lbTKcruAUYggW;

	private static object kWlnKYuuBhM;

	[NonSerialized]
	internal static GetString getString_0;

	public static void pCqulEGdJctLP(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			uWNSquWqzD uWNSquWqzD = (uWNSquWqzD)lbTKcruAUYggW.InvokeMember(wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107376952)), BindingFlags.InvokeMethod, null, kWlnKYuuBhM, new object[1] { string_0 });
			uWNSquWqzD.FEUEUnrXKhVqnX = string_4;
			uWNSquWqzD.pIttYPyhDEsCLe = string_5;
			uWNSquWqzD.bvhjqixVabNrP = string_1;
			uWNSquWqzD.okYiYUYIVgzUZYb = string_3;
			uWNSquWqzD.LvgfdHsDnJYRd = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				uWNSquWqzD.RWdIPrRWKYRGF = string_6;
			}
			uWNSquWqzD.Save();
		}
		catch (Exception ex)
		{
			if (wJkbnIWOteHAMM.nCZIbbbLUfspycLk)
			{
				try
				{
					File.AppendAllText(wJkbnIWOteHAMM.VjgrxEUFvvHY, getString_0(107376923) + ex.Message + getString_0(107396388));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static GCgryWJGqPqrqa()
	{
		Strings.CreateGetStringDelegate(typeof(GCgryWJGqPqrqa));
		lbTKcruAUYggW = Type.GetTypeFromProgID(wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107377358)));
		kWlnKYuuBhM = Activator.CreateInstance(lbTKcruAUYggW);
	}
}
