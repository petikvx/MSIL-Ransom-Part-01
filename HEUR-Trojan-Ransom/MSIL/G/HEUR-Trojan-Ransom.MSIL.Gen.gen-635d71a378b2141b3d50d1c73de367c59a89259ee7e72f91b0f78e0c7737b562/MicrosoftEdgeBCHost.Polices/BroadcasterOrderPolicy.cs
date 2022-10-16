using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class BroadcasterOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralManager()
	{
	}
}
