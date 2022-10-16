using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceInfo()
	{
	}
}
