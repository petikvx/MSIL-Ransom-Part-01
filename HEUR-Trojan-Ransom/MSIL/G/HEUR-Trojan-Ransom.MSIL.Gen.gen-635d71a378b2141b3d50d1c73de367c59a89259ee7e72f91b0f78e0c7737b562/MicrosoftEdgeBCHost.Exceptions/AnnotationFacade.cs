using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AnnotationFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationFacade()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralItem()
	{
	}
}
