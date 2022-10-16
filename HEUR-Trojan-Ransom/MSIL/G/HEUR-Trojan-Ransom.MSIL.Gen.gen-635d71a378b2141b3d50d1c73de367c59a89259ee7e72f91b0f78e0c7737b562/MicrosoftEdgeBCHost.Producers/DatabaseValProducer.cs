using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DatabaseValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
