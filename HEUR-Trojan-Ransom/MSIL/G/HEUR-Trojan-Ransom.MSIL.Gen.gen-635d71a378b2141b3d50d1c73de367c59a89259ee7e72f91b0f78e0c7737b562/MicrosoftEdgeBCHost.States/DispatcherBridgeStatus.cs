using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DispatcherBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		FindParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindParams()
	{
	}
}
