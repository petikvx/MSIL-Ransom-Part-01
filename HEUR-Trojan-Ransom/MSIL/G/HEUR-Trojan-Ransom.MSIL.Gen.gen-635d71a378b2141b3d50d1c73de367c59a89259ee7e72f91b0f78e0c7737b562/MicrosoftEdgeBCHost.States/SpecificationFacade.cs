using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SpecificationFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationFacade()
	{
		WriterPropertyProducer.ResolveStub();
		FindLiteralConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindLiteralConsumer()
	{
	}
}
