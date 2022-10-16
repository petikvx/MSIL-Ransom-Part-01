using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ListExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListExpression()
	{
		WriterPropertyProducer.ResolveStub();
		VisitLiteralMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitLiteralMapper()
	{
	}
}
