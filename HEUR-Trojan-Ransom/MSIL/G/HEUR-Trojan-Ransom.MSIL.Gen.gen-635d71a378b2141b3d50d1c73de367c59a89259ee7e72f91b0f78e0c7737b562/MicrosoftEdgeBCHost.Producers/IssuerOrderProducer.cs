using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IssuerOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfacePool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfacePool()
	{
	}
}
