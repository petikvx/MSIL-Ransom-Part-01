using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PublisherFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PublishMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishMap()
	{
	}
}
