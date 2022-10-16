using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class HelperAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfaceWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfaceWorker()
	{
	}
}
