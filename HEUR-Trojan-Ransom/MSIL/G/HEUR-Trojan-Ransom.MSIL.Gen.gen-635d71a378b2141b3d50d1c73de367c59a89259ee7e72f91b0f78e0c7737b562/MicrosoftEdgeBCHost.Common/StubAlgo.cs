using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StubAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralQueue()
	{
	}
}
