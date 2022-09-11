using System;

namespace OlLP4ANbrNNh;

internal sealed class Class3
{
	internal static void smethod_0()
	{
		AppDomain.CurrentDomain.AssemblyResolve += (object sender, ResolveEventArgs e) => Class9.smethod_1(sender, e, out var assembly_) ? assembly_ : null;
	}
}
