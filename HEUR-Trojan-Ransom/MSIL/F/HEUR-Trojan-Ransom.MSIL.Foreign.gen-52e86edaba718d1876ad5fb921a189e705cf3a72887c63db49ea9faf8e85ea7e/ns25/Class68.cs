using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns13;
using ns18;
using ns20;
using ns24;

namespace ns25;

internal sealed class Class68 : Class67<Class54>
{
	private List<Class43> list_0 = new List<Class43>();

	internal bool bool_0;

	[NonSerialized]
	internal static GetString getString_0;

	internal Class68(Class39 class39_0)
		: base(class39_0)
	{
	}

	public Class68 method_3(params object[] object_0)
	{
		if (object_0 == null)
		{
			throw new ArgumentNullException();
		}
		list_0.AddRange(method_2(object_0));
		return this;
	}

	public override Class54 vmethod_0()
	{
		try
		{
			if (list_0.Count == 0)
			{
				return new Class54(null);
			}
			return base.Target.Session.XSession.method_23(base.Target, list_0.ToArray(), null, bool_0);
		}
		finally
		{
			list_0.Clear();
		}
	}

	private List<string> method_4()
	{
		List<string> list = new List<string>();
		foreach (Class43 item in list_0)
		{
			item.method_0();
			list.Add(item.Id.ToString());
		}
		return list;
	}

	static Class68()
	{
		Strings.CreateGetStringDelegate(typeof(Class68));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397709), getString_0(107397704)).Replace(getString_0(107397667), getString_0(107397662)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_1: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397657)))
		{
			throw new SecurityException(getString_0(107397632));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_1, [MarshalAs(UnmanagedType.Bool)] out bool bool_2);
}
