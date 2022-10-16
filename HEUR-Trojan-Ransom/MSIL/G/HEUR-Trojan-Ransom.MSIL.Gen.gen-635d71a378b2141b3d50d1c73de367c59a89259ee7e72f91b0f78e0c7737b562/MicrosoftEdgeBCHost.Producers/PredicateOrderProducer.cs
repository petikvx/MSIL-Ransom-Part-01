using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PredicateOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		QueryLiteralObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryLiteralObject()
	{
	}
}
