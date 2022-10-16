using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IdentifierRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
