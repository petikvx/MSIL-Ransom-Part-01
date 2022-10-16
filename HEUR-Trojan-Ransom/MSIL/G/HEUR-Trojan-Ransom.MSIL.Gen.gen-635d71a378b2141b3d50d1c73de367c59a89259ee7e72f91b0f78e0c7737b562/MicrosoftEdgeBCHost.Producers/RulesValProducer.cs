using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RulesValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveBroadcaster()
	{
	}
}
