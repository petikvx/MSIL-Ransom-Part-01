using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class EventBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventBridge()
	{
		WriterPropertyProducer.ResolveStub();
		AssetQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetQueue()
	{
	}
}
