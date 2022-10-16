using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MessageRulesWatcher : Attribute, _003CModule_003E, MessageRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
