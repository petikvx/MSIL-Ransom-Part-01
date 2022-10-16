using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AnnotationWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InitLiteralStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitLiteralStatus()
	{
	}
}
