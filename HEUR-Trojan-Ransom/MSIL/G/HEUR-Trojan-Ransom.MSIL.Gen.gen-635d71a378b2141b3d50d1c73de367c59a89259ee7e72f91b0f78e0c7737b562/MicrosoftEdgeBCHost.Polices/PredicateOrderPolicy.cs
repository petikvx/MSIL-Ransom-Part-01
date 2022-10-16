using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PredicateOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralException()
	{
	}
}
