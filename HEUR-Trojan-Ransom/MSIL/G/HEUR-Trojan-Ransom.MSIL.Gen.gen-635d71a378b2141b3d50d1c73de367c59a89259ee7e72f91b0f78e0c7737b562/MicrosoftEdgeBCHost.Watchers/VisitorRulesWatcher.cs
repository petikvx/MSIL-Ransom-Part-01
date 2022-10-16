using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class VisitorRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InitGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitGetter()
	{
	}
}
