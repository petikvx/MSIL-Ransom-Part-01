using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MethodExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodExpression()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralCollection()
	{
	}
}
