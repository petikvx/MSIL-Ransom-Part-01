using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TestBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CheckProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckProxy()
	{
	}
}
