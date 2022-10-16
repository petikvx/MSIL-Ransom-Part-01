using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConnectionServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionServer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
