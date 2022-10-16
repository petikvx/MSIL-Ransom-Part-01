using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProxyFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ListConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListConfig()
	{
	}
}
