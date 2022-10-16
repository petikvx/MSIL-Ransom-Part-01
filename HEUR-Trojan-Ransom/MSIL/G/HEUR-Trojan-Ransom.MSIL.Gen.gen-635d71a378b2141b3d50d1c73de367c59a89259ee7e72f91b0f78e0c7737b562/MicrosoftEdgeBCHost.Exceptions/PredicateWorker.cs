using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PredicateWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateWorker()
	{
		WriterPropertyProducer.ResolveStub();
		RestartSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartSerializer()
	{
	}
}
