using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ExporterExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralQueue()
	{
	}
}
