using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ItemWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		WriteInterfaceInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteInterfaceInvocation()
	{
	}
}
