using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AnnotationAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralIndexer()
	{
	}
}
