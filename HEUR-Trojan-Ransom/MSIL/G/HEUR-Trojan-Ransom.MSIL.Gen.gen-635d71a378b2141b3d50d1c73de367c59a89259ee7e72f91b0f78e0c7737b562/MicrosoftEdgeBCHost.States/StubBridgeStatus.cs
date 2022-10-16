using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StubBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
