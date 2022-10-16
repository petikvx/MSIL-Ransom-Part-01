using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ExpressionOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptLiteralFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptLiteralFilter()
	{
	}
}
