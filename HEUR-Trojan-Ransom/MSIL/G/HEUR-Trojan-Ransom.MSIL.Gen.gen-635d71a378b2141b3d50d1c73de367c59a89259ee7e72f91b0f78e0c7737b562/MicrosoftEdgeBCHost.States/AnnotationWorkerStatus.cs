using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AnnotationWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralCallback()
	{
	}
}
