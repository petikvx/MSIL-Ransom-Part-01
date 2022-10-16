using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InterceptorFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorFilter()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveExpression()
	{
	}
}
