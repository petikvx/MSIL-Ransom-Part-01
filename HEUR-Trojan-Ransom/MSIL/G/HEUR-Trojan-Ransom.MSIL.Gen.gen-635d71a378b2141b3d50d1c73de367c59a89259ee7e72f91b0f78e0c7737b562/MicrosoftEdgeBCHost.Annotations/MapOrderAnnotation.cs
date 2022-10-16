using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MapOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeLiteralConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeLiteralConsumer()
	{
	}
}
