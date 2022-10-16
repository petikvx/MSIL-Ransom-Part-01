using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AlgoBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeCollection()
	{
	}
}
