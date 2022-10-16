using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AnnotationAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralRef()
	{
	}
}
