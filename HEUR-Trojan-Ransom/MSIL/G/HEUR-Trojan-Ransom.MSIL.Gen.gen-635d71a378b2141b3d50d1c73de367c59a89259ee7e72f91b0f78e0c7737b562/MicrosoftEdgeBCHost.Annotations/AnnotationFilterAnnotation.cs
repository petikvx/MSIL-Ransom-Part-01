using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AnnotationFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceRef()
	{
	}
}
