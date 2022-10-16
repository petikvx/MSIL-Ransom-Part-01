using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RequestRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CollectDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectDecorator()
	{
	}
}
