using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FieldBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareCandidate()
	{
	}
}
