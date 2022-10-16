using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AttrRulesWatcher : Attribute, _003CModule_003E, AttrRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		VisitObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitObject()
	{
	}
}
