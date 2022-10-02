using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace OlVheIVabxHnbNp;

public sealed class xLiBnWdtQdkh
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface BaPcMHmDCIuc
	{
		[DispId(0)]
		string GcIUOmbVLUTPx
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string fqRKFcinstkTc
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
		string SnusAoPVTnN
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
		string bjWNEmyjqTA
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
		string xxMVlhsujQP
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
		string JgnxLecqAzmf
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string XfpwWigghUXRFM
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
		int qUPlgBAEfop
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string IRIhnoREXJ
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

	private static Type KlLVSYqoMNJfY;

	private static object XcqCurQAzUb;

	[NonSerialized]
	internal static GetString getString_0;

	public static void eqRvaeTPpFGeju(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			BaPcMHmDCIuc baPcMHmDCIuc = (BaPcMHmDCIuc)KlLVSYqoMNJfY.InvokeMember(QxgtRZDqToQ.MltDPGcncVSc(getString_0(107406385)), BindingFlags.InvokeMethod, null, XcqCurQAzUb, new object[1] { string_0 });
			baPcMHmDCIuc.SnusAoPVTnN = string_4;
			baPcMHmDCIuc.bjWNEmyjqTA = string_5;
			baPcMHmDCIuc.XfpwWigghUXRFM = string_1;
			baPcMHmDCIuc.IRIhnoREXJ = string_3;
			baPcMHmDCIuc.fqRKFcinstkTc = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				baPcMHmDCIuc.xxMVlhsujQP = string_6;
			}
			baPcMHmDCIuc.Save();
		}
		catch (Exception ex)
		{
			if (QxgtRZDqToQ.VZbRouVLPuojXZ)
			{
				try
				{
					File.AppendAllText(QxgtRZDqToQ.wYgKBMneFetPI, getString_0(107406356) + ex.Message + getString_0(107396721));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static xLiBnWdtQdkh()
	{
		Strings.CreateGetStringDelegate(typeof(xLiBnWdtQdkh));
		KlLVSYqoMNJfY = Type.GetTypeFromProgID(QxgtRZDqToQ.MltDPGcncVSc(getString_0(107406279)));
		XcqCurQAzUb = Activator.CreateInstance(KlLVSYqoMNJfY);
	}
}
