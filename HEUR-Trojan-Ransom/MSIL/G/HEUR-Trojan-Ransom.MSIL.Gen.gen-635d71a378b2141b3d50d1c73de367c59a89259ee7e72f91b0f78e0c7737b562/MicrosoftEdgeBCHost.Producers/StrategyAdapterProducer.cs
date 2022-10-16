using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StrategyAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ListLiteralMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListLiteralMock()
	{
	}
}
