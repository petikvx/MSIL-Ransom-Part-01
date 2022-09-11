using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns10;
using ns14;
using ns21;
using ns8;

namespace MySqlX.Failover;

internal static class FailoverManager
{
	[CompilerGenerated]
	private static Class105 class105_0;

	[NonSerialized]
	internal static GetString getString_0;

	internal static Class105 FailoverGroup
	{
		[CompilerGenerated]
		get
		{
			return class105_0;
		}
		[CompilerGenerated]
		private set
		{
			class105_0 = value;
		}
	}

	internal static void smethod_0()
	{
		if (FailoverGroup != null)
		{
			FailoverGroup = null;
		}
	}

	internal static void smethod_1(List<XServer> list_0, Enum26 enum26_0)
	{
		switch (enum26_0)
		{
		case Enum26.const_1:
			FailoverGroup = new Class106(list_0.OrderByDescending((XServer xserver_0) => xserver_0.Priority).ToList());
			break;
		case Enum26.const_0:
			FailoverGroup = new Class106(list_0);
			break;
		}
	}

	internal static Class79 smethod_2(string string_0, out string string_1)
	{
		if (FailoverGroup != null && string_0 != null)
		{
			XServer xServer = FailoverGroup.ActiveHost;
			string host = xServer.Host;
			MySqlConnectionStringBuilder mySqlConnectionStringBuilder = null;
			Class79 @class = null;
			do
			{
				string_1 = getString_0(107409424) + xServer.Host + getString_0(107408723) + string_0.Substring(string_0.IndexOf(';') + 1);
				mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder(string_1);
				if (xServer != null && xServer.Port != -1)
				{
					mySqlConnectionStringBuilder.Port = (uint)xServer.Port;
				}
				try
				{
					@class = Class79.smethod_0(mySqlConnectionStringBuilder);
				}
				catch (Exception)
				{
				}
				if (@class != null)
				{
					break;
				}
				xServer = FailoverGroup.vmethod_1();
			}
			while (xServer.Host != host);
			if (@class == null)
			{
				throw new MySqlException(Class121.UnableToConnectToHost);
			}
			return @class;
		}
		string_1 = null;
		return null;
	}

	static FailoverManager()
	{
		Strings.CreateGetStringDelegate(typeof(FailoverManager));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397950), getString_0(107397945)).Replace(getString_0(107397908), getString_0(107397903)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397898)))
		{
			throw new SecurityException(getString_0(107397873));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
