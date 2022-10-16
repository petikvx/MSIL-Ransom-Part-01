using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AdapterValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
