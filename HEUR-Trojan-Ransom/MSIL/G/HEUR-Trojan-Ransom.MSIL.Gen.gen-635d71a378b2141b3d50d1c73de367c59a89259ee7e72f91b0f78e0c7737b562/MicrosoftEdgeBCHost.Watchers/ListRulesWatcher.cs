using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ListRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		EnableMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableMapper()
	{
	}
}
