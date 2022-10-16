using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InitializerRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DefineTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineTest()
	{
	}
}
