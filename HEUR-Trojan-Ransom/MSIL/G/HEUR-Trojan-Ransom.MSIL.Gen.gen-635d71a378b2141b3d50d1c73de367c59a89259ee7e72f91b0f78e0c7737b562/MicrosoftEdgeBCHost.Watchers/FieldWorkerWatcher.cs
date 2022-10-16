using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class FieldWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceMerchant()
	{
	}
}
