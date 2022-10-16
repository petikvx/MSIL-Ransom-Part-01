using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TemplateFilterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateFilterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
