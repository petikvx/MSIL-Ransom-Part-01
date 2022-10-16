using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConsumerBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateTemplate()
	{
	}
}
