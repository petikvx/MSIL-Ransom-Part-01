using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DefinitionPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CountLiteralMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountLiteralMerchant()
	{
	}
}
