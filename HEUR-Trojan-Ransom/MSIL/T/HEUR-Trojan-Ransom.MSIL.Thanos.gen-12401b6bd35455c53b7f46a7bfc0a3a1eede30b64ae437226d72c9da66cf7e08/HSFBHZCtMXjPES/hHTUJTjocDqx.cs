using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace HSFBHZCtMXjPES;

public sealed class hHTUJTjocDqx
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface yYAeZVdqgWcqqQxn
	{
		[DispId(0)]
		string TInWlpPSOMCfn
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string EUKnMKdVUKjr
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
		string NNNQrJqIkAJcUkIPR
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
		string xTciJTakussq
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
		string vIjoQSSWTL
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
		string ujEkImOvVoyCfrMB
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string kcxbOcpjptYcAo
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
		int LXEOpDYLzlUMncZH
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string pLXAryBneWP
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

	private static Type ECjbqIFyOV;

	private static object LiOZViZUtwSgvF;

	[NonSerialized]
	internal static GetString getString_0;

	public static void YYQeOqUzbff(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			yYAeZVdqgWcqqQxn yYAeZVdqgWcqqQxn = (yYAeZVdqgWcqqQxn)ECjbqIFyOV.InvokeMember(UzNyTypkvLt.VzYMPTFsHuw(getString_0(107364488)), BindingFlags.InvokeMethod, null, LiOZViZUtwSgvF, new object[1] { string_0 });
			yYAeZVdqgWcqqQxn.NNNQrJqIkAJcUkIPR = string_4;
			yYAeZVdqgWcqqQxn.xTciJTakussq = string_5;
			yYAeZVdqgWcqqQxn.kcxbOcpjptYcAo = string_1;
			yYAeZVdqgWcqqQxn.pLXAryBneWP = string_3;
			yYAeZVdqgWcqqQxn.EUKnMKdVUKjr = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				yYAeZVdqgWcqqQxn.vIjoQSSWTL = string_6;
			}
			yYAeZVdqgWcqqQxn.Save();
		}
		catch (Exception ex)
		{
			if (UzNyTypkvLt.XtQtDAAqcssaA)
			{
				try
				{
					File.AppendAllText(UzNyTypkvLt.IuaKWfBuBpJ, getString_0(107364459) + ex.Message + getString_0(107395864));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static hHTUJTjocDqx()
	{
		Strings.CreateGetStringDelegate(typeof(hHTUJTjocDqx));
		ECjbqIFyOV = Type.GetTypeFromProgID(UzNyTypkvLt.VzYMPTFsHuw(getString_0(107364446)));
		LiOZViZUtwSgvF = Activator.CreateInstance(ECjbqIFyOV);
	}
}
