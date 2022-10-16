using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ManagerWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralTask()
	{
	}
}
