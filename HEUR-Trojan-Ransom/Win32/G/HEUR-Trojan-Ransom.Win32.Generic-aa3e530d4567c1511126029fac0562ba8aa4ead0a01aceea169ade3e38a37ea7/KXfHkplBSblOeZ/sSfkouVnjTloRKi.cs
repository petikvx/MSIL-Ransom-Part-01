using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace KXfHkplBSblOeZ;

public sealed class sSfkouVnjTloRKi
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface WbqKBaWhrXkoU
	{
		[DispId(0)]
		string QRaKSGEnYuxGFcn
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string UueWXVkSMuWb
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
		string SGbQLVAotBDR
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
		string clVCJsWmjBZqEb
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
		string zhkKEdzyjHeBdu
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
		string dbceqcfRFcwXqV
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string QCGcYbwkKPVXz
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
		int YcQdgtvXRKCf
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string dDwajqykJXjs
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

	private static Type MgsXGCUQHT;

	private static object eAnIkJLehZTGT;

	[NonSerialized]
	internal static GetString getString_0;

	public static void NqwpFgBPUpN(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			WbqKBaWhrXkoU wbqKBaWhrXkoU = (WbqKBaWhrXkoU)MgsXGCUQHT.InvokeMember(NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107402808)), BindingFlags.InvokeMethod, null, eAnIkJLehZTGT, new object[1] { string_0 });
			wbqKBaWhrXkoU.SGbQLVAotBDR = string_4;
			wbqKBaWhrXkoU.clVCJsWmjBZqEb = string_5;
			wbqKBaWhrXkoU.QCGcYbwkKPVXz = string_1;
			wbqKBaWhrXkoU.dDwajqykJXjs = string_3;
			wbqKBaWhrXkoU.UueWXVkSMuWb = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				wbqKBaWhrXkoU.zhkKEdzyjHeBdu = string_6;
			}
			wbqKBaWhrXkoU.Save();
		}
		catch (Exception ex)
		{
			if (NiISdmMYRfnXGiX.SsCiUkhFaPaV)
			{
				try
				{
					File.AppendAllText(NiISdmMYRfnXGiX.eBcYzZJOdxm, getString_0(107402779) + ex.Message + getString_0(107396824));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static sSfkouVnjTloRKi()
	{
		Strings.CreateGetStringDelegate(typeof(sSfkouVnjTloRKi));
		MgsXGCUQHT = Type.GetTypeFromProgID(NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107402190)));
		eAnIkJLehZTGT = Activator.CreateInstance(MgsXGCUQHT);
	}
}
