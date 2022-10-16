using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class VisitorAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectLiteralIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectLiteralIndexer()
	{
	}
}
