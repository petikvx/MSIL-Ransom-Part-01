using System;

namespace ns0;

internal sealed class Class3
{
	internal static void smethod_0()
	{
		AppDomain.CurrentDomain.AssemblyResolve += (object object_0, ResolveEventArgs resolveEventArgs_0) => Class10.smethod_1(object_0, resolveEventArgs_0, out var assembly_) ? assembly_ : null;
	}
}
