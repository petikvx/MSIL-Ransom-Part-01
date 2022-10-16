using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IteratorValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceProperty()
	{
	}
}
