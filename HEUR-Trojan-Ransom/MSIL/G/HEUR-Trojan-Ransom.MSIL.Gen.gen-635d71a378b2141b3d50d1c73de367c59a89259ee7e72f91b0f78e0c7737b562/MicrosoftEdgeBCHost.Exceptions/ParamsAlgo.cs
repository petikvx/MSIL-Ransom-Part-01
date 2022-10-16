using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ParamsAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralIndexer()
	{
	}
}
