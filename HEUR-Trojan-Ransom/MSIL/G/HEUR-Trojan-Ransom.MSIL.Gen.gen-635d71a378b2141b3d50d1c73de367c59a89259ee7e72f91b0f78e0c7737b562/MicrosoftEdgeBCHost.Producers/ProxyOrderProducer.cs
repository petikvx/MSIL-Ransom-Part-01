using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProxyOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceParams()
	{
	}
}
