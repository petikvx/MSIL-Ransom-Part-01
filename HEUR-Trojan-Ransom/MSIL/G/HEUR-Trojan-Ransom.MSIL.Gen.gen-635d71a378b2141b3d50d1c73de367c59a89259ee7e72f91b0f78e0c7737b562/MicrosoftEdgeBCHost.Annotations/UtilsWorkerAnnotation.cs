using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class UtilsWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralDecorator()
	{
	}
}
