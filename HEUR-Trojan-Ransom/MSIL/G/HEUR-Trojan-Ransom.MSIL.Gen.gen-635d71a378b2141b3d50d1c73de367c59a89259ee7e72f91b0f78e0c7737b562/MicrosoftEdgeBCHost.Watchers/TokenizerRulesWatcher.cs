using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TokenizerRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ViewBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewBridge()
	{
	}
}
