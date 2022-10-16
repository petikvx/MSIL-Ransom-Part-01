using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TestAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareLiteralMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareLiteralMap()
	{
	}
}
