using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PolicyWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralBridge()
	{
	}
}
