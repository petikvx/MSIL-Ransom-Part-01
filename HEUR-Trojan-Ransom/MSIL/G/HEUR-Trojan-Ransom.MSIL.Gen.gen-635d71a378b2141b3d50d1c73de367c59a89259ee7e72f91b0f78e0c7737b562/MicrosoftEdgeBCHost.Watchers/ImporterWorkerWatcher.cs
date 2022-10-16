using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ImporterWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceMerchant()
	{
	}
}
