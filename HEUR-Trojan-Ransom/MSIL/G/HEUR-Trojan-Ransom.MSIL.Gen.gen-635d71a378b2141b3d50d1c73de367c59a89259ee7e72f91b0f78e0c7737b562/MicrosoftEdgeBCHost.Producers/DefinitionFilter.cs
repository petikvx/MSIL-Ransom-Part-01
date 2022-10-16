using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DefinitionFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionFilter()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
