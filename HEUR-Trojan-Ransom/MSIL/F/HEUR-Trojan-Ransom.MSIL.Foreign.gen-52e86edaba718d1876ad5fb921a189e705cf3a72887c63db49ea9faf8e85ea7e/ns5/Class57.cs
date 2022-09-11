using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using MySqlX.XDevAPI;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns19;
using ns3;
using ns9;

namespace ns5;

internal sealed class Class57 : Class56<Class52>
{
	[CompilerGenerated]
	private string string_0;

	protected List<object> list_0 = new List<object>();

	[NonSerialized]
	internal static GetString getString_0;

	public string SQL
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		private set
		{
			string_0 = value;
		}
	}

	public Class57(Class37 class37_0, string string_1)
		: base((BaseSession)class37_0)
	{
		SQL = string_1;
	}

	public override Class52 vmethod_0()
	{
		return base.Session.XSession.method_3(SQL, list_0.ToArray());
	}

	public Class57 method_2(params object[] object_0)
	{
		if (object_0 == null)
		{
			list_0.Add(null);
		}
		else
		{
			list_0.AddRange(object_0);
		}
		return this;
	}

	static Class57()
	{
		Strings.CreateGetStringDelegate(typeof(Class57));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397688), getString_0(107397683)).Replace(getString_0(107397646), getString_0(107397641)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397636)))
		{
			throw new SecurityException(getString_0(107397611));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_1, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
