using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ExpressionWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareLiteralDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareLiteralDescriptor()
	{
	}
}
