using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProductOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		StartLiteralTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartLiteralTag()
	{
	}
}
