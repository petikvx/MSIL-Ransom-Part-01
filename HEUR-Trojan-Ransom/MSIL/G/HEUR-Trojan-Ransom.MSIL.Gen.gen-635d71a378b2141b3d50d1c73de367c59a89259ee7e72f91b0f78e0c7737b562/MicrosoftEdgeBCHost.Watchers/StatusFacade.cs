using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StatusFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusFacade()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralItem()
	{
	}
}
