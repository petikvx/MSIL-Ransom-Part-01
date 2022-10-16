using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MockBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeRequest()
	{
	}
}
