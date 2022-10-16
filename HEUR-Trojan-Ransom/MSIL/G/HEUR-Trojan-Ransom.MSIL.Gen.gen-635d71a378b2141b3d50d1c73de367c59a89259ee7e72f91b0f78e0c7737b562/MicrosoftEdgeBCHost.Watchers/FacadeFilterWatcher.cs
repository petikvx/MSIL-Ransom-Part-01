using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class FacadeFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InsertComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertComparator()
	{
	}
}
