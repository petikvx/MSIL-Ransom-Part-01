using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ServiceServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceServer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
