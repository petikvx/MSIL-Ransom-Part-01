using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SystemFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemFacade()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeLiteralConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeLiteralConsumer()
	{
	}
}
