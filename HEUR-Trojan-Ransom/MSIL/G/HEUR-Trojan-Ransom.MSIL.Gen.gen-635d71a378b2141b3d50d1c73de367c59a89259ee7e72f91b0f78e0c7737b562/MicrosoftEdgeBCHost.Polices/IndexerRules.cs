using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class IndexerRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerRules()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInitializer()
	{
	}
}
