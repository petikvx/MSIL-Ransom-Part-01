using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StatusOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceIterator()
	{
	}
}
