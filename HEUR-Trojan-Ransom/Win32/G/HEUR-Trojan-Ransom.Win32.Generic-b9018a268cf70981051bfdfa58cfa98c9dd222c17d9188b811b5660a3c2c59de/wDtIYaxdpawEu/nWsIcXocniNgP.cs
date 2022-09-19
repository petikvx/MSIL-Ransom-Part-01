using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wDtIYaxdpawEu;

public sealed class nWsIcXocniNgP
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface NYmgrZGgKIgmL
	{
		[DispId(0)]
		string ltARnpSWDNTia
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string WvtbBQcCEJdr
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
		string mUFQztESzKMCRy
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
		string wYaGJDPNaI
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
		string ZsvkMiPeHQbz
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
		string jVznRqdUXeZAk
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string uDYFbrRJptYQS
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
		int lHWVpKfIwsV
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string QdeYYIGxUkjIrP
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

	private static Type BFvuMvZoJHfY;

	private static object sYUZmBxBMsI;

	[NonSerialized]
	internal static GetString getString_0;

	public static void xUJJzuireoApv(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			NYmgrZGgKIgmL nYmgrZGgKIgmL = (NYmgrZGgKIgmL)BFvuMvZoJHfY.InvokeMember(XudtxnGtRBJeB.jGDSNxQzvqSx(getString_0(107378122)), BindingFlags.InvokeMethod, null, sYUZmBxBMsI, new object[1] { string_0 });
			nYmgrZGgKIgmL.mUFQztESzKMCRy = string_4;
			nYmgrZGgKIgmL.wYaGJDPNaI = string_5;
			nYmgrZGgKIgmL.uDYFbrRJptYQS = string_1;
			nYmgrZGgKIgmL.QdeYYIGxUkjIrP = string_3;
			nYmgrZGgKIgmL.WvtbBQcCEJdr = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				nYmgrZGgKIgmL.ZsvkMiPeHQbz = string_6;
			}
			nYmgrZGgKIgmL.Save();
		}
		catch (Exception ex)
		{
			if (XudtxnGtRBJeB.SBPYnaSzKyFP)
			{
				try
				{
					File.AppendAllText(XudtxnGtRBJeB.ndioqUCcjeEwRygxn, getString_0(107378093) + ex.Message + getString_0(107396657));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static nWsIcXocniNgP()
	{
		Strings.CreateGetStringDelegate(typeof(nWsIcXocniNgP));
		BFvuMvZoJHfY = Type.GetTypeFromProgID(XudtxnGtRBJeB.jGDSNxQzvqSx(getString_0(107378080)));
		sYUZmBxBMsI = Activator.CreateInstance(BFvuMvZoJHfY);
	}
}
