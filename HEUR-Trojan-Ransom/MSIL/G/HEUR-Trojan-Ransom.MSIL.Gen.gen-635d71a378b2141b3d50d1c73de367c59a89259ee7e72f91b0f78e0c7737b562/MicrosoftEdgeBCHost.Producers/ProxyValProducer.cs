using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProxyValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		FindAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindAdapter()
	{
	}
}
