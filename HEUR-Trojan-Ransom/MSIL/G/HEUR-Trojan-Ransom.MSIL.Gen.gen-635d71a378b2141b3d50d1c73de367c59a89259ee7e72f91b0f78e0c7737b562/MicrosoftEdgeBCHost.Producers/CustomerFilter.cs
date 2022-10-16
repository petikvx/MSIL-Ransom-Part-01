using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CustomerFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerFilter()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
