using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StrategyExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyExpression()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralCollection()
	{
	}
}
