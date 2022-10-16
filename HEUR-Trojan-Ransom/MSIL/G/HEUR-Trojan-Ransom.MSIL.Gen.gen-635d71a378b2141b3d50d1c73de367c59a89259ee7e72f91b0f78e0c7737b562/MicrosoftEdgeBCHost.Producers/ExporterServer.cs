using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ExporterServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterServer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
