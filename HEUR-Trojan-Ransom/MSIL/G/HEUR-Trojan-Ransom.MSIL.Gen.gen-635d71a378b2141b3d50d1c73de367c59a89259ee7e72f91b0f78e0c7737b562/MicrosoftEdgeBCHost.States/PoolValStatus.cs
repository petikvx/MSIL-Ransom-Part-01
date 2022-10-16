using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PoolValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralProduct()
	{
	}
}
