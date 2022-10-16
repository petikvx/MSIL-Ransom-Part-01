using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ObserverServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverServer()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeLiteralPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeLiteralPredicate()
	{
	}
}
