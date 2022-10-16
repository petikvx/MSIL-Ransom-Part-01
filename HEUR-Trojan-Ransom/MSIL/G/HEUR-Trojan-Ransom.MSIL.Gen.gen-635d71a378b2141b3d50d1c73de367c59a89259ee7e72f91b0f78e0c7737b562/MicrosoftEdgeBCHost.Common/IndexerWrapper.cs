using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class IndexerWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		PushBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushBroadcaster()
	{
	}
}
