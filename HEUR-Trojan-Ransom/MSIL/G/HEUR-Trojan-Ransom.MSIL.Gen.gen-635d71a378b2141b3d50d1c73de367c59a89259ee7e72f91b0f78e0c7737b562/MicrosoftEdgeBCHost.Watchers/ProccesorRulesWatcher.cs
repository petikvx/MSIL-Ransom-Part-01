using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProccesorRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		FindTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindTests()
	{
	}
}
