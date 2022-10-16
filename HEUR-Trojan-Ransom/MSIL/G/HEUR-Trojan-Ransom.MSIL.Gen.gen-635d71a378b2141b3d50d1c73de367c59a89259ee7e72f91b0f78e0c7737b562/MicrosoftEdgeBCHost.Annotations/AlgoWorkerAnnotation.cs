using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AlgoWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralImporter()
	{
	}
}
