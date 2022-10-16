using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CustomerAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralProxy()
	{
	}
}
