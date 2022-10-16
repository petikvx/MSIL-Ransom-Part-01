using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ServerAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeLiteralBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeLiteralBridge()
	{
	}
}
