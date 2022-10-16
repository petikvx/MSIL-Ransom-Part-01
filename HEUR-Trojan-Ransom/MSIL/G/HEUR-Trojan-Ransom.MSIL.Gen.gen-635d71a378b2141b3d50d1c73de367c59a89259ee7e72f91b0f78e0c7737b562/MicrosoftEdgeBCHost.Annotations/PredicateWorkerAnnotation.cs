using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PredicateWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralAnnotation()
	{
	}
}
