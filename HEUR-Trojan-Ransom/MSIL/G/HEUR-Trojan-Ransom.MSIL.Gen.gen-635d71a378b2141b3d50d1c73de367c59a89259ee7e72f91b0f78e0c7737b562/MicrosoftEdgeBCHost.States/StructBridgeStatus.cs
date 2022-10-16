using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StructBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SetupComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupComparator()
	{
	}
}
