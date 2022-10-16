using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SpecificationWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceMerchant()
	{
	}
}
