using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ComparatorRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PublishFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishFacade()
	{
	}
}
