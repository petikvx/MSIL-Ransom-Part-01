using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fTOyYuFiHboGKe;

public sealed class KogQQcqLmuaMW
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface wkJTXvhBEAORzL
	{
		[DispId(0)]
		string pwxuXtucnT
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string NbZJFNaTPCTzi
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
		string bpseLgNFYrrkeA
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
		string aswyxrviaNjD
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
		string ReohAqSBEzFt
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
		string KSpKOSaaotlN
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string FzxENHGfCQRN
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
		int YqeGqKemsXasBv
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string UYZrGMLtSH
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

	private static Type jWpMhxnlKspP;

	private static object URytkGEzZywx;

	[NonSerialized]
	internal static GetString getString_0;

	public static void bbrkYCmpaWWDR(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			wkJTXvhBEAORzL wkJTXvhBEAORzL = (wkJTXvhBEAORzL)jWpMhxnlKspP.InvokeMember(bpqMdVmtaEtPaZM.HIZwQscayZMa(getString_0(107404883)), BindingFlags.InvokeMethod, null, URytkGEzZywx, new object[1] { string_0 });
			wkJTXvhBEAORzL.bpseLgNFYrrkeA = string_4;
			wkJTXvhBEAORzL.aswyxrviaNjD = string_5;
			wkJTXvhBEAORzL.FzxENHGfCQRN = string_1;
			wkJTXvhBEAORzL.UYZrGMLtSH = string_3;
			wkJTXvhBEAORzL.NbZJFNaTPCTzi = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				wkJTXvhBEAORzL.ReohAqSBEzFt = string_6;
			}
			wkJTXvhBEAORzL.Save();
		}
		catch (Exception ex)
		{
			if (bpqMdVmtaEtPaZM.diLbjzXQsjUvfr)
			{
				try
				{
					File.AppendAllText(bpqMdVmtaEtPaZM.fNCnNJWJkI, getString_0(107404854) + ex.Message + getString_0(107396726));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static KogQQcqLmuaMW()
	{
		Strings.CreateGetStringDelegate(typeof(KogQQcqLmuaMW));
		jWpMhxnlKspP = Type.GetTypeFromProgID(bpqMdVmtaEtPaZM.HIZwQscayZMa(getString_0(107404777)));
		URytkGEzZywx = Activator.CreateInstance(jWpMhxnlKspP);
	}
}
