using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ExpressionFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		FindTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindTemplate()
	{
	}
}
