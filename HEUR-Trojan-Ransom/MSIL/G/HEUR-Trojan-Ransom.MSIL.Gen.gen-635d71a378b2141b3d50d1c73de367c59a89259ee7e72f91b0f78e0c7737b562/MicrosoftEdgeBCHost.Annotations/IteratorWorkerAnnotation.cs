using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class IteratorWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralExpression()
	{
	}
}
