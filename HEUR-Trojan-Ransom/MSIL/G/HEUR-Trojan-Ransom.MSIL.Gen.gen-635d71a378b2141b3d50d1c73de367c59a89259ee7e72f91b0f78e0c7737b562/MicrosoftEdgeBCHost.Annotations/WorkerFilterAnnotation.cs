using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WorkerFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceWorker()
	{
	}
}
