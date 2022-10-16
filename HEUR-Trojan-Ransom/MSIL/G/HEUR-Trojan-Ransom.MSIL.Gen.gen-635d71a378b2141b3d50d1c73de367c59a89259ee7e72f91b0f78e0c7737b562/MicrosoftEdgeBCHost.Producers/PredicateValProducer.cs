using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PredicateValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CreateRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateRepository()
	{
	}
}
