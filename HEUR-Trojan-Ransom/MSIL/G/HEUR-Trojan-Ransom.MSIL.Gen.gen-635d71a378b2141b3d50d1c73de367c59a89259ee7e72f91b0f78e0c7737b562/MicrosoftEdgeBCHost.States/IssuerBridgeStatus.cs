using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IssuerBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
