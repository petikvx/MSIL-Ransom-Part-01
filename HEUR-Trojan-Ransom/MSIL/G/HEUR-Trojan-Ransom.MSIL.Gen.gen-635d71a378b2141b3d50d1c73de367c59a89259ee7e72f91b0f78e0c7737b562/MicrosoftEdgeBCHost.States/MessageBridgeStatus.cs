using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MessageBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DisableMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableMessage()
	{
	}
}
