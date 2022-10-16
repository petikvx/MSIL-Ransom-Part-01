using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class GlobalAdapterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalAdapterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralPool()
	{
	}
}
