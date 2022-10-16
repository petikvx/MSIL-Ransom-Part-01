using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class WriterWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RestartInterfaceOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartInterfaceOrder()
	{
	}
}
