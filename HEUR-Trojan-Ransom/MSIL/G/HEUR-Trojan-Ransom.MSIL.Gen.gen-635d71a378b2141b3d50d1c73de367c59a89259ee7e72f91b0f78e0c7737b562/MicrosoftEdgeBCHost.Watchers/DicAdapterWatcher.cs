using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DicAdapterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicAdapterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RunLiteralRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunLiteralRule()
	{
	}
}
