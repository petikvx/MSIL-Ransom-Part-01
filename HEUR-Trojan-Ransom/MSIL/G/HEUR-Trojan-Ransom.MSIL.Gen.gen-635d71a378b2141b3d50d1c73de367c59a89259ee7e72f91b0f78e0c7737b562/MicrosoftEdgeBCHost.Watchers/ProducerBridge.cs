using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProducerBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerBridge()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeStatus()
	{
	}
}
