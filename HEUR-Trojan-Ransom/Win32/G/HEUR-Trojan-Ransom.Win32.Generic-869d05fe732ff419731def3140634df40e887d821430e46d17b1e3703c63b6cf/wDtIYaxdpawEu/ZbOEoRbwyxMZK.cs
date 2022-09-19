using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wDtIYaxdpawEu;

public sealed class ZbOEoRbwyxMZK
{
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeLibType(4160)]
	private interface NYmgrZGgKIgmL
	{
		[DispId(0)]
		string cNqJyiQcLjpYX
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string nQkkgsiMlYOJr
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
		string wpMXtemqOFJl
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
		string gvkBKkYurHn
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
		string IihvhYThnELw
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
		string UDERKFllni
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string EGkVkflMWq
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
		int FEupzXZypDAKtN
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string BiMiEFsheYDQ
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

	public static void CmggciUtkrSyflU(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			NYmgrZGgKIgmL nYmgrZGgKIgmL = (NYmgrZGgKIgmL)BFvuMvZoJHfY.InvokeMember(OwCGWssNrah.iBDvjzxzEcC(getString_0(107378774)), BindingFlags.InvokeMethod, null, sYUZmBxBMsI, new object[1] { string_0 });
			nYmgrZGgKIgmL.wpMXtemqOFJl = string_4;
			nYmgrZGgKIgmL.gvkBKkYurHn = string_5;
			nYmgrZGgKIgmL.EGkVkflMWq = string_1;
			nYmgrZGgKIgmL.BiMiEFsheYDQ = string_3;
			nYmgrZGgKIgmL.nQkkgsiMlYOJr = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				nYmgrZGgKIgmL.IihvhYThnELw = string_6;
			}
			nYmgrZGgKIgmL.Save();
		}
		catch (Exception ex)
		{
			if (OwCGWssNrah.SBPYnaSzKyFP)
			{
				try
				{
					File.AppendAllText(OwCGWssNrah.ndioqUCcjeEwRygxn, getString_0(107378745) + ex.Message + getString_0(107396797));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static ZbOEoRbwyxMZK()
	{
		Strings.CreateGetStringDelegate(typeof(ZbOEoRbwyxMZK));
		BFvuMvZoJHfY = Type.GetTypeFromProgID(OwCGWssNrah.iBDvjzxzEcC(getString_0(107378668)));
		sYUZmBxBMsI = Activator.CreateInstance(BFvuMvZoJHfY);
	}
}
