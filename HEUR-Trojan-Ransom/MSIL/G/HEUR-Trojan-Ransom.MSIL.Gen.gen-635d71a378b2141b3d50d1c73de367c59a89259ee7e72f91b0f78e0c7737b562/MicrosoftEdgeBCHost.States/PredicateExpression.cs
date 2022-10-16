using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PredicateExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateExpression()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralTests()
	{
	}
}
