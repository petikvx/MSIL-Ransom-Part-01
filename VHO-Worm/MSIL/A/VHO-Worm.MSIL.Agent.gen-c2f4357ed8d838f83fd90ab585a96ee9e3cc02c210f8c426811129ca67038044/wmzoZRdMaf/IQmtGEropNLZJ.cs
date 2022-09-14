using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wmzoZRdMaf;

public sealed class IQmtGEropNLZJ
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface LhURxtukqncm
	{
		[DispId(0)]
		string VhLEJsfLjcbTzLWOJ
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string MSjAeYcDnKp
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
		string tkJmtjAbqLfFWn
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
		string NutHICKvbD
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
		string KkSgpQNnVNuLMf
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
		string tDUvchtZfvZvznc
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string rWfuBvdyXWRlR
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
		int HOztRzUQVMynZHde
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string JdnIvnzYlwiWtQ
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

	private static Type vMWEXfAXbKgF;

	private static object BGEhkHonaDEn;

	[NonSerialized]
	internal static GetString getString_0;

	public static void GXmdUnCikbQcw(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			LhURxtukqncm lhURxtukqncm = (LhURxtukqncm)vMWEXfAXbKgF.InvokeMember(IuKjJmfJcVBFA.dOioDTBjWKE(getString_0(107403255)), BindingFlags.InvokeMethod, null, BGEhkHonaDEn, new object[1] { string_0 });
			lhURxtukqncm.tkJmtjAbqLfFWn = string_4;
			lhURxtukqncm.NutHICKvbD = string_5;
			lhURxtukqncm.rWfuBvdyXWRlR = string_1;
			lhURxtukqncm.JdnIvnzYlwiWtQ = string_3;
			lhURxtukqncm.MSjAeYcDnKp = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				lhURxtukqncm.KkSgpQNnVNuLMf = string_6;
			}
			lhURxtukqncm.Save();
		}
		catch (Exception ex)
		{
			if (IuKjJmfJcVBFA.JkprrzFPchvjDH)
			{
				try
				{
					File.AppendAllText(IuKjJmfJcVBFA.AIOBtLgIwjoLs, getString_0(107402714) + ex.Message + getString_0(107396811));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static IQmtGEropNLZJ()
	{
		Strings.CreateGetStringDelegate(typeof(IQmtGEropNLZJ));
		vMWEXfAXbKgF = Type.GetTypeFromProgID(IuKjJmfJcVBFA.dOioDTBjWKE(getString_0(107402637)));
		BGEhkHonaDEn = Activator.CreateInstance(vMWEXfAXbKgF);
	}
}
