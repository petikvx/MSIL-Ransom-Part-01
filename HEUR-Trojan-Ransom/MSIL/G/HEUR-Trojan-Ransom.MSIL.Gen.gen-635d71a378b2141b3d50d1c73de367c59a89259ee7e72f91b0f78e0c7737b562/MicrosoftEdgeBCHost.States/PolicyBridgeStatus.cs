using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PolicyBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteMapper()
	{
	}
}
