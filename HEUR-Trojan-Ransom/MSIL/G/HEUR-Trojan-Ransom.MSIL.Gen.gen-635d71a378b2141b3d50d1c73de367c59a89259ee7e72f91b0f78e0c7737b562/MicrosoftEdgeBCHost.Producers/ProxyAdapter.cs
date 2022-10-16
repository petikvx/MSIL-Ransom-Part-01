using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProxyAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfaceConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfaceConnection()
	{
	}
}
