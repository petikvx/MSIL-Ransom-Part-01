using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProxyRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SortConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortConsumer()
	{
	}
}
