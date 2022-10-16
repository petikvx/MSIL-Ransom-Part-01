using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MockValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfacePage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfacePage()
	{
	}
}
