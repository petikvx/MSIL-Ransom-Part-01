using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ParamRulesWatcher : Attribute, _003CModule_003E, ParamRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
