using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CustomerOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceBase()
	{
	}
}
