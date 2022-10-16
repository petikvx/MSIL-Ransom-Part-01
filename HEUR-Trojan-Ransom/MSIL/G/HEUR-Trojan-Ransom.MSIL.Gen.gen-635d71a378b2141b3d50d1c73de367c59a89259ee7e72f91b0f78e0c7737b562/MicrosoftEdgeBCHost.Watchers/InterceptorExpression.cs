using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InterceptorExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorExpression()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralAdapter()
	{
	}
}
