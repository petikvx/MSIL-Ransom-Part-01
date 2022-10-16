using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ImporterFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterFacade()
	{
		WriterPropertyProducer.ResolveStub();
		VisitLiteralConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitLiteralConsumer()
	{
	}
}
