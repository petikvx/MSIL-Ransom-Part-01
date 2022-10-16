using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AlgoBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoBridge()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeAdapter()
	{
	}
}
