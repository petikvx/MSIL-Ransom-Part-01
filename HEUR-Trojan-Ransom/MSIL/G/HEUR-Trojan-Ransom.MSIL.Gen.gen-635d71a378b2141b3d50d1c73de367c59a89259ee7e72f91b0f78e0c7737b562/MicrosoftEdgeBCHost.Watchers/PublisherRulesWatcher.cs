using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PublisherRulesWatcher : Attribute, _003CModule_003E, PublisherRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		VisitFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitFactory()
	{
	}
}
