using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AnnotationOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralConsumer()
	{
	}
}
