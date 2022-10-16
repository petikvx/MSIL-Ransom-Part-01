using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class EventBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ReadTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadTemplate()
	{
	}
}
