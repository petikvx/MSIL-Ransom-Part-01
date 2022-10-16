using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RegWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralMethod()
	{
	}
}
