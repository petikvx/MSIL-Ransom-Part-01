using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ThreadFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadFilter()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeExpression()
	{
	}
}
