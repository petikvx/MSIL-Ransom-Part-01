using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DecoratorRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptMessage()
	{
	}
}
