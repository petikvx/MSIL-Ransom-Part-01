using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DispatcherWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralProxy()
	{
	}
}
