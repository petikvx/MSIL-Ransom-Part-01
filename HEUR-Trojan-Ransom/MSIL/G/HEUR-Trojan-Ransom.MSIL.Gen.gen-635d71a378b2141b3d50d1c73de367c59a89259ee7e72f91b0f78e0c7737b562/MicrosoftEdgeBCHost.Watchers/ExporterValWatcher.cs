using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ExporterValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceStrategy()
	{
	}
}
