using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AnnotationPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralInterceptor()
	{
	}
}
