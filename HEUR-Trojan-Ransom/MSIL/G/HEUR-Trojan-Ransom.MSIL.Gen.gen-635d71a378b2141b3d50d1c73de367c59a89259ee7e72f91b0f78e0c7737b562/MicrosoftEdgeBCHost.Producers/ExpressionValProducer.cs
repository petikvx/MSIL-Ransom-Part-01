using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ExpressionValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PrintMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintMap()
	{
	}
}
