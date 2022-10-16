using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PropertyPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceInfo()
	{
	}
}
