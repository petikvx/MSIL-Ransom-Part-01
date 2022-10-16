using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CollectionFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionFacade()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralRegistry()
	{
	}
}
