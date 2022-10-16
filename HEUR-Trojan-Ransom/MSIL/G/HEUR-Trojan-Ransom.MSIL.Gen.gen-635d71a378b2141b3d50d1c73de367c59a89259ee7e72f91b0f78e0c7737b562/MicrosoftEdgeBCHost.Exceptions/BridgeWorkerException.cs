using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class BridgeWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		ResetQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetQueue()
	{
	}
}
