using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class IteratorOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorOrder()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterItem()
	{
	}
}
