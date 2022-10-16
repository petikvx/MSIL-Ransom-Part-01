using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ImporterBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RevertCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertCandidate()
	{
	}
}
