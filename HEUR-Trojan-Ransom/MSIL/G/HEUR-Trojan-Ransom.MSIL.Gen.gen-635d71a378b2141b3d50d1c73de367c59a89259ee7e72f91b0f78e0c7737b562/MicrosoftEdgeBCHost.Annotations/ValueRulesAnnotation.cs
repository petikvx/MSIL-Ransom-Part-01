using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ValueRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatPredicate()
	{
	}
}
