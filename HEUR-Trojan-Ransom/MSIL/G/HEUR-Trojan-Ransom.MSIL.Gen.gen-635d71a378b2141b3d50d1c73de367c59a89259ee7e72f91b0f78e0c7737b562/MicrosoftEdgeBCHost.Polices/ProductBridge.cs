using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProductBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductBridge()
	{
		WriterPropertyProducer.ResolveStub();
		CalcMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcMapper()
	{
	}
}
