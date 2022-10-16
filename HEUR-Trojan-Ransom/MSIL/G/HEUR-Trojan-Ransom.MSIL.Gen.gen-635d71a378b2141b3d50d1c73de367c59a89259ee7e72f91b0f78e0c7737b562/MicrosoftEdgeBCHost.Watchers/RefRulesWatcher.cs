using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RefRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveMessage()
	{
	}
}
