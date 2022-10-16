using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProducerRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CollectList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectList()
	{
	}
}
