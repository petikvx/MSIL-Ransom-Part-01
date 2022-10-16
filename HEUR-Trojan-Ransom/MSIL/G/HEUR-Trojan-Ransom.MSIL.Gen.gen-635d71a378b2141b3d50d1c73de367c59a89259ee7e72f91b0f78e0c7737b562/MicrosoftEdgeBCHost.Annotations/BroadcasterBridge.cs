using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class BroadcasterBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterBridge()
	{
		WriterPropertyProducer.ResolveStub();
		RateCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateCollection()
	{
	}
}
