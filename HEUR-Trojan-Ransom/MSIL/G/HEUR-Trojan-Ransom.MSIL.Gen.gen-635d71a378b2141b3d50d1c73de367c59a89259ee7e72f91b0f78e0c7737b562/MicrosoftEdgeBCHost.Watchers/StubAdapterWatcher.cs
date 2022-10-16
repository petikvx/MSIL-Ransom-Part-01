using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StubAdapterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubAdapterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralList()
	{
	}
}
