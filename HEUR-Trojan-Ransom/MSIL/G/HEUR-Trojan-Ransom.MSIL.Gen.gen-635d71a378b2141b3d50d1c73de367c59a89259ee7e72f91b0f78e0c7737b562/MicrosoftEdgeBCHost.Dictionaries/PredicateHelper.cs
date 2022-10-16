using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PredicateHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateHelper()
	{
		WriterPropertyProducer.ResolveStub();
		QueryLiteralObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryLiteralObserver()
	{
	}
}
