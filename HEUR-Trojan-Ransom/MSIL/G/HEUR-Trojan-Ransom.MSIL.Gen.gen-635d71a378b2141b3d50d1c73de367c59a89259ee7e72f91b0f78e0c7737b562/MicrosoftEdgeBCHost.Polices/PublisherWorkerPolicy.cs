using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PublisherWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceTag()
	{
	}
}
