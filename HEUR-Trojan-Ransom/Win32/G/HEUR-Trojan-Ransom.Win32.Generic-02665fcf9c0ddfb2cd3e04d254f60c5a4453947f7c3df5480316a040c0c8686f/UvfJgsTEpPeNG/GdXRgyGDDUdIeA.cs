using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UvfJgsTEpPeNG;

public sealed class GdXRgyGDDUdIeA
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface srTQAbFwciea
	{
		[DispId(0)]
		string oSnYGvzqmHu
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string hARMXXYHoU
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
		string jfhUqFlMHxIGI
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
		string PImeLoYlbVisK
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
		string yzndZhwbkFvOliZ
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
		string uGaOlxQLCPF
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string JucFtywxIBv
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
		int iQdpQGycCKSNPb
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string HewXBmWugpb
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

	private static Type GmuIyQcfTNULi;

	private static object fafyTdNiAwMabO;

	[NonSerialized]
	internal static GetString getString_0;

	public static void oKsaWGZTzSIESNR(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			srTQAbFwciea srTQAbFwciea = (srTQAbFwciea)GmuIyQcfTNULi.InvokeMember(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107368133)), BindingFlags.InvokeMethod, null, fafyTdNiAwMabO, new object[1] { string_0 });
			srTQAbFwciea.jfhUqFlMHxIGI = string_4;
			srTQAbFwciea.PImeLoYlbVisK = string_5;
			srTQAbFwciea.JucFtywxIBv = string_1;
			srTQAbFwciea.HewXBmWugpb = string_3;
			srTQAbFwciea.hARMXXYHoU = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				srTQAbFwciea.yzndZhwbkFvOliZ = string_6;
			}
			srTQAbFwciea.Save();
		}
		catch (Exception ex)
		{
			if (PHGJAOmKtxaSj.pecnubHqkoHSu)
			{
				try
				{
					File.AppendAllText(PHGJAOmKtxaSj.EosKWorQtPTcF, getString_0(107368104) + ex.Message + getString_0(107396833));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static GdXRgyGDDUdIeA()
	{
		Strings.CreateGetStringDelegate(typeof(GdXRgyGDDUdIeA));
		GmuIyQcfTNULi = Type.GetTypeFromProgID(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107368091)));
		fafyTdNiAwMabO = Activator.CreateInstance(GmuIyQcfTNULi);
	}
}
