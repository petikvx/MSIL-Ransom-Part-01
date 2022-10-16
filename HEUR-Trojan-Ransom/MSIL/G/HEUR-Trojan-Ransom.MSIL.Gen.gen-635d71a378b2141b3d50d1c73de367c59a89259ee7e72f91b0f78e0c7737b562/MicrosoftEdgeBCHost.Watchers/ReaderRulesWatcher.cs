using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ReaderRulesWatcher : Attribute, _003CModule_003E, ReaderRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveFactory()
	{
	}
}
