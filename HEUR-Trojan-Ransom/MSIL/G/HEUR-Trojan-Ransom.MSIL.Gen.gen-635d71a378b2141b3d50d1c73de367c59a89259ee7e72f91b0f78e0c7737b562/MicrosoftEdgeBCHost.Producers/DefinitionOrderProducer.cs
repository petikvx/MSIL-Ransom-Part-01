using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DefinitionOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
