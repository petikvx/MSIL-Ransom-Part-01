using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace JcxFVLIspytryi;

public class aUNSforXsou
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface uGSFYfgCwV
	{
		[DispId(0)]
		string xJGWMIoZIIChsLFw
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string heDUyvhYjDpNz
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
		string xdFXKlYTdwohk
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
		string ofeHnrKFRIDwR
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
		string JEFhcakHBaWnnoR
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
		string wktraOsPjm
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string lAPjjpeTJpL
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
		int LfHKrVETydGl
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string tmjSQlvOoUm
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

	private static Type lgODSbODARJ = Type.GetTypeFromProgID("WScript.Shell");

	private static object SkWYvPPQOganzeSz = Activator.CreateInstance(lgODSbODARJ);

	public static void YCbkEXAtRvZQ(string JCedyMzyxeJ, string uYAgLgnFKYi, string aknbiGyLPhk, string UIsanWBYvPwOeyGNy, string hoQqDrpqABCN, string cJrgONppzytLM, string oGZNOAqBFTQYVt)
	{
		uGSFYfgCwV uGSFYfgCwV = (uGSFYfgCwV)lgODSbODARJ.InvokeMember("CreateShortcut", BindingFlags.InvokeMethod, null, SkWYvPPQOganzeSz, new object[1] { JCedyMzyxeJ });
		uGSFYfgCwV.xdFXKlYTdwohk = hoQqDrpqABCN;
		uGSFYfgCwV.ofeHnrKFRIDwR = cJrgONppzytLM;
		uGSFYfgCwV.lAPjjpeTJpL = uYAgLgnFKYi;
		uGSFYfgCwV.tmjSQlvOoUm = UIsanWBYvPwOeyGNy;
		uGSFYfgCwV.heDUyvhYjDpNz = aknbiGyLPhk;
		if (!string.IsNullOrEmpty(oGZNOAqBFTQYVt))
		{
			uGSFYfgCwV.JEFhcakHBaWnnoR = oGZNOAqBFTQYVt;
		}
		uGSFYfgCwV.Save();
	}
}
