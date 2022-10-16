using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProcBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		MoveSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveSerializer()
	{
	}
}
