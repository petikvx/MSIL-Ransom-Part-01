using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ObjectValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SortMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortMap()
	{
	}
}
