using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class WorkerValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		EnableState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableState()
	{
	}
}
