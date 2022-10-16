using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProducerRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerRules()
	{
		WriterPropertyProducer.ResolveStub();
		SortModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortModel()
	{
	}
}
