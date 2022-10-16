using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RegRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatParser()
	{
	}
}
