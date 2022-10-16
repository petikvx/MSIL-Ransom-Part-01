using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CandidateBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PushRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushRequest()
	{
	}
}
