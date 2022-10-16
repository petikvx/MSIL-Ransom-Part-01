using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RulesBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
