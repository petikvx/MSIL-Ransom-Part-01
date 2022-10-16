using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CollectionWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceStatus()
	{
	}
}
