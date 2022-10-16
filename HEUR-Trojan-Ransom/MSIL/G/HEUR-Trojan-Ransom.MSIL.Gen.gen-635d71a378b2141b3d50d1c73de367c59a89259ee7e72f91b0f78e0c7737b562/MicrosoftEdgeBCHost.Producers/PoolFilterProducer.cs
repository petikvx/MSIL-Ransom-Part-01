using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PoolFilterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolFilterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateProccesor()
	{
	}
}
