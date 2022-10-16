using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class VisitorBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeParam()
	{
	}
}
