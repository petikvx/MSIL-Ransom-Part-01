using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SchemaState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaState()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
