using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

namespace Ydmdyualevnbexwgl;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class e
{
	private static ResourceManager m_a;

	private static CultureInfo b;

	internal static e SetException;

	internal e()
	{
	}

	internal static ResourceManager a()
	{
		if (e.m_a == null)
		{
			e.m_a = new ResourceManager("Ydmdyualevnbexwgl.Properties.Resources", RestartException(typeof(e).TypeHandle).Assembly);
		}
		return e.m_a;
	}

	internal static CultureInfo a()
	{
		return b;
	}

	internal static void a(CultureInfo a)
	{
		b = a;
	}

	internal static bool ResolveException()
	{
		return SetException == null;
	}

	internal static e InstantiateException()
	{
		return SetException;
	}

	internal static Type RestartException(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
