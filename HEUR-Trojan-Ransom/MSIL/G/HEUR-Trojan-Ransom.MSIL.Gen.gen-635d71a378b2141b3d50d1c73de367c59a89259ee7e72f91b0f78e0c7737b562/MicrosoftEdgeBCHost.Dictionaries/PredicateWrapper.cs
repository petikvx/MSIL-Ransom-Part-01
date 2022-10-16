using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PredicateWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptRef()
	{
	}
}
