using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ExpressionVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionVal()
	{
		WriterPropertyProducer.ResolveStub();
		SortVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortVisitor()
	{
	}
}
