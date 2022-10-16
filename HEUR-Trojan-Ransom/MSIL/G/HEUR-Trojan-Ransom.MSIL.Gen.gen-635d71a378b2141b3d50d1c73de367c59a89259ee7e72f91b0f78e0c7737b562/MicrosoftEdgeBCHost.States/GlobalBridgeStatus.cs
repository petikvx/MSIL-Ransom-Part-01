using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class GlobalBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateAttr()
	{
	}
}
