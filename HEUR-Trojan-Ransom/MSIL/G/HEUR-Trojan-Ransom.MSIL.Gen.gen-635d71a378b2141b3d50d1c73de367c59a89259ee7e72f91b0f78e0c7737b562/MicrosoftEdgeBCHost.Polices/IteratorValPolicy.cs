using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class IteratorValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceWorker()
	{
	}
}
