using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using ns15;
using ns4;
using ns5;

namespace ns7;

internal sealed class Class81 : IWebProxy
{
	[CompilerGenerated]
	internal sealed class Class82
	{
		public Class83 class83_0;

		internal bool method_0(Class65 class65_0)
		{
			return class65_0.method_1() == class83_0.method_0();
		}
	}

	internal static object object_0 = new object();

	internal static List<Class65> list_0;

	internal static bool bool_0;

	[CompilerGenerated]
	private Class83 class83_0;

	private ICredentials icredentials_0 = null;

	ICredentials IWebProxy.Credentials
	{
		get
		{
			return icredentials_0;
		}
		set
		{
			icredentials_0 = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private Class83 method_0()
	{
		return class83_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(Class83 class83_1)
	{
		class83_0 = class83_1;
	}

	public Class81(Class83 config = null, bool allowBypass = true)
	{
		method_1(config);
		Class6.smethod_201(config, allowBypass, this);
	}

	Uri IWebProxy.GetProxy(Uri destination)
	{
		return new Uri("http://127.0.0.1:" + method_0().method_0());
	}

	bool IWebProxy.IsBypassed(Uri host)
	{
		if (bool_0)
		{
			return !Class6.smethod_416(this);
		}
		return false;
	}

	[CompilerGenerated]
	internal bool method_2(IPEndPoint ipendPoint_0)
	{
		return ipendPoint_0.Port == method_0().method_4();
	}
}
