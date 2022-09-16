using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace drXPuaQNZPOSPCS;

public sealed class BAoKwiwVkX
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface dIPmkiFJGPn
	{
		[DispId(0)]
		string NYXgaOdygs
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string lUjxNebaMgmb
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
		string ZcUmsoWcpTWqi
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
		string VInHCplVdqoNgI
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
		string MdPXFUuXZrWZ
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
		string QsRSkmqqPjA
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string tcRRUQmdyaReE
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
		int LEuAqBZAKQzg
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string QHgtyVxAWwDqW
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

	private static Type UizJzkbIhwKiQ;

	private static object CoHWuEJXoSkB;

	[NonSerialized]
	internal static GetString getString_0;

	public static void ItiWJIVSKvc(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			dIPmkiFJGPn dIPmkiFJGPn = (dIPmkiFJGPn)UizJzkbIhwKiQ.InvokeMember(OBRXLDkWsVk.SptLhhxIveIbH(getString_0(107400656)), BindingFlags.InvokeMethod, null, CoHWuEJXoSkB, new object[1] { string_0 });
			dIPmkiFJGPn.ZcUmsoWcpTWqi = string_4;
			dIPmkiFJGPn.VInHCplVdqoNgI = string_5;
			dIPmkiFJGPn.tcRRUQmdyaReE = string_1;
			dIPmkiFJGPn.QHgtyVxAWwDqW = string_3;
			dIPmkiFJGPn.lUjxNebaMgmb = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				dIPmkiFJGPn.MdPXFUuXZrWZ = string_6;
			}
			dIPmkiFJGPn.Save();
		}
		catch (Exception ex)
		{
			if (OBRXLDkWsVk.ZQkgwClpBNRNGiD)
			{
				try
				{
					File.AppendAllText(OBRXLDkWsVk.LtQdcjdFVaR, getString_0(107400627) + ex.Message + getString_0(107396661));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static BAoKwiwVkX()
	{
		Strings.CreateGetStringDelegate(typeof(BAoKwiwVkX));
		UizJzkbIhwKiQ = Type.GetTypeFromProgID(OBRXLDkWsVk.SptLhhxIveIbH(getString_0(107400102)));
		CoHWuEJXoSkB = Activator.CreateInstance(UizJzkbIhwKiQ);
	}
}
