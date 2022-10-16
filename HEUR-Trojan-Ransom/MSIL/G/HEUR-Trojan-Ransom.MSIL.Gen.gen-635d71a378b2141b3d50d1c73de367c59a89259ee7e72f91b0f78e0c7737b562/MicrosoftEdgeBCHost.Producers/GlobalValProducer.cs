using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class GlobalValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SearchService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchService()
	{
	}
}
