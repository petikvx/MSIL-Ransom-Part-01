using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class VisitorFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorFacade()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralItem()
	{
	}
}
