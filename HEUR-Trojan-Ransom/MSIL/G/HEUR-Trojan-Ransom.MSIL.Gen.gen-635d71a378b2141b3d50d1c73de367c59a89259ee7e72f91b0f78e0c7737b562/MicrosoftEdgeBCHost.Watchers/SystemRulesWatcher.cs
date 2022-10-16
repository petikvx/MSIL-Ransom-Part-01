using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SystemRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		MoveTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveTest()
	{
	}
}
