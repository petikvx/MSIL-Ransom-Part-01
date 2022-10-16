using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DefinitionRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
