using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ConnectionFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RateConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateConfig()
	{
	}
}
