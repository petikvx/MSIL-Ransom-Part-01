using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DicAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		CountInterfaceWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountInterfaceWorker()
	{
	}
}
