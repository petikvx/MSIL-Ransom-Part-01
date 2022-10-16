using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class WorkerWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralIterator()
	{
	}
}
