using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConsumerOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		MapInterfaceTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapInterfaceTask()
	{
	}
}
