using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProductValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceDic()
	{
	}
}
