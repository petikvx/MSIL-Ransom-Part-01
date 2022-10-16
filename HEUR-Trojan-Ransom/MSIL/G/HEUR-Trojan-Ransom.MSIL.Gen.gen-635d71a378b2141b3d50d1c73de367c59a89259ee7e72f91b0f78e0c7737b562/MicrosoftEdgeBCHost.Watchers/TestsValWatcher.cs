using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TestsValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceStrategy()
	{
	}
}
