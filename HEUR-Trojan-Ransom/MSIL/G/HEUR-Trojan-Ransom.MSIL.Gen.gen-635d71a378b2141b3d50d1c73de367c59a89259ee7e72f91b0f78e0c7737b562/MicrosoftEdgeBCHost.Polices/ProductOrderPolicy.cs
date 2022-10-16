using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProductOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceItem()
	{
	}
}
