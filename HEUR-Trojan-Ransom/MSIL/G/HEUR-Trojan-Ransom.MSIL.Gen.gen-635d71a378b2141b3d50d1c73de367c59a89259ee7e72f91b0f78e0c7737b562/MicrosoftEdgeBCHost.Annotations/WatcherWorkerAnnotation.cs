using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WatcherWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralContext()
	{
	}
}
