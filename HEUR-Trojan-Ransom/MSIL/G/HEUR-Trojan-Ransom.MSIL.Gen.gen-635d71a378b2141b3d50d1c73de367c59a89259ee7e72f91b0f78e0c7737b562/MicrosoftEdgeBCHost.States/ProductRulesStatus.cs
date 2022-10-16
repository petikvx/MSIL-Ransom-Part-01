using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProductRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceWorker()
	{
	}
}
