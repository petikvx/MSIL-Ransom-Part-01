using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class GetterWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeLiteralTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeLiteralTest()
	{
	}
}
