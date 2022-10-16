using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class BroadcasterAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralIndexer()
	{
	}
}
