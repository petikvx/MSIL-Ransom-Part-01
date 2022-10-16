using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PublisherContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherContext()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfacePredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfacePredicate()
	{
	}
}
