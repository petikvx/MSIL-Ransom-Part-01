using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class EventWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceProduct()
	{
	}
}
