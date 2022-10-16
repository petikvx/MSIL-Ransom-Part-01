using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class BroadcasterWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		MapInterfaceParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapInterfaceParam()
	{
	}
}
