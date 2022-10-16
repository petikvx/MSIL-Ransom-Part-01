using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InstanceRulesWatcher : Attribute, _003CModule_003E, InstanceRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
