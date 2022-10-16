using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class WrapperFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SortProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortProperty()
	{
	}
}
