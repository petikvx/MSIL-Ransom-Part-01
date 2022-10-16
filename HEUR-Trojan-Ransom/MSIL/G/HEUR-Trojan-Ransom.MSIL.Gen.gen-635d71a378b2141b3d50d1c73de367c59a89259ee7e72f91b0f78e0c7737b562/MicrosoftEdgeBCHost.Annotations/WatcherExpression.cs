using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WatcherExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherExpression()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralAdapter()
	{
	}
}
