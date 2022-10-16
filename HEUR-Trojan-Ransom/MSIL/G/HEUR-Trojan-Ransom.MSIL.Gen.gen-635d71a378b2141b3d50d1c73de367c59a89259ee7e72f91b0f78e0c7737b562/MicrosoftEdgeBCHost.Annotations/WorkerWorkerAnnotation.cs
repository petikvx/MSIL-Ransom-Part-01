using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WorkerWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralCode()
	{
	}
}
