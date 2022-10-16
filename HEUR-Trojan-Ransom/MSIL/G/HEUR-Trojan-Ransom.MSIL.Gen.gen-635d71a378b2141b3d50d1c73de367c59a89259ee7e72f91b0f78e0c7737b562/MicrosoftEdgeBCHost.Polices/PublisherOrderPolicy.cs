using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PublisherOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceRule()
	{
	}
}
