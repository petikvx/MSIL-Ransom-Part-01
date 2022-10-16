using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PropertyPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
