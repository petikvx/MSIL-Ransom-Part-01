using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class BridgeAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralQueue()
	{
	}
}
