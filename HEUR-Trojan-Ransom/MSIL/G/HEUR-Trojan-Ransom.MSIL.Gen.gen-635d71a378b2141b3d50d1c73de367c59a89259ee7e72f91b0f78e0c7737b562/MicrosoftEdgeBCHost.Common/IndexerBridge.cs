using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class IndexerBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerBridge()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeQueue()
	{
	}
}
