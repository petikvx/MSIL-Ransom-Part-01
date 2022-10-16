using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PoolValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceMock()
	{
	}
}
