using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TestFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DisablePublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisablePublisher()
	{
	}
}
