using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ExporterOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralIndexer()
	{
	}
}
