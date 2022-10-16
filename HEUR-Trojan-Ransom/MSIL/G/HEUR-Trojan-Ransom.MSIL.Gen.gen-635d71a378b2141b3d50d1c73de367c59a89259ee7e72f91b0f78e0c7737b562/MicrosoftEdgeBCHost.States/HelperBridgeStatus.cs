using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class HelperBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		EnableStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableStatus()
	{
	}
}
