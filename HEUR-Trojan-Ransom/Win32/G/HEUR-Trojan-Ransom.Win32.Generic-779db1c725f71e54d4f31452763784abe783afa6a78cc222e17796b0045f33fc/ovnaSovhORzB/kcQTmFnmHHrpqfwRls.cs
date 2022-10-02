using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ovnaSovhORzB;

public sealed class kcQTmFnmHHrpqfwRls
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface zBXcQvVPzPTYV
	{
		[DispId(0)]
		string LPzgpnjcGbBUauZW
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string BMpZexoJfBQhFKb
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
		string gzSLwruGtVAhN
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
		string YqwXltnlJyIIgZS
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
		string xhtfjyfpaUbMUf
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
		string PxhRoCxBEF
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string PteEUFWoEhh
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
		int SeermbRCilq
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string LHqnFcqbXGj
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

	private static Type XodAXTwpKCDkZQ;

	private static object FtvtizkfBGYL;

	[NonSerialized]
	internal static GetString getString_0;

	public static void QYXQFphTiVJGZKL(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			zBXcQvVPzPTYV zBXcQvVPzPTYV = (zBXcQvVPzPTYV)XodAXTwpKCDkZQ.InvokeMember(EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107474140)), BindingFlags.InvokeMethod, null, FtvtizkfBGYL, new object[1] { string_0 });
			zBXcQvVPzPTYV.gzSLwruGtVAhN = string_4;
			zBXcQvVPzPTYV.YqwXltnlJyIIgZS = string_5;
			zBXcQvVPzPTYV.PteEUFWoEhh = string_1;
			zBXcQvVPzPTYV.LHqnFcqbXGj = string_3;
			zBXcQvVPzPTYV.BMpZexoJfBQhFKb = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				zBXcQvVPzPTYV.xhtfjyfpaUbMUf = string_6;
			}
			zBXcQvVPzPTYV.Save();
		}
		catch (Exception ex)
		{
			if (EEGkMyyVIDL.qphnWLJhmOUolrV)
			{
				try
				{
					File.AppendAllText(EEGkMyyVIDL.GqXvKuGfqke, getString_0(107474111) + ex.Message + getString_0(107396481));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static kcQTmFnmHHrpqfwRls()
	{
		Strings.CreateGetStringDelegate(typeof(kcQTmFnmHHrpqfwRls));
		XodAXTwpKCDkZQ = Type.GetTypeFromProgID(EEGkMyyVIDL.DRlXtEGdcAr(getString_0(107474610)));
		FtvtizkfBGYL = Activator.CreateInstance(XodAXTwpKCDkZQ);
	}
}
