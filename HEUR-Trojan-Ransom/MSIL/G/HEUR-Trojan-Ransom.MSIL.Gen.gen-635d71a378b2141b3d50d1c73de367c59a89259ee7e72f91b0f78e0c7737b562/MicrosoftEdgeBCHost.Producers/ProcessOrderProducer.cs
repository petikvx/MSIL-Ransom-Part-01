using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProcessOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceConsumer()
	{
	}
}
