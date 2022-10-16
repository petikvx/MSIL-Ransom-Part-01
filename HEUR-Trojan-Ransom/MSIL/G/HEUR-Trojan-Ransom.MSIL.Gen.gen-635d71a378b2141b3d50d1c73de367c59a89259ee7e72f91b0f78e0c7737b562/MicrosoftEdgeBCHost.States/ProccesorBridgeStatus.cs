using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProccesorBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SetSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetSpecification()
	{
	}
}
