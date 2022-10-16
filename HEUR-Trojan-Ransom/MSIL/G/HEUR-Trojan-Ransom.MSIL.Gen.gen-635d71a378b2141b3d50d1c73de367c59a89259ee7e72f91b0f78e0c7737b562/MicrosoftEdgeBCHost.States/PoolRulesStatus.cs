using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PoolRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
