using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MethodFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeItem()
	{
	}
}
