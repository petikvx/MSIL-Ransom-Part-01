using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ThreadOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralExpression()
	{
	}
}
