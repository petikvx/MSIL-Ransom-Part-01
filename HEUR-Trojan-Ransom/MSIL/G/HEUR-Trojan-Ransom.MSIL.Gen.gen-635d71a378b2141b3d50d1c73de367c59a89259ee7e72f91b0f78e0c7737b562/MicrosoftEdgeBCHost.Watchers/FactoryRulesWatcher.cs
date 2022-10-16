using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class FactoryRulesWatcher : Attribute, _003CModule_003E, FactoryRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
