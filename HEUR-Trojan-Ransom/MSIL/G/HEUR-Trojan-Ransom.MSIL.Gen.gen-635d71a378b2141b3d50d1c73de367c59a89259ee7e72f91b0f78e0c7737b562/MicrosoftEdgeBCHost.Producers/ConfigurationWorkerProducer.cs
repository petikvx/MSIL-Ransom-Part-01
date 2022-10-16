using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConfigurationWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
