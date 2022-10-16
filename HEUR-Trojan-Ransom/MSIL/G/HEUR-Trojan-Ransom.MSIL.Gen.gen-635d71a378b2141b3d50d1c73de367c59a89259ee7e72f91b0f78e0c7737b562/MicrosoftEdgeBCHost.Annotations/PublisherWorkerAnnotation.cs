using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PublisherWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralPrototype()
	{
	}
}
