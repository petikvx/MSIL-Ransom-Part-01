using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IdentifierRulesWatcher : Attribute, _003CModule_003E, IdentifierRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
