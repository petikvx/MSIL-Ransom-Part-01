using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PoolValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInfo()
	{
	}
}
