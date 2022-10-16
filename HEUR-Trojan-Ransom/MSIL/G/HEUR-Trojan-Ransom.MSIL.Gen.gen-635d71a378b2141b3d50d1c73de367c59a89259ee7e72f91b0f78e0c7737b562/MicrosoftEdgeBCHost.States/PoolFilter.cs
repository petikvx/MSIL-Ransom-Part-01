using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PoolFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolFilter()
	{
		WriterPropertyProducer.ResolveStub();
		DisableWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableWatcher()
	{
	}
}
