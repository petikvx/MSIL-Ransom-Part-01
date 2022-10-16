using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FactoryAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
