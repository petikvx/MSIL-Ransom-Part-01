using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ContainerFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		StartPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartPool()
	{
	}
}
