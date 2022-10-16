using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AlgoWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceAttr()
	{
	}
}
