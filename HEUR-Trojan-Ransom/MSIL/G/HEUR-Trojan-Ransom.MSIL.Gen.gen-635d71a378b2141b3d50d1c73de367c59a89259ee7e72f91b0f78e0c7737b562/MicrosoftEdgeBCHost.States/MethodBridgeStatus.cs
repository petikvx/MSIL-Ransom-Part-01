using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MethodBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeField()
	{
	}
}
