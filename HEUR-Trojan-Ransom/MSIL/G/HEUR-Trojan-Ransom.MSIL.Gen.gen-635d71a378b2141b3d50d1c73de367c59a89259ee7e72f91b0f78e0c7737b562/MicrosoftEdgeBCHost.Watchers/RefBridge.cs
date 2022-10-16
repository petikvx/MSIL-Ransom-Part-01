using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RefBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefBridge()
	{
		WriterPropertyProducer.ResolveStub();
		TestIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestIndexer()
	{
	}
}
