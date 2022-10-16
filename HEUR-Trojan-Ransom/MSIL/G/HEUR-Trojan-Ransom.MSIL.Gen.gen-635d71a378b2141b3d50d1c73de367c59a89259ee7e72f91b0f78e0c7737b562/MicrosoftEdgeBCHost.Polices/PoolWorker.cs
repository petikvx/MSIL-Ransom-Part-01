using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PoolWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolWorker()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatSerializer()
	{
	}
}
