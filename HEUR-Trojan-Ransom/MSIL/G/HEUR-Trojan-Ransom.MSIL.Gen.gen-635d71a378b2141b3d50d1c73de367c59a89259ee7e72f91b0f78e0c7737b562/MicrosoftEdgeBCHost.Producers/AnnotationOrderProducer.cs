using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AnnotationOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceIterator()
	{
	}
}
