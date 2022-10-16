using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AlgoValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateMap()
	{
	}
}
