using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ValAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralQueue()
	{
	}
}
