using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AnnotationPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		CountLiteralProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountLiteralProperty()
	{
	}
}
