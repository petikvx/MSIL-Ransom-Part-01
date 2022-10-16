using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class GlobalWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ResetLiteralDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetLiteralDecorator()
	{
	}
}
