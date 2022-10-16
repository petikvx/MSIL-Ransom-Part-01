using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class WorkerWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyInterfaceMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyInterfaceMap()
	{
	}
}
