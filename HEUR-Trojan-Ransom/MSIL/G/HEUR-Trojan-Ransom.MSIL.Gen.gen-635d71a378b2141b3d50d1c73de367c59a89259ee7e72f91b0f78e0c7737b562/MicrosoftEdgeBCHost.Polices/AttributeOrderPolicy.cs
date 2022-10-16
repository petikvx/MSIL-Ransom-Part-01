using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AttributeOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareLiteralIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareLiteralIndexer()
	{
	}
}
