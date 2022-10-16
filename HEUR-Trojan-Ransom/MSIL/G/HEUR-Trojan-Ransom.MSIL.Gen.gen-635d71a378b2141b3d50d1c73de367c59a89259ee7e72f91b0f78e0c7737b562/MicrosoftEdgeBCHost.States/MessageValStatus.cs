using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MessageValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralState()
	{
	}
}
