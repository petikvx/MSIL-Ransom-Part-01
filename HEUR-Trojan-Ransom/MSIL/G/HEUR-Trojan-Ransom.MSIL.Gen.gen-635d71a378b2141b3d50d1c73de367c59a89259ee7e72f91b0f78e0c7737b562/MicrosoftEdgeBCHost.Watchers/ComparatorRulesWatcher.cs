using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ComparatorRulesWatcher : Attribute, _003CModule_003E, ComparatorRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
