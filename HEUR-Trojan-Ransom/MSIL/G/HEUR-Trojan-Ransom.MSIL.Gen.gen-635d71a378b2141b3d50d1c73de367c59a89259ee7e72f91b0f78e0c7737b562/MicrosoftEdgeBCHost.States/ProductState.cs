using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProductState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductState()
	{
		WriterPropertyProducer.ResolveStub();
		CancelInterfaceIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelInterfaceIndexer()
	{
	}
}
