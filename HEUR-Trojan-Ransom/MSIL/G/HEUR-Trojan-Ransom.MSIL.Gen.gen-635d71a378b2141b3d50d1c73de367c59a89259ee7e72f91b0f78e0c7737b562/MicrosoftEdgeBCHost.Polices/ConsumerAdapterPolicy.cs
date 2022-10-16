using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ConsumerAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
