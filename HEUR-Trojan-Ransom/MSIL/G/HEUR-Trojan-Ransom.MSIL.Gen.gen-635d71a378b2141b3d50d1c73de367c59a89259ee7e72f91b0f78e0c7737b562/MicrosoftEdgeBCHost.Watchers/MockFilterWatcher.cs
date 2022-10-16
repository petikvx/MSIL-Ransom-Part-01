using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MockFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ValidatePool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidatePool()
	{
	}
}
