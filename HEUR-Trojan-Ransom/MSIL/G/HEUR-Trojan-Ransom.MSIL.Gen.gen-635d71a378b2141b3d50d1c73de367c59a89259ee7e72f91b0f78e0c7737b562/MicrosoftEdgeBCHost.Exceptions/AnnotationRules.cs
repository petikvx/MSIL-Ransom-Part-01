using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AnnotationRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationRules()
	{
		WriterPropertyProducer.ResolveStub();
		PushProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushProperty()
	{
	}
}
