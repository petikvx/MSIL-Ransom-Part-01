using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CreatorBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ResetException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetException()
	{
	}
}
