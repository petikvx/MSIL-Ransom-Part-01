using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SchemaWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
