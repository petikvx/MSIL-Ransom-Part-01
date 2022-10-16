using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class BridgeOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeOrder()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeFilter()
	{
	}
}
