using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PredicateBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SortTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortTests()
	{
	}
}
