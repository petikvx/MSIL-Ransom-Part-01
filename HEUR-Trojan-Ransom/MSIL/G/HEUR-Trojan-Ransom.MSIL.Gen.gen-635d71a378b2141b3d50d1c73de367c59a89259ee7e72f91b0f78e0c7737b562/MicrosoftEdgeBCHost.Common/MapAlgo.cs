using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MapAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralIndexer()
	{
	}
}
