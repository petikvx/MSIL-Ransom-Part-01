using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ValuePolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValuePolicy()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
