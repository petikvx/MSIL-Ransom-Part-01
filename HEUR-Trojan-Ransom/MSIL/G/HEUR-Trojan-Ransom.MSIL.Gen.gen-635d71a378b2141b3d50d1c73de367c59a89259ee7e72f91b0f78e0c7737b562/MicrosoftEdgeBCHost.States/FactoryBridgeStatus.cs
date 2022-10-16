using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FactoryBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		QueryProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryProperty()
	{
	}
}
