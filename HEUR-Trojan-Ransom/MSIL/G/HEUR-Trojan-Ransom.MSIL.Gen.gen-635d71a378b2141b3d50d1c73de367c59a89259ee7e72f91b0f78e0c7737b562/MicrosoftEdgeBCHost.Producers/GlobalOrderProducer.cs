using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class GlobalOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceProxy()
	{
	}
}
