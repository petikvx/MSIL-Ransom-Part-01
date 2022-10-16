using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ResolverBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RestartCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartCallback()
	{
	}
}
