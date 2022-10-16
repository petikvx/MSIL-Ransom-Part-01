using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CollectionRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CountPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountPage()
	{
	}
}
