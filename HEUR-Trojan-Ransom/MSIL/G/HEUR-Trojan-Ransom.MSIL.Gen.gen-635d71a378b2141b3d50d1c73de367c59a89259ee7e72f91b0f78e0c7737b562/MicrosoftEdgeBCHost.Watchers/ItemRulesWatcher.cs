using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ItemRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SetupPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupPrinter()
	{
	}
}
