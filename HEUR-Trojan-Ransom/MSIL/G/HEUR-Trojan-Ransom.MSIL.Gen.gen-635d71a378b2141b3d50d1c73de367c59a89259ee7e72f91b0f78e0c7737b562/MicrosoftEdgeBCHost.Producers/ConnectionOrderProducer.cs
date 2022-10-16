using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConnectionOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceSchema()
	{
	}
}
