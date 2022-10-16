using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ExpressionFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceValue()
	{
	}
}
