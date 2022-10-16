using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MerchantRulesWatcher : Attribute, _003CModule_003E, MerchantRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInstance()
	{
	}
}
