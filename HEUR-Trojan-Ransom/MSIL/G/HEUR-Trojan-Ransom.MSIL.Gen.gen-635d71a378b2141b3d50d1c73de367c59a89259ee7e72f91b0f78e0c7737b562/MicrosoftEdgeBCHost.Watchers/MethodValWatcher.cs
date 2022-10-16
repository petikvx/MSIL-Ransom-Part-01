using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MethodValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		FlushInterfaceComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushInterfaceComparator()
	{
	}
}
