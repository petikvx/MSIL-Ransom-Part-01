using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class BridgeVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeVal()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeRules()
	{
	}
}
