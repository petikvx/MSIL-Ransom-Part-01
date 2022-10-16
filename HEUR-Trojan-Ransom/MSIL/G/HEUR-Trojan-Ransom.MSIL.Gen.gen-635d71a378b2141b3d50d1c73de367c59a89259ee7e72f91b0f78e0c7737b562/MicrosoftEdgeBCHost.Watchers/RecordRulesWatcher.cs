using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RecordRulesWatcher : Attribute, _003CModule_003E, RecordRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		TestIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestIssuer()
	{
	}
}
