using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TestWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralQueue()
	{
	}
}
