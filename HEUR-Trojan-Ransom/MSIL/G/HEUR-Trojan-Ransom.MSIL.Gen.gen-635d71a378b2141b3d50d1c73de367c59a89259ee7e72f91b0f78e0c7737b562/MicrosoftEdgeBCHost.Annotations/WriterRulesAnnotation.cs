using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WriterRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SortPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortPredicate()
	{
	}
}
