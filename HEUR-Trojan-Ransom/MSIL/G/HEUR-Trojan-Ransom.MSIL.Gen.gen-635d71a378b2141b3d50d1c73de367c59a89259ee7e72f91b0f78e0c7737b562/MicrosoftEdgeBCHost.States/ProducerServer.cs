using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProducerServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerServer()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareLiteralPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareLiteralPredicate()
	{
	}
}
