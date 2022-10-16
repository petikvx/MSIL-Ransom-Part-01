using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MerchantWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceField()
	{
	}
}
