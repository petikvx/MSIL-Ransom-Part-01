using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PropertyOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
