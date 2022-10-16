using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MethodWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralSpecification()
	{
	}
}
