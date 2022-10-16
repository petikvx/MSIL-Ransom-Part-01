using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ClientAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralWatcher()
	{
	}
}
