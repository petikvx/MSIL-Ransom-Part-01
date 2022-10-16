using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TestRulesWatcher : Attribute, _003CModule_003E, TestRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInstance()
	{
	}
}
