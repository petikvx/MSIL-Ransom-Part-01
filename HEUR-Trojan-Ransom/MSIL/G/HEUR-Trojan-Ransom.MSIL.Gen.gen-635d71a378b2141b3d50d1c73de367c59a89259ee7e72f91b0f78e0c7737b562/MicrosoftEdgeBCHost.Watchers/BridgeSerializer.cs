using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class BridgeSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		ManageLiteralGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageLiteralGetter()
	{
	}
}
