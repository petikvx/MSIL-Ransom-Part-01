using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CollectionAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareLiteralParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareLiteralParams()
	{
	}
}
