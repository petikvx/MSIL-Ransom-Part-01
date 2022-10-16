using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProductFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatMock()
	{
	}
}
