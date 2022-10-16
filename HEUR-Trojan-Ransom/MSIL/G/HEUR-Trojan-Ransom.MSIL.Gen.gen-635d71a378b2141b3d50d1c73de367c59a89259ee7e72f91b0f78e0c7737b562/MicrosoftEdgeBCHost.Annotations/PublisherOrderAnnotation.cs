using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PublisherOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralRule()
	{
	}
}
