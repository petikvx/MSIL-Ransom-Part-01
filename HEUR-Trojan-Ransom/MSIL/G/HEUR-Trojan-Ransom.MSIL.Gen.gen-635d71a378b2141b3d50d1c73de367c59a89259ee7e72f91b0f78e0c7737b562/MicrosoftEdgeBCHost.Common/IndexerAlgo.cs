using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class IndexerAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralDefinition()
	{
	}
}
