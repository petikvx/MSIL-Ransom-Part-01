using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DatabaseOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
