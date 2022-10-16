using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ValueFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyProducer()
	{
	}
}
