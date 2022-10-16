using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ObserverOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverOrder()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateItem()
	{
	}
}
