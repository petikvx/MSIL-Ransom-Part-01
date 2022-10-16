using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ExceptionFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareExpression()
	{
	}
}
